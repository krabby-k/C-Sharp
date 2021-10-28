using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class LoginForm : Form
    {
        StudentCl student = new StudentCl();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtUname.Text == "")
            {
                MessageBox.Show("Enter Username and Password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string un = txtUname.Text;
                string pw = txtPass.Text;
                DataTable table = student.getStudentList(new SqlCommand("select * from Users where Username='" + un + "' and Password='" + pw + "'"));
                if (table.Rows.Count > 0)
                {
                    Dashboard main = new Dashboard();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
