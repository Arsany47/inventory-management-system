namespace inventory_managment_system
{
    partial class products
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            panel_form = new Panel();
            btnClose = new Button();
            manageform = new Label();
            company_name = new Label();
            logo = new PictureBox();
            panel_product = new Panel();
            producttable = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Quntity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            btnopen = new Button();
            category = new ComboBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnADD = new Button();
            panel_control = new Panel();
            btn_print = new PictureBox();
            l_addproduct = new Label();
            t_pPRICE = new TextBox();
            t_pQTY = new TextBox();
            t_pName = new TextBox();
            t_pID = new TextBox();
            l_pprice = new Label();
            l_pname = new Label();
            l_pqty = new Label();
            l_id = new Label();
            label1 = new Label();
            tip = new ToolTip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel_form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)producttable).BeginInit();
            panel_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_print).BeginInit();
            SuspendLayout();
            // 
            // panel_form
            // 
            panel_form.BackColor = Color.FromArgb(2, 96, 129);
            panel_form.Controls.Add(btnClose);
            panel_form.Controls.Add(manageform);
            panel_form.Controls.Add(company_name);
            panel_form.Controls.Add(logo);
            panel_form.Dock = DockStyle.Top;
            panel_form.Location = new Point(0, 0);
            panel_form.Margin = new Padding(4, 3, 4, 3);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(1062, 87);
            panel_form.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(2, 96, 129);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(1015, 13);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 27);
            btnClose.TabIndex = 6;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // manageform
            // 
            manageform.AutoSize = true;
            manageform.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            manageform.ForeColor = Color.White;
            manageform.Location = new Point(464, 51);
            manageform.Margin = new Padding(4, 0, 4, 0);
            manageform.Name = "manageform";
            manageform.Size = new Size(113, 14);
            manageform.TabIndex = 10;
            manageform.Text = "mange products ";
            // 
            // company_name
            // 
            company_name.AutoSize = true;
            company_name.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            company_name.ForeColor = Color.White;
            company_name.Location = new Point(483, 13);
            company_name.Margin = new Padding(4, 0, 4, 0);
            company_name.Name = "company_name";
            company_name.Size = new Size(77, 38);
            company_name.TabIndex = 9;
            company_name.Text = "iMs";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.inventory_12141389;
            logo.Location = new Point(14, 3);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(141, 73);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // panel_product
            // 
            panel_product.BackColor = Color.FromArgb(2, 96, 129);
            panel_product.Controls.Add(producttable);
            panel_product.Location = new Point(491, 147);
            panel_product.Margin = new Padding(4, 3, 4, 3);
            panel_product.Name = "panel_product";
            panel_product.Size = new Size(556, 455);
            panel_product.TabIndex = 1;
            // 
            // producttable
            // 
            producttable.AllowUserToResizeColumns = false;
            producttable.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            producttable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            producttable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            producttable.Columns.AddRange(new DataGridViewColumn[] { ID, name, Quntity, Price });
            producttable.Cursor = Cursors.Hand;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            producttable.DefaultCellStyle = dataGridViewCellStyle6;
            producttable.EditMode = DataGridViewEditMode.EditProgrammatically;
            producttable.Location = new Point(21, 17);
            producttable.Margin = new Padding(4, 3, 4, 3);
            producttable.Name = "producttable";
            producttable.ReadOnly = true;
            producttable.Size = new Size(520, 421);
            producttable.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.DefaultCellStyle = dataGridViewCellStyle3;
            name.HeaderText = "name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Quntity
            // 
            Quntity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quntity.DefaultCellStyle = dataGridViewCellStyle4;
            Quntity.HeaderText = "Quntity";
            Quntity.Name = "Quntity";
            Quntity.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Price.DefaultCellStyle = dataGridViewCellStyle5;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // btnopen
            // 
            btnopen.BackColor = Color.FromArgb(2, 96, 129);
            btnopen.Cursor = Cursors.Hand;
            btnopen.FlatStyle = FlatStyle.Popup;
            btnopen.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnopen.ForeColor = Color.White;
            btnopen.Location = new Point(47, 367);
            btnopen.Margin = new Padding(4, 3, 4, 3);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(155, 42);
            btnopen.TabIndex = 5;
            btnopen.Text = "Open";
            btnopen.UseVisualStyleBackColor = false;
            btnopen.Click += btnopen_Click;
            btnopen.MouseHover += btnopen_MouseHover;
            // 
            // category
            // 
            category.BackColor = Color.FromArgb(2, 96, 129);
            category.Cursor = Cursors.Hand;
            category.FlatStyle = FlatStyle.Popup;
            category.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category.ForeColor = Color.White;
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "laptop", "taplet", "phone", "headset" });
            category.Location = new Point(47, 307);
            category.Margin = new Padding(4, 3, 4, 3);
            category.Name = "category";
            category.Size = new Size(271, 26);
            category.TabIndex = 4;
            category.MouseHover += category_MouseHover;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(2, 96, 129);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(47, 440);
            btnEdit.Margin = new Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(155, 42);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            btnEdit.MouseHover += btnEdit_MouseHover;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(2, 96, 129);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(233, 440);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(155, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            btnDelete.MouseHover += btnDelete_MouseHover;
            // 
            // btnADD
            // 
            btnADD.BackColor = Color.FromArgb(2, 96, 129);
            btnADD.Cursor = Cursors.Hand;
            btnADD.Enabled = false;
            btnADD.FlatStyle = FlatStyle.Popup;
            btnADD.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnADD.ForeColor = Color.White;
            btnADD.Location = new Point(233, 367);
            btnADD.Margin = new Padding(4, 3, 4, 3);
            btnADD.Name = "btnADD";
            btnADD.Size = new Size(155, 42);
            btnADD.TabIndex = 1;
            btnADD.Text = "Add";
            btnADD.UseVisualStyleBackColor = false;
            btnADD.Click += btnAdd_Click;
            btnADD.MouseHover += btnADD_MouseHover;
            // 
            // panel_control
            // 
            panel_control.Controls.Add(btn_print);
            panel_control.Controls.Add(btnDelete);
            panel_control.Controls.Add(btnEdit);
            panel_control.Controls.Add(btnopen);
            panel_control.Controls.Add(l_addproduct);
            panel_control.Controls.Add(btnADD);
            panel_control.Controls.Add(category);
            panel_control.Controls.Add(t_pPRICE);
            panel_control.Controls.Add(t_pQTY);
            panel_control.Controls.Add(t_pName);
            panel_control.Controls.Add(t_pID);
            panel_control.Controls.Add(l_pprice);
            panel_control.Controls.Add(l_pname);
            panel_control.Controls.Add(l_pqty);
            panel_control.Controls.Add(l_id);
            panel_control.Location = new Point(26, 93);
            panel_control.Margin = new Padding(4, 3, 4, 3);
            panel_control.Name = "panel_control";
            panel_control.Size = new Size(455, 508);
            panel_control.TabIndex = 4;
            // 
            // btn_print
            // 
            btn_print.Enabled = false;
            btn_print.Image = (Image)resources.GetObject("btn_print.Image");
            btn_print.Location = new Point(326, 307);
            btn_print.Margin = new Padding(4, 3, 4, 3);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(62, 26);
            btn_print.SizeMode = PictureBoxSizeMode.Zoom;
            btn_print.TabIndex = 10;
            btn_print.TabStop = false;
            btn_print.Click += pictureBox2_Click;
            btn_print.MouseHover += pictureBox2_MouseHover;
            // 
            // l_addproduct
            // 
            l_addproduct.AutoSize = true;
            l_addproduct.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_addproduct.ForeColor = Color.FromArgb(2, 96, 129);
            l_addproduct.Location = new Point(122, 11);
            l_addproduct.Margin = new Padding(4, 0, 4, 0);
            l_addproduct.Name = "l_addproduct";
            l_addproduct.Size = new Size(156, 25);
            l_addproduct.TabIndex = 9;
            l_addproduct.Text = "Add Product";
            // 
            // t_pPRICE
            // 
            t_pPRICE.BackColor = Color.FromArgb(2, 96, 129);
            t_pPRICE.BorderStyle = BorderStyle.FixedSingle;
            t_pPRICE.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pPRICE.ForeColor = Color.White;
            t_pPRICE.Location = new Point(208, 225);
            t_pPRICE.Margin = new Padding(4, 3, 4, 3);
            t_pPRICE.Name = "t_pPRICE";
            t_pPRICE.Size = new Size(218, 27);
            t_pPRICE.TabIndex = 8;
            // 
            // t_pQTY
            // 
            t_pQTY.BackColor = Color.FromArgb(2, 96, 129);
            t_pQTY.BorderStyle = BorderStyle.FixedSingle;
            t_pQTY.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pQTY.ForeColor = Color.White;
            t_pQTY.Location = new Point(208, 165);
            t_pQTY.Margin = new Padding(4, 3, 4, 3);
            t_pQTY.Name = "t_pQTY";
            t_pQTY.Size = new Size(218, 27);
            t_pQTY.TabIndex = 7;
            t_pQTY.KeyDown += t_pQTY_KeyDown;
            // 
            // t_pName
            // 
            t_pName.BackColor = Color.FromArgb(2, 96, 129);
            t_pName.BorderStyle = BorderStyle.FixedSingle;
            t_pName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pName.ForeColor = Color.White;
            t_pName.Location = new Point(208, 106);
            t_pName.Margin = new Padding(4, 3, 4, 3);
            t_pName.Name = "t_pName";
            t_pName.Size = new Size(218, 27);
            t_pName.TabIndex = 6;
            t_pName.KeyDown += t_pName_KeyDown;
            // 
            // t_pID
            // 
            t_pID.BackColor = Color.FromArgb(2, 96, 129);
            t_pID.BorderStyle = BorderStyle.FixedSingle;
            t_pID.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            t_pID.ForeColor = Color.White;
            t_pID.Location = new Point(208, 54);
            t_pID.Margin = new Padding(4, 3, 4, 3);
            t_pID.Name = "t_pID";
            t_pID.Size = new Size(218, 26);
            t_pID.TabIndex = 5;
            t_pID.KeyDown += t_pID_KeyDown;
            // 
            // l_pprice
            // 
            l_pprice.AutoSize = true;
            l_pprice.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_pprice.ForeColor = Color.FromArgb(2, 96, 129);
            l_pprice.Location = new Point(21, 222);
            l_pprice.Margin = new Padding(4, 0, 4, 0);
            l_pprice.Name = "l_pprice";
            l_pprice.Size = new Size(147, 23);
            l_pprice.TabIndex = 3;
            l_pprice.Text = "ProductPrice";
            // 
            // l_pname
            // 
            l_pname.AutoSize = true;
            l_pname.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_pname.ForeColor = Color.FromArgb(2, 96, 129);
            l_pname.Location = new Point(21, 103);
            l_pname.Margin = new Padding(4, 0, 4, 0);
            l_pname.Name = "l_pname";
            l_pname.Size = new Size(155, 23);
            l_pname.TabIndex = 2;
            l_pname.Text = "ProductName";
            // 
            // l_pqty
            // 
            l_pqty.AutoSize = true;
            l_pqty.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_pqty.ForeColor = Color.FromArgb(2, 96, 129);
            l_pqty.Location = new Point(21, 162);
            l_pqty.Margin = new Padding(4, 0, 4, 0);
            l_pqty.Name = "l_pqty";
            l_pqty.Size = new Size(130, 23);
            l_pqty.TabIndex = 1;
            l_pqty.Text = "ProductQty";
            // 
            // l_id
            // 
            l_id.AutoSize = true;
            l_id.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_id.ForeColor = Color.FromArgb(2, 96, 129);
            l_id.Location = new Point(21, 51);
            l_id.Margin = new Padding(4, 0, 4, 0);
            l_id.Name = "l_id";
            l_id.Size = new Size(119, 23);
            l_id.TabIndex = 0;
            l_id.Text = "ProductID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(2, 96, 129);
            label1.Location = new Point(682, 104);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 5;
            label1.Text = "Product List";
            // 
            // products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1062, 627);
            Controls.Add(label1);
            Controls.Add(panel_product);
            Controls.Add(panel_form);
            Controls.Add(panel_control);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "products";
            panel_form.ResumeLayout(false);
            panel_form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel_product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)producttable).EndInit();
            panel_control.ResumeLayout(false);
            panel_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_print).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Panel panel_control;
        private System.Windows.Forms.DataGridView producttable;
        private System.Windows.Forms.Label manageform;
        private System.Windows.Forms.Label company_name;
        private System.Windows.Forms.Label l_pprice;
        private System.Windows.Forms.Label l_pname;
        private System.Windows.Forms.Label l_pqty;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_pPRICE;
        private System.Windows.Forms.TextBox t_pQTY;
        private System.Windows.Forms.TextBox t_pName;
        private System.Windows.Forms.TextBox t_pID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label l_addproduct;
        private System.Windows.Forms.ToolTip tip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Quntity;
        private DataGridViewTextBoxColumn Price;
        private PictureBox btn_print;
    }
}