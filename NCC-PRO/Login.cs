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

namespace NCC_PRO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // initialize connection
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\NCC-PRO\Database.mdf;Integrated Security=True");
            cn.Open();
            //variable declaration
            string u, p;
            u = txtUname.Text;
            p = txtPass.Text;
            // check if username and password is not null
            if (p != "" && u != "")
            {
                // query to select the account where username and password is provided
                SqlCommand cmd = new SqlCommand("select * from Users where Username='" + u + "' and Password='" + p + "'", cn);
                var dr = cmd.ExecuteReader();
                // if present
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    // we check if the account is an admin account.
                    if (u == "Admin")
                    {
                        // provide a limit to number of login attempts
                        int loginAttempts = 0;
                        for (int x = 0; x < 3; x++)
                        {
                            // checking if the password is similar to what is in the database
                            if (p != "Password")
                            {
                                loginAttempts++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        // login attempt more than 2 account is locked.
                        if (loginAttempts > 2)
                        {
                            MessageBox.Show("Account has been Locked!!");
                        }
                        // grant access
                        else
                        {
                            AdminPage admin = new AdminPage();
                            admin.ShowDialog();
                        }
                    }
                    // executed when normal user logs in 
                    else
                    {
                        UserPage use = new UserPage();
                        use.ShowDialog();
                    }
                }
                // executed when incorrect Login Details are provided
                else
                {
                    dr.Close();
                    MessageBox.Show("Username and Password does not exist \nor Wrong Username / password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // must provide username and password to proceed
            else
            {
                MessageBox.Show("Please Enter Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cn.Close();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp sign = new SignUp();
            sign.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
