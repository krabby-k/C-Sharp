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
    public partial class AdminLog : Form
    {
        Users cs = new Users();
        public AdminLog()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "" || txt_user.Text == "")
            {
                MessageBox.Show("Enter Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string un = txt_user.Text;
                string pw = txt_pass.Text;
                DataTable tb = cs.getUser(new SqlCommand("select * from AdminUser where Username='" + un + "' and Password='" + pw + "'"));
                if (tb.Rows.Count > 0)
                {
                    welcomeAdmin main = new welcomeAdmin();
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

        private void btn_canc_Click(object sender, EventArgs e)
        {
            intro main = new intro();
            this.Hide();
            main.Show();
        }
    }
}
