using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sys
{
    public partial class Form1 : Form
    {
        List<Users> member;
        signUp sign = new signUp();
        public Form1()
        {
            InitializeComponent();
        }
        private Users findAccount(string user)
        {
            for (int x = 0; x < member.Count; x++)
            {
                if (member[x].Username.ToLower() == user.ToLower())
                {
                    return member[x];
                }
            }
            return null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users ilog;
            string uname = txtUsername.Text;
            string pass = txtPassword.Text;
            ilog = findAccount(uname);
            if (ilog == null)
            {
                MessageBox.Show("Account doesn't seem to exist!");
                return;
            }
            if (ilog.checkPassword(pass))
            {
                MessageBox.Show("Access Granted");
            }
            else
            {
                MessageBox.Show("Access Denied!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUp x = new signUp();
            x.ShowDialog();
        }
    }
}
