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
    public partial class SignUp : Form
    {
        // instatiation of the class SaveData
        SaveData sd = new SaveData();
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // initialize a connection to the database
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\NCC-PRO\Database.mdf;Integrated Security=True");
            cn.Open();
            // variabke declaration
            string fn, ln, em, un, ps, cp;
            fn = txtFname.Text;
            ln = txtLname.Text;
            em = txtEmail.Text;
            un = txtUname.Text;
            ps = txtPas.Text;
            cp = txtCpas.Text;

            // ensuring that all the check boxes are filled
            if (fn != "" && ln != "" && em != "" && un != "" && ps != "" && cp != "")
            {
                // confirm that password is same as confirm password
                if (ps == cp)
                {
                    SqlCommand cmd = new SqlCommand("select * from Users where Username='" + un + "'", cn);
                    var dr = cmd.ExecuteReader();
                    // verification that the usernaem is not in the database
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("UserName Already exits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // addition of a new user into the database
                    else
                    {
                        dr.Close();
                        sd.MyData("insert into Users (FirstName, LastName, Email, Username, Password, ConfirmPassword)" +
                            "values('" + fn + "','" + ln + "','" + em + "','" + un + "','" + ps + "','" + cp + "')");
                        
                        MessageBox.Show("Account created Successfully, You can now Login.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // both passwords must match
                else
                {
                    MessageBox.Show("Password Mismatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // all events must be filled
            else
            {
                MessageBox.Show("Fill in all the required details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // closing connection
            cn.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            // instatiation of the new login form
            Login log = new Login();
            log.ShowDialog();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPas.PasswordChar = '*';
            txtCpas.PasswordChar = '*';
        }
    }
}
