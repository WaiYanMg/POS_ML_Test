namespace POS_ML_Test.UI_Module
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sale = new Button();
            btn_items = new Button();
            btn_invoices = new Button();
            btn_reports = new Button();
            btn_exit = new Button();
            label1 = new Label();
            lab_user_log_in = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_sale);
            flowLayoutPanel1.Controls.Add(btn_items);
            flowLayoutPanel1.Controls.Add(btn_invoices);
            flowLayoutPanel1.Controls.Add(btn_reports);
            flowLayoutPanel1.Controls.Add(btn_exit);
            flowLayoutPanel1.Location = new Point(38, 76);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 341);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_sale
            // 
            btn_sale.Location = new Point(3, 3);
            btn_sale.Name = "btn_sale";
            btn_sale.Size = new Size(332, 145);
            btn_sale.TabIndex = 0;
            btn_sale.Text = "New Sale";
            btn_sale.UseVisualStyleBackColor = true;
            // 
            // btn_items
            // 
            btn_items.Location = new Point(341, 3);
            btn_items.Name = "btn_items";
            btn_items.Size = new Size(299, 145);
            btn_items.TabIndex = 1;
            btn_items.Text = "Manage Items";
            btn_items.UseVisualStyleBackColor = true;
            btn_items.Click += btn_items_Click;
            // 
            // btn_invoices
            // 
            btn_invoices.Location = new Point(3, 154);
            btn_invoices.Name = "btn_invoices";
            btn_invoices.Size = new Size(232, 124);
            btn_invoices.TabIndex = 2;
            btn_invoices.Text = "Invoices";
            btn_invoices.UseVisualStyleBackColor = true;
            // 
            // btn_reports
            // 
            btn_reports.Location = new Point(241, 154);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(203, 124);
            btn_reports.TabIndex = 3;
            btn_reports.Text = "Reports";
            btn_reports.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(450, 154);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(190, 124);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 1;
            label1.Text = "Current User :";
            label1.Click += label1_Click;
            // 
            // lab_user_log_in
            // 
            lab_user_log_in.AutoSize = true;
            lab_user_log_in.Location = new Point(144, 30);
            lab_user_log_in.Name = "lab_user_log_in";
            lab_user_log_in.Size = new Size(18, 20);
            lab_user_log_in.TabIndex = 2;
            lab_user_log_in.Text = "...";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(lab_user_log_in);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS Main Menu";
            Load += Main_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btn_sale;
        private Button btn_items;
        private Button btn_invoices;
        private Button btn_reports;
        private Button btn_exit;
        private Label lab_user_log_in;
    }
}