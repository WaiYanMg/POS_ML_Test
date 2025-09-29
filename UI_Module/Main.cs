using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POS_ML_Test.Program;

namespace POS_ML_Test.UI_Module
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes main form and exits app
        }
        private frm_items _frm_items = null;
        private void btn_items_Click(object sender, EventArgs e)
        {
            //frm_items _frm_items = new frm_items();
           // _frm_items.Show();

            // If instance is already open, bring it to front
            if (_frm_items != null && !_frm_items.IsDisposed)
            {
                _frm_items.BringToFront();
                return;
            }

            // Create a new instance
            _frm_items = new frm_items();

            // Show as modal dialog to freeze main form
            _frm_items.ShowDialog();

            // After closing, set instance to null
            _frm_items = null;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lab_user_log_in.Text = $"{Current_User.Current_user_name}";
        }
    }
}
