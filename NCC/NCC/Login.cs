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

namespace NCC
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet._Normal_Users' table. You can move, or remove it, as needed.
            this.normal_UsersTableAdapter.Fill(this.myDataSet._Normal_Users);
            txtPass.PasswordChar = '*';
        }

        private void normal_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.normal_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // variable declaration
            string u, p;
            u = txtUser.Text;
            p = txtPass.Text;

            // databse connection to the form
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source
\repos\krabby-k\C-sharp\NCC\NCC\Database.mdf;Integrated Security=True");

            if (p != "" || u !="")
            {
                SqlCommand cmd = new SqlCommand("select * from Normal-Users where Username='" + u + "' and Password='" + p + "'", cnn);
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    if (u =="Admin" && p == "Password")
                    {
                        AdminPage pg = new AdminPage();
                        pg.ShowDialog();
                    }
                }
            }
            
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp sign= new frmSignUp();
            sign.ShowDialog();
        }
    }
}
