using System;
using System.Data;
using System.Windows.Forms;
using POS_ML_Data.Models;
using POS_ML_Data.Data_Access;
using static POS_ML_Test.Program;




namespace POS_ML_Test.UI_Module
{
    public partial class frm_items : Form
    {
        private DA_Item _daItem;
        private M_item _currentItem;
        public frm_items()
        {
            InitializeComponent();
            _daItem = new DA_Item(ConnectionString); // initialize data access
            _currentItem = null;
        }
        
        private void do_save()
        {
            try
            {
                if (!decimal.TryParse(tb_price.Text, out decimal price))
                {
                    MessageBox.Show("Invalid Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_price.Focus();
                    return;
                }

                if (!int.TryParse(tb_quantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_quantity.Focus();
                    return;
                }

                if (_currentItem == null)
                    _currentItem = new M_item(); // new item

                _currentItem.Item_Code = tb_item_code.Text;
                _currentItem.Item_Name = tb_item_name.Text;
                _currentItem.Item_Type = Cbb_Item_type.Text;
                _currentItem.Description = tb_description.Text;
                _currentItem.Price = price;
                _currentItem.Quantity = quantity;
                _currentItem.Remark = tb_remark.Text;
                _currentItem.Modified_By = Current_User.Current_user_id;

                if (!_currentItem.Item_ID.HasValue) // new item
                    _currentItem.Created_By = Current_User.Current_user_id;

                _daItem.Save_Item(_currentItem); // call DAL save method

                lab_status.Text = "Saved";
                MessageBox.Show("Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                do_load_list();
                do_new();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lab_status.Text = "Error";
            }
        }




        private void do_new()
        {
            _currentItem = null;

            tb_item_code.Clear();
            tb_item_name.Clear();
            Cbb_Item_type.SelectedIndex = -1;
            tb_description.Clear();
            tb_price.Clear();
            tb_quantity.Clear();
            tb_remark.Clear();

            lab_status.Text = "";
            tb_item_code.Focus();

        }

        private void do_delete()
        {
            try
            {
                if (_currentItem == null || !_currentItem.Item_ID.HasValue)
                {
                    MessageBox.Show("No item selected to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                _daItem.Delete_Item(_currentItem.Item_ID.Value, Current_User.Current_user_id);

                lab_status.Text = "Deleted";
                MessageBox.Show("Item deleted (set to inactive).", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                do_load_list();
                do_new();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lab_status.Text = "Error";
            }
        }


        private void do_load_list()
        {
            try
            {
                string search = tb_search.Text.Trim();
                DateTime? fromDate = dtp_from.Checked ? dtp_from.Value.Date : (DateTime?)null;
                DateTime? toDate = dtp_to.Checked ? dtp_to.Value.Date : (DateTime?)null;

                DataTable dt = _daItem.Get_Item_list(search, fromDate, toDate);
                dgv_items.DataSource = dt;

                lab_status.Text = "Loaded";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lab_status.Text = "Error";
            }
        }





        private void do_load(Guid itemId)
        {
            try
            {
                _currentItem = _daItem.Get_Item_Id(itemId);
                if (_currentItem == null)
                {
                    MessageBox.Show("Item not found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                tb_item_code.Text = _currentItem.Item_Code;
                tb_item_name.Text = _currentItem.Item_Name;
                Cbb_Item_type.Text = _currentItem.Item_Type;
                tb_description.Text = _currentItem.Description;
                tb_price.Text = _currentItem.Price.ToString("0.##");
                tb_quantity.Text = _currentItem.Quantity.ToString();
                tb_remark.Text = _currentItem.Remark;

                tb_created_by_on.Text = Created_Info(_currentItem.Created_By_Name, _currentItem.Created_On);
                tb_modified_by_on.Text = Modified_Info(_currentItem.Modified_By_Name, _currentItem.Modified_On);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgv_items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var idValue = dgv_items.Rows[e.RowIndex].Cells["Item_ID"].Value;
                if (idValue != null && Guid.TryParse(idValue.ToString(), out Guid itemId))
                    do_load(itemId);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            do_save();
            do_load_list();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            do_delete();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            do_new();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.AllowDecimalInput(sender, e);
        }

        private void tb_quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.AllowIntegerInput(sender, e);
        }

        private void frm_items_Load(object sender, EventArgs e)
        {
            dgv_items.AutoGenerateColumns = false; // keep designer columns
           do_load_list();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            do_load_list();
        }

        private void dtp_from_ValueChanged(object sender, EventArgs e)
        {
            do_load_list();
        }

        private void dtp_to_ValueChanged(object sender, EventArgs e)
        {
            do_load_list();
        }
    }
}
