namespace inventory_managment_system
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            panel1 = new Panel();
            pic_signup = new PictureBox();
            label5 = new Label();
            companyname = new Label();
            btnClose = new Button();
            btnSignup = new Button();
            txtlname = new TextBox();
            txtfname = new TextBox();
            l_signup = new Label();
            txtemail = new TextBox();
            txtpassword = new TextBox();
            txtcpassword = new TextBox();
            l_fname = new Label();
            l_lname = new Label();
            l_email = new Label();
            l_pass = new Label();
            l_passconfirm = new Label();
            l_username = new Label();
            txtusername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_signup).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 96, 129);
            panel1.Controls.Add(pic_signup);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(companyname);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 419);
            panel1.TabIndex = 9;
            // 
            // pic_signup
            // 
            pic_signup.Image = Properties.Resources.user;
            pic_signup.Location = new Point(36, 181);
            pic_signup.Name = "pic_signup";
            pic_signup.Size = new Size(159, 130);
            pic_signup.SizeMode = PictureBoxSizeMode.Zoom;
            pic_signup.TabIndex = 0;
            pic_signup.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(23, 91);
            label5.Name = "label5";
            label5.Size = new Size(186, 14);
            label5.TabIndex = 18;
            label5.Text = "inventory mangment system";
            // 
            // companyname
            // 
            companyname.AutoSize = true;
            companyname.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            companyname.ForeColor = Color.White;
            companyname.Location = new Point(75, 53);
            companyname.Name = "companyname";
            companyname.Size = new Size(77, 38);
            companyname.TabIndex = 16;
            companyname.Text = "iMs";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(2, 96, 129);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(590, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(28, 23);
            btnClose.TabIndex = 15;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.FromArgb(2, 96, 129);
            btnSignup.Cursor = Cursors.Hand;
            btnSignup.FlatStyle = FlatStyle.Popup;
            btnSignup.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(323, 351);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(231, 36);
            btnSignup.TabIndex = 10;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnsignup_Click;
            // 
            // txtlname
            // 
            txtlname.AcceptsReturn = true;
            txtlname.BackColor = Color.White;
            txtlname.BorderStyle = BorderStyle.FixedSingle;
            txtlname.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlname.Location = new Point(462, 99);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(156, 26);
            txtlname.TabIndex = 14;
            txtlname.KeyDown += txtlname_KeyDown;
            // 
            // txtfname
            // 
            txtfname.AccessibleDescription = "";
            txtfname.BackColor = Color.White;
            txtfname.BorderStyle = BorderStyle.FixedSingle;
            txtfname.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfname.Location = new Point(282, 99);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(153, 26);
            txtfname.TabIndex = 13;
            txtfname.KeyDown += txtfname_KeyDown;
            // 
            // l_signup
            // 
            l_signup.AutoSize = true;
            l_signup.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_signup.ForeColor = Color.FromArgb(2, 96, 129);
            l_signup.Location = new Point(371, 34);
            l_signup.Name = "l_signup";
            l_signup.Size = new Size(155, 38);
            l_signup.TabIndex = 17;
            l_signup.Text = "Sign Up";
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(282, 206);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(336, 26);
            txtemail.TabIndex = 18;
            txtemail.KeyDown += txtemail_KeyDown;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(282, 260);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(336, 26);
            txtpassword.TabIndex = 19;
            txtpassword.Tag = "";
            txtpassword.KeyDown += txtpassword_KeyDown;
            // 
            // txtcpassword
            // 
            txtcpassword.BackColor = Color.White;
            txtcpassword.BorderStyle = BorderStyle.FixedSingle;
            txtcpassword.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpassword.Location = new Point(282, 314);
            txtcpassword.Name = "txtcpassword";
            txtcpassword.Size = new Size(336, 26);
            txtcpassword.TabIndex = 20;
            txtcpassword.Tag = "";
            txtcpassword.KeyDown += txtcpassword_KeyDown;
            // 
            // l_fname
            // 
            l_fname.AutoSize = true;
            l_fname.Location = new Point(279, 83);
            l_fname.Name = "l_fname";
            l_fname.Size = new Size(68, 13);
            l_fname.TabIndex = 21;
            l_fname.Text = "First Name";
            // 
            // l_lname
            // 
            l_lname.AutoSize = true;
            l_lname.Location = new Point(459, 83);
            l_lname.Name = "l_lname";
            l_lname.Size = new Size(67, 13);
            l_lname.TabIndex = 22;
            l_lname.Text = "Last Name";
            // 
            // l_email
            // 
            l_email.AutoSize = true;
            l_email.Location = new Point(280, 190);
            l_email.Name = "l_email";
            l_email.Size = new Size(38, 13);
            l_email.TabIndex = 23;
            l_email.Text = "Email";
            // 
            // l_pass
            // 
            l_pass.AutoSize = true;
            l_pass.Location = new Point(280, 244);
            l_pass.Name = "l_pass";
            l_pass.Size = new Size(61, 13);
            l_pass.TabIndex = 24;
            l_pass.Text = "Password";
            // 
            // l_passconfirm
            // 
            l_passconfirm.AutoSize = true;
            l_passconfirm.Location = new Point(280, 298);
            l_passconfirm.Name = "l_passconfirm";
            l_passconfirm.Size = new Size(111, 13);
            l_passconfirm.TabIndex = 25;
            l_passconfirm.Text = "Password Confirm";
            // 
            // l_username
            // 
            l_username.AutoSize = true;
            l_username.Location = new Point(280, 133);
            l_username.Name = "l_username";
            l_username.Size = new Size(64, 13);
            l_username.TabIndex = 27;
            l_username.Text = "username";
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(282, 149);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(336, 26);
            txtusername.TabIndex = 26;
            txtusername.KeyDown += txtusername_KeyDown;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 419);
            Controls.Add(l_username);
            Controls.Add(txtusername);
            Controls.Add(l_passconfirm);
            Controls.Add(l_pass);
            Controls.Add(l_email);
            Controls.Add(l_lname);
            Controls.Add(l_fname);
            Controls.Add(txtcpassword);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(l_signup);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSignup);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "signUP";
            Load += signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_signup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_signup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label companyname;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label l_signup;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.Label l_fname;
        private System.Windows.Forms.Label l_lname;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_pass;
        private System.Windows.Forms.Label l_passconfirm;
        private System.Windows.Forms.Label l_username;
        private System.Windows.Forms.TextBox txtusername;
    }
}