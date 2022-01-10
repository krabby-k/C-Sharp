using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rms
{
    public partial class Login : Form
    {
        Users cs = new Users();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text =="" || txt_user.Text == "")
            {
                MessageBox.Show("Enter Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string un = txt_user.Text;
                string pw = txt_pass.Text;
                DataTable tb = cs.getUser(new SqlCommand("select * from Customers where Username='" + un + "' and Password='" + pw + "'"));
                if (tb.Rows.Count > 0)
                {
                    Welcome main = new Welcome();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txt_pass.Clear();
            txt_user.Clear();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            signup main = new signup();
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
