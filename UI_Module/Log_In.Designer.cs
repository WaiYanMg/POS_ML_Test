namespace POS_ML_Test
{
    partial class Log_In
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_log_in = new Button();
            label1 = new Label();
            tb_password = new TextBox();
            label2 = new Label();
            tb_user_name = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_log_in);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_user_name);
            panel1.Location = new Point(295, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 283);
            panel1.TabIndex = 2;
            // 
            // btn_log_in
            // 
            btn_log_in.Location = new Point(109, 154);
            btn_log_in.Name = "btn_log_in";
            btn_log_in.Size = new Size(226, 57);
            btn_log_in.TabIndex = 8;
            btn_log_in.Text = "Log In";
            btn_log_in.UseVisualStyleBackColor = true;
            btn_log_in.Click += btn_log_in_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 55);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 7;
            label1.Text = "User ID";
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_password.Location = new Point(109, 110);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(226, 27);
            tb_password.TabIndex = 5;
            tb_password.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // tb_user_name
            // 
            tb_user_name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user_name.Location = new Point(109, 52);
            tb_user_name.Name = "tb_user_name";
            tb_user_name.Size = new Size(226, 27);
            tb_user_name.TabIndex = 3;
            tb_user_name.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 39);
            label3.Name = "label3";
            label3.Size = new Size(237, 123);
            label3.TabIndex = 9;
            label3.Text = "POS \r\nMechine Lening \r\n.Net Test";
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 348);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Log_In";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox tb_user_name;
        private Label label2;
        private Button btn_log_in;
        private Label label1;
        private Label label3;
        protected TextBox tb_password;
    }
}
