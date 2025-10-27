using POS_ML_Test.UI_Module;
using System.Data.SqlClient;
using static POS_ML_Test.Program;

namespace POS_ML_Test
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();

            // Bind Enter key to login
            this.AcceptButton = btn_log_in;
        }

        private void btn_log_in_Click(object sender, EventArgs e)
        {
            string username = tb_user_name.Text.Trim();
            string password = tb_password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                Program.LoadConnectionString();

                using (SqlConnection conn = new SqlConnection(Program.ConnectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT User_ID, User_name
                FROM User_tbl
                WHERE User_name = @username 
                  AND Password = @password 
                  AND Active = 1";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Current_User.Current_user_id = reader.GetGuid(0);
                                Current_User.Current_user_name = reader.GetString(1);

                                //MessageBox.Show("Login successful!");

                               
                                Program.ShowAutoMessage("Login successful!", 1000);
                               
                                this.Hide();
                                Main mainForm = new Main();
                                mainForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }
    }
}
