using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rms
{
    public partial class signup : Form
    {
        Users us = new Users();
        public signup()
        {
            InitializeComponent();
        }

        private void btn_Signup_Click(object sender, EventArgs e)
        {
            
            string fn, ln, em, un, gn, cn, pw, rp;
            fn = txt_fname.Text;
            ln = txt_Lname.Text;
            em = txt_Email.Text;
            un = txt_UserName.Text;
            gn = txtGender.Text;
            cn = txt_contact.Text;
            pw = txt_Pass.Text;
            rp = txt_Cpass.Text;

           
            if (verify())
            {
                if (us.addUsers(fn, ln, em, un, gn, cn, pw, rp))
                {
                    MessageBox.Show("Your accout has been created successfully?", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in creating account", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearFields();
            }
            else
            {
                MessageBox.Show("Missing fields!!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if ((txtGender.Text == "") || (txt_contact.Text == "") || (txt_Cpass.Text == "") || (txt_Email.Text == "") ||
                (txt_fname.Text == "") || (txt_Lname.Text == "") || (txt_Pass.Text == "") || (txt_UserName.Text == ""))
            {
                return false;
            }
            return true;
        }

        private void clearFields()
        {
            txtGender.Clear();
            txt_contact.Clear();
            txt_Cpass.Clear();
            txt_Email.Clear();
            txt_fname.Clear();
            txt_Lname.Clear();
            txt_Pass.Clear();
            txt_UserName.Clear();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            this.Hide();
            main.Show();
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            intro main = new intro();
            this.Hide();
            main.Show();
        }
    }
}
