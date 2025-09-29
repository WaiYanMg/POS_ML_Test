namespace POS_ML_Test.UI_Module
{
    partial class frm_items
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
            components = new System.ComponentModel.Container();
            dgv_items = new DataGridView();
            Item_ID = new DataGridViewTextBoxColumn();
            ItemCode = new DataGridViewTextBoxColumn();
            ItemName = new DataGridViewTextBoxColumn();
            ItemType = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            ItemQuanity = new DataGridViewTextBoxColumn();
            ItemPrice = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            ItemCreatedOn = new DataGridViewTextBoxColumn();
            ItemModifiedOn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tb_item_code = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripTextBox1 = new ToolStripTextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tb_item_name = new TextBox();
            tb_description = new TextBox();
            Cbb_Item_type = new ComboBox();
            tb_price = new TextBox();
            tb_quantity = new TextBox();
            tb_remark = new TextBox();
            lab_status = new Label();
            btn_save = new Button();
            btn_new = new Button();
            btn_delete = new Button();
            btn_exit = new Button();
            label10 = new Label();
            tb_search = new TextBox();
            dtp_from = new DateTimePicker();
            dtp_to = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            panl_info = new Panel();
            tb_modified_by_on = new TextBox();
            tb_created_by_on = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_items).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panl_info.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_items
            // 
            dgv_items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_items.Columns.AddRange(new DataGridViewColumn[] { Item_ID, ItemCode, ItemName, ItemType, Description, ItemQuanity, ItemPrice, Remark, ItemCreatedOn, ItemModifiedOn });
            dgv_items.Location = new Point(418, 127);
            dgv_items.Name = "dgv_items";
            dgv_items.RowHeadersWidth = 51;
            dgv_items.Size = new Size(1140, 350);
            dgv_items.TabIndex = 0;
            dgv_items.CellDoubleClick += dgv_items_CellDoubleClick;
            // 
            // Item_ID
            // 
            Item_ID.DataPropertyName = "Item_ID";
            Item_ID.HeaderText = "ItemID";
            Item_ID.MinimumWidth = 6;
            Item_ID.Name = "Item_ID";
            Item_ID.Visible = false;
            Item_ID.Width = 125;
            // 
            // ItemCode
            // 
            ItemCode.DataPropertyName = "Item_Code";
            ItemCode.HeaderText = "Code";
            ItemCode.MinimumWidth = 6;
            ItemCode.Name = "ItemCode";
            ItemCode.Width = 125;
            // 
            // ItemName
            // 
            ItemName.DataPropertyName = "Item_Name";
            ItemName.HeaderText = "Name";
            ItemName.MinimumWidth = 6;
            ItemName.Name = "ItemName";
            ItemName.Width = 125;
            // 
            // ItemType
            // 
            ItemType.DataPropertyName = "Item_Type";
            ItemType.HeaderText = "Type";
            ItemType.MinimumWidth = 6;
            ItemType.Name = "ItemType";
            ItemType.Width = 125;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.Width = 125;
            // 
            // ItemQuanity
            // 
            ItemQuanity.DataPropertyName = "Quantity";
            ItemQuanity.HeaderText = "Qty";
            ItemQuanity.MinimumWidth = 6;
            ItemQuanity.Name = "ItemQuanity";
            ItemQuanity.Width = 125;
            // 
            // ItemPrice
            // 
            ItemPrice.DataPropertyName = "Price";
            ItemPrice.HeaderText = "Price";
            ItemPrice.MinimumWidth = 6;
            ItemPrice.Name = "ItemPrice";
            ItemPrice.Width = 125;
            // 
            // Remark
            // 
            Remark.DataPropertyName = "Remark";
            Remark.HeaderText = "Remark";
            Remark.MinimumWidth = 6;
            Remark.Name = "Remark";
            Remark.Width = 125;
            // 
            // ItemCreatedOn
            // 
            ItemCreatedOn.DataPropertyName = "Created_On";
            ItemCreatedOn.HeaderText = "Created On";
            ItemCreatedOn.MinimumWidth = 6;
            ItemCreatedOn.Name = "ItemCreatedOn";
            ItemCreatedOn.Width = 125;
            // 
            // ItemModifiedOn
            // 
            ItemModifiedOn.DataPropertyName = "Modified_On";
            ItemModifiedOn.HeaderText = "Modified On";
            ItemModifiedOn.MinimumWidth = 6;
            ItemModifiedOn.Name = "ItemModifiedOn";
            ItemModifiedOn.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // tb_item_code
            // 
            tb_item_code.Location = new Point(126, 58);
            tb_item_code.Name = "tb_item_code";
            tb_item_code.Size = new Size(271, 27);
            tb_item_code.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 27);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 61);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Item Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 5;
            label3.Text = "Item Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 127);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 6;
            label4.Text = "Item Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 161);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 7;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(79, 194);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 8;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(55, 227);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 9;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 260);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 10;
            label8.Text = "Remark";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 363);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 11;
            // 
            // tb_item_name
            // 
            tb_item_name.Location = new Point(126, 91);
            tb_item_name.Name = "tb_item_name";
            tb_item_name.Size = new Size(271, 27);
            tb_item_name.TabIndex = 13;
            // 
            // tb_description
            // 
            tb_description.Location = new Point(126, 158);
            tb_description.Name = "tb_description";
            tb_description.Size = new Size(271, 27);
            tb_description.TabIndex = 14;
            // 
            // Cbb_Item_type
            // 
            Cbb_Item_type.FormattingEnabled = true;
            Cbb_Item_type.Items.AddRange(new object[] { "General", "Electric", "Food", "Beverage", "Tools" });
            Cbb_Item_type.Location = new Point(126, 124);
            Cbb_Item_type.Name = "Cbb_Item_type";
            Cbb_Item_type.Size = new Size(271, 28);
            Cbb_Item_type.TabIndex = 15;
            // 
            // tb_price
            // 
            tb_price.ImeMode = ImeMode.NoControl;
            tb_price.Location = new Point(126, 191);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(271, 27);
            tb_price.TabIndex = 16;
            tb_price.KeyPress += tb_price_KeyPress;
            // 
            // tb_quantity
            // 
            tb_quantity.Location = new Point(126, 224);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(271, 27);
            tb_quantity.TabIndex = 17;
            tb_quantity.KeyPress += tb_quantity_KeyPress;
            // 
            // tb_remark
            // 
            tb_remark.Location = new Point(126, 257);
            tb_remark.Multiline = true;
            tb_remark.Name = "tb_remark";
            tb_remark.Size = new Size(271, 66);
            tb_remark.TabIndex = 18;
            // 
            // lab_status
            // 
            lab_status.AutoSize = true;
            lab_status.ForeColor = Color.Crimson;
            lab_status.Location = new Point(87, 26);
            lab_status.Name = "lab_status";
            lab_status.Size = new Size(27, 20);
            lab_status.TabIndex = 21;
            lab_status.Text = "---";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.PaleGreen;
            btn_save.Location = new Point(126, 341);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(130, 65);
            btn_save.TabIndex = 22;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.Honeydew;
            btn_new.Location = new Point(126, 412);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(130, 65);
            btn_new.TabIndex = 23;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Salmon;
            btn_delete.Location = new Point(267, 341);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(130, 65);
            btn_delete.TabIndex = 24;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.LightCoral;
            btn_exit.Location = new Point(267, 412);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(130, 65);
            btn_exit.TabIndex = 25;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(505, 91);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 26;
            label10.Text = "Search";
            // 
            // tb_search
            // 
            tb_search.Location = new Point(578, 88);
            tb_search.Name = "tb_search";
            tb_search.Size = new Size(207, 27);
            tb_search.TabIndex = 27;
            tb_search.TextChanged += tb_search_TextChanged;
            // 
            // dtp_from
            // 
            dtp_from.Checked = false;
            dtp_from.CustomFormat = "dd-MM-yyyy";
            dtp_from.Format = DateTimePickerFormat.Custom;
            dtp_from.Location = new Point(884, 87);
            dtp_from.Name = "dtp_from";
            dtp_from.ShowCheckBox = true;
            dtp_from.Size = new Size(145, 27);
            dtp_from.TabIndex = 28;
            dtp_from.ValueChanged += dtp_from_ValueChanged;
            // 
            // dtp_to
            // 
            dtp_to.Checked = false;
            dtp_to.CustomFormat = "dd-MM-yyyy";
            dtp_to.Format = DateTimePickerFormat.Custom;
            dtp_to.Location = new Point(1093, 87);
            dtp_to.Name = "dtp_to";
            dtp_to.ShowCheckBox = true;
            dtp_to.Size = new Size(145, 27);
            dtp_to.TabIndex = 29;
            dtp_to.ValueChanged += dtp_to_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(835, 91);
            label11.Name = "label11";
            label11.Size = new Size(43, 20);
            label11.TabIndex = 30;
            label11.Text = "From";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1062, 91);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 31;
            label12.Text = "To";
            // 
            // panl_info
            // 
            panl_info.Controls.Add(tb_modified_by_on);
            panl_info.Controls.Add(tb_created_by_on);
            panl_info.Location = new Point(12, 502);
            panl_info.Name = "panl_info";
            panl_info.Padding = new Padding(5, 0, 5, 0);
            panl_info.Size = new Size(736, 67);
            panl_info.TabIndex = 32;
            // 
            // tb_modified_by_on
            // 
            tb_modified_by_on.Location = new Point(10, 37);
            tb_modified_by_on.Name = "tb_modified_by_on";
            tb_modified_by_on.Size = new Size(718, 27);
            tb_modified_by_on.TabIndex = 33;
            // 
            // tb_created_by_on
            // 
            tb_created_by_on.Location = new Point(10, 7);
            tb_created_by_on.Name = "tb_created_by_on";
            tb_created_by_on.Size = new Size(718, 27);
            tb_created_by_on.TabIndex = 33;
            // 
            // frm_items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1553, 581);
            Controls.Add(panl_info);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(dtp_to);
            Controls.Add(dtp_from);
            Controls.Add(tb_search);
            Controls.Add(label10);
            Controls.Add(btn_exit);
            Controls.Add(btn_delete);
            Controls.Add(btn_new);
            Controls.Add(btn_save);
            Controls.Add(lab_status);
            Controls.Add(tb_remark);
            Controls.Add(tb_quantity);
            Controls.Add(tb_price);
            Controls.Add(Cbb_Item_type);
            Controls.Add(tb_description);
            Controls.Add(tb_item_name);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_item_code);
            Controls.Add(label1);
            Controls.Add(dgv_items);
            Name = "frm_items";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_items";
            Load += frm_items_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_items).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip1.PerformLayout();
            panl_info.ResumeLayout(false);
            panl_info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_items;
        private Label label1;
        private TextBox tb_item_code;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox toolStripTextBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tb_item_name;
        private TextBox tb_description;
        private ComboBox Cbb_Item_type;
        private TextBox tb_price;
        private TextBox tb_quantity;
        private TextBox tb_remark;
        private Label lab_status;
        private Button btn_save;
        private Button btn_new;
        private Button btn_delete;
        private Button btn_exit;
        private Label label10;
        private TextBox tb_search;
        private DateTimePicker dtp_from;
        private DateTimePicker dtp_to;
        private Label label11;
        private Label label12;
        private Panel panl_info;
        private TextBox tb_modified_by_on;
        private TextBox tb_created_by_on;
        private DataGridViewTextBoxColumn Item_ID;
        private DataGridViewTextBoxColumn ItemCode;
        private DataGridViewTextBoxColumn ItemName;
        private DataGridViewTextBoxColumn ItemType;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn ItemQuanity;
        private DataGridViewTextBoxColumn ItemPrice;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewTextBoxColumn ItemCreatedOn;
        private DataGridViewTextBoxColumn ItemModifiedOn;
    }
}