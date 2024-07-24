using Microsoft.VisualBasic.Logging;

namespace inventory_managment_system
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            label5 = new Label();
            logo = new PictureBox();
            label3 = new Label();
            btnlogin = new Button();
            l_user = new Label();
            l_pass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btnClose = new Button();
            l_reset = new Label();
            l_signup = new Label();
            l_login = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(2, 96, 129);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(logo);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 486);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 103);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 14);
            label5.TabIndex = 8;
            label5.Text = "inventory mangment system";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.inventory_12141389;
            logo.Location = new Point(14, 164);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(250, 222);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 38);
            label3.TabIndex = 6;
            label3.Text = "iMs";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(2, 96, 129);
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatStyle = FlatStyle.Popup;
            btnlogin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(434, 373);
            btnlogin.Margin = new Padding(4, 3, 4, 3);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(155, 42);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "log in";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // l_user
            // 
            l_user.AutoSize = true;
            l_user.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_user.ForeColor = Color.FromArgb(2, 96, 129);
            l_user.Location = new Point(356, 148);
            l_user.Margin = new Padding(4, 0, 4, 0);
            l_user.Name = "l_user";
            l_user.Size = new Size(117, 23);
            l_user.TabIndex = 1;
            l_user.Text = "username";
            // 
            // l_pass
            // 
            l_pass.AutoSize = true;
            l_pass.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_pass.ForeColor = Color.FromArgb(2, 96, 129);
            l_pass.Location = new Point(356, 257);
            l_pass.Margin = new Padding(4, 0, 4, 0);
            l_pass.Name = "l_pass";
            l_pass.Size = new Size(112, 23);
            l_pass.TabIndex = 2;
            l_pass.Text = "password";
            // 
            // txtuser
            // 
            txtuser.BackColor = Color.White;
            txtuser.BorderStyle = BorderStyle.FixedSingle;
            txtuser.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(360, 178);
            txtuser.Margin = new Padding(4, 3, 4, 3);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(343, 26);
            txtuser.TabIndex = 3;
            txtuser.KeyDown += txtuser_KeyDown;
            // 
            // txtpass
            // 
            txtpass.AcceptsReturn = true;
            txtpass.BackColor = Color.White;
            txtpass.BorderStyle = BorderStyle.FixedSingle;
            txtpass.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(360, 287);
            txtpass.Margin = new Padding(4, 3, 4, 3);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(343, 26);
            txtpass.TabIndex = 4;
            txtpass.UseSystemPasswordChar = true;
            txtpass.KeyDown += txtpass_KeyDown;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(2, 96, 129);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(710, 14);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(33, 27);
            btnClose.TabIndex = 5;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnclose_Click;
            // 
            // l_reset
            // 
            l_reset.AutoSize = true;
            l_reset.Cursor = Cursors.Hand;
            l_reset.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_reset.ForeColor = Color.FromArgb(2, 96, 129);
            l_reset.Location = new Point(538, 421);
            l_reset.Margin = new Padding(4, 0, 4, 0);
            l_reset.Name = "l_reset";
            l_reset.Size = new Size(71, 23);
            l_reset.TabIndex = 7;
            l_reset.Text = "Reset";
            l_reset.Click += l_reset_Click;
            // 
            // l_signup
            // 
            l_signup.AutoSize = true;
            l_signup.BackColor = Color.White;
            l_signup.Cursor = Cursors.Hand;
            l_signup.FlatStyle = FlatStyle.Popup;
            l_signup.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_signup.ForeColor = Color.FromArgb(2, 96, 129);
            l_signup.Location = new Point(396, 421);
            l_signup.Margin = new Padding(4, 0, 4, 0);
            l_signup.Name = "l_signup";
            l_signup.Size = new Size(93, 23);
            l_signup.TabIndex = 9;
            l_signup.Text = "Sign Up";
            l_signup.Click += label4_Click;
            // 
            // l_login
            // 
            l_login.AutoSize = true;
            l_login.Font = new Font("Verdana", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l_login.ForeColor = Color.FromArgb(2, 96, 129);
            l_login.Location = new Point(442, 59);
            l_login.Margin = new Padding(4, 0, 4, 0);
            l_login.Name = "l_login";
            l_login.Size = new Size(126, 38);
            l_login.TabIndex = 10;
            l_login.Text = "Log in";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(757, 486);
            Controls.Add(l_login);
            Controls.Add(l_signup);
            Controls.Add(l_reset);
            Controls.Add(btnClose);
            Controls.Add(btnlogin);
            Controls.Add(l_pass);
            Controls.Add(txtpass);
            Controls.Add(l_user);
            Controls.Add(panel1);
            Controls.Add(txtuser);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label l_pass;
        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label l_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_signup;
        private System.Windows.Forms.Label l_login;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
