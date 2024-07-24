namespace inventory_managment_system
{
    public partial class Signup : Form
    {
        FileStream filestream;
        StreamReader sr;
        StreamWriter sw;
        public Signup()
        {
            InitializeComponent();
        }
        private void signup_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            filestream = new FileStream("users.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            sw = new StreamWriter(filestream);
            sr = new StreamReader(filestream);
            string record;
            string[] field;
            bool usercheck = true;
            while ((record = sr.ReadLine()) != null)
            {
                field = record.Split(',');
                if (field[2] == txtusername.Text)
                {
                    usercheck = false;
                    break;
                }
            }

            if (txtfname.Text != "" && txtlname.Text != "" && txtemail.Text != "" && txtpassword.Text != "" && txtcpassword.Text != "" && txtusername.Text != "")
            {
                if (usercheck)
                {

                    if (txtpassword.Text == txtcpassword.Text)
                    {
                        txtcpassword.BackColor = Color.White;
                        sw.WriteLine($"{txtfname.Text},{txtlname.Text},{txtusername.Text},{txtemail.Text},{txtpassword.Text}");
                        sw.Close();
                        filestream.Close();
                        products products = new products();
                        products.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("please confirm Right pass");
                        txtcpassword.BackColor = Color.Red;
                        sw.Flush();
                        filestream.Flush();
                    }
                }
                else
                {
                    txtusername.BackColor = Color.Red;
                    MessageBox.Show("this username already exist");
                }


            }
            else
            {
                if (txtfname.Text == "")
                {
                    txtfname.BackColor = Color.Red;
                }
                else
                {
                    txtfname.BackColor = Color.White;
                }
                if (txtlname.Text == "")
                {
                    txtlname.BackColor = Color.Red;
                }
                else
                {
                    txtlname.BackColor = Color.White;
                }
                if (txtusername.Text == "")
                {
                    txtusername.BackColor = Color.Red;
                }
                else
                {
                    txtusername.BackColor = Color.White;
                }
                if (txtemail.Text == "")
                {
                    txtemail.BackColor = Color.Red;
                }
                else
                {
                    txtemail.BackColor = Color.White;
                }
                if (txtpassword.Text == "")
                {
                    txtpassword.BackColor = Color.Red;
                }
                else
                {
                    txtpassword.BackColor = Color.White;
                }
                if (txtcpassword.Text == "")
                {
                    txtcpassword.BackColor = Color.Red;
                }
                else
                {
                    txtcpassword.BackColor = Color.White;
                }
                sw.Flush();
                filestream.Flush();
                MessageBox.Show("please enter all information", "error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            sr.Close();
            filestream.Close();


        }

        private void txtfname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlname.Focus();
            }
        }

        private void txtlname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtusername.Focus();
            }
        }

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcpassword.Focus();
            }
        }

        private void txtcpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsignup_Click(sender, e);
            }
        }
    }
}
