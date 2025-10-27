using System;
using System.Data;
using System.Data.SqlClient;
using POS_ML_Data.Models;

namespace POS_ML_Test.Data_Acess
{
    internal class DA_Item
    {
        private readonly string _connectionString;

        public DA_Item(string connectionString)
        {
            _connectionString = connectionString;
        }

        #region Read Methods

        public DataTable Get_Item_list(string search, DateTime? fromDate, DateTime? toDate)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();

                // Select including Created/Modified names and dates
                string sql = @"
            SELECT Item_ID, Item_Code, Item_Name, Item_Type, Description,
                   Price, Quantity, Remark,
                   Created_By, Created_On, Created_By_Name,
                   Modified_By, Modified_On, Modified_By_Name,
                   Active
            FROM Item_View
            WHERE Active = 1";

                // Search filter
                if (!string.IsNullOrWhiteSpace(search))
                {
                    sql += @" AND (
                        LOWER(Item_Code) LIKE @Search OR
                        LOWER(Item_Name) LIKE @Search OR
                        LOWER(Item_Type) LIKE @Search OR
                        LOWER(Description) LIKE @Search OR
                        CONVERT(NVARCHAR, Price) LIKE @Search OR
                        CONVERT(NVARCHAR, Quantity) LIKE @Search OR
                        LOWER(Remark) LIKE @Search
                      )";
                }

                // Date filter
                if (fromDate.HasValue && toDate.HasValue)
                    sql += " AND Created_On >= @FromDate AND Created_On < DATEADD(DAY, 1, @ToDate)";
                else if (fromDate.HasValue)
                    sql += " AND Created_On >= @FromDate AND Created_On < DATEADD(DAY, 1, @FromDate)";

                sql += " ORDER BY Created_On DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (!string.IsNullOrWhiteSpace(search))
                        cmd.Parameters.Add("@Search", SqlDbType.NVarChar, 100).Value = "%" + search.ToLower() + "%";

                    if (fromDate.HasValue)
                        cmd.Parameters.Add("@FromDate", SqlDbType.DateTime).Value = fromDate.Value.Date;

                    if (toDate.HasValue)
                        cmd.Parameters.Add("@ToDate", SqlDbType.DateTime).Value = toDate.Value.Date;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public M_item Get_Item_Id(Guid itemId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Item_View WHERE Item_ID = @Item_ID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Item_ID", SqlDbType.UniqueIdentifier).Value = itemId;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new M_item
                            {
                                Item_ID = Guid.Parse(reader["Item_ID"].ToString()),
                                Item_Code = reader["Item_Code"].ToString(),
                                Item_Name = reader["Item_Name"].ToString(),
                                Item_Type = reader["Item_Type"].ToString(),
                                Description = reader["Description"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                Remark = reader["Remark"].ToString(),
                                Created_By = Guid.Parse(reader["Created_By"].ToString()),
                                Created_On = Convert.ToDateTime(reader["Created_On"]),
                                Created_By_Name = reader["Created_By_Name"].ToString(),
                                Modified_By = Guid.Parse(reader["Modified_By"].ToString()),
                                Modified_On = Convert.ToDateTime(reader["Modified_On"]),
                                Modified_By_Name = reader["Modified_By_Name"].ToString(),
                                Active = Convert.ToBoolean(reader["Active"])
                            };
                        }
                        return null;
                    }
                }
            }
        }

        #endregion

        #region Create/Update

        public void Save_Item(M_item item)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql;

                if (!item.Item_ID.HasValue)
                {
                    // Insert new
                    sql = @"
                        INSERT INTO Item_tbl
                        (Item_ID, Item_Code, Item_Name, Item_Type, Description, Price, Quantity, Remark, Created_On, Created_By, Modified_On, Modified_By, Active)
                        VALUES
                        (@Item_ID, @Item_Code, @Item_Name, @Item_Type, @Description, @Price, @Quantity, @Remark, GETDATE(), @Created_By, GETDATE(), @Modified_By, 1)";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        Guid newId = Guid.NewGuid();
                        cmd.Parameters.Add("@Item_ID", SqlDbType.UniqueIdentifier).Value = newId;
                        cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar, 50).Value = item.Item_Code;
                        cmd.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = item.Item_Name;
                        cmd.Parameters.Add("@Item_Type", SqlDbType.NVarChar, 50).Value = item.Item_Type;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 150).Value = item.Description;
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = item.Price;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = item.Quantity;
                        cmd.Parameters.Add("@Remark", SqlDbType.NVarChar, 200).Value = item.Remark;
                        cmd.Parameters.Add("@Created_By", SqlDbType.UniqueIdentifier).Value = item.Created_By;
                        cmd.Parameters.Add("@Modified_By", SqlDbType.UniqueIdentifier).Value = item.Modified_By;

                        cmd.ExecuteNonQuery();
                        item.Item_ID = newId;
                    }
                }
                else
                {
                    // Update existing
                    sql = @"
                        UPDATE Item_tbl
                        SET Item_Code=@Item_Code, Item_Name=@Item_Name, Item_Type=@Item_Type, Description=@Description,
                            Price=@Price, Quantity=@Quantity, Remark=@Remark, Modified_On=GETDATE(), Modified_By=@Modified_By
                        WHERE Item_ID=@Item_ID";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@Item_ID", SqlDbType.UniqueIdentifier).Value = item.Item_ID.Value;
                        cmd.Parameters.Add("@Item_Code", SqlDbType.NVarChar, 50).Value = item.Item_Code;
                        cmd.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50).Value = item.Item_Name;
                        cmd.Parameters.Add("@Item_Type", SqlDbType.NVarChar, 50).Value = item.Item_Type;
                        cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 150).Value = item.Description;
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = item.Price;
                        cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = item.Quantity;
                        cmd.Parameters.Add("@Remark", SqlDbType.NVarChar, 200).Value = item.Remark;
                        cmd.Parameters.Add("@Modified_By", SqlDbType.UniqueIdentifier).Value = item.Modified_By;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        #endregion

        #region Delete

        public void Delete_Item(Guid itemId, Guid modifiedBy)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE Item_tbl
                    SET Active = 0, Modified_On = GETDATE(), Modified_By = @Modified_By
                    WHERE Item_ID = @Item_ID";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Item_ID", SqlDbType.UniqueIdentifier).Value = itemId;
                    cmd.Parameters.Add("@Modified_By", SqlDbType.UniqueIdentifier).Value = modifiedBy;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}
