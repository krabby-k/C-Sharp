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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void normal_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.normal_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet._Normal_Users' table. You can move, or remove it, as needed.
            this.normal_UsersTableAdapter.Fill(this.myDataSet._Normal_Users);

            txtConfirmPass.PasswordChar = '*';
            txtPassword.PasswordChar = '*';
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //variable declaration
            string fn, ln, em, un, ps, cp;
            fn = txtFname.Text;
            ln = txtLname.Text;
            em = txtLname.Text;
            un = txtUsername.Text;
            ps = txtPassword.Text;
            cp = txtConfirmPass.Text;

            // connection string statement to link the form to the database.
            SqlConnection cnn = new SqlConnection("Data Source=KANSA;Initial Catalog=CsharpDb;Integrated Security=True");

            // we first check whether all the field are filled. if not the last else statement is executed.
            if (fn !=string.Empty || ln != string.Empty || em != string.Empty || un != string.Empty || ps != string.Empty  || cp != string.Empty)
            {
                // we then check whether the password entered is similar to the what is entered in the confirm password.
                // If not then Error is returned. password miss-match
                if (ps == cp)
                {
                    // We then check if the username already exists in the system.
                    SqlCommand cmd = new SqlCommand("select * from Normal-Users where Username='" + un + "'", cnn);
                    var dr = cmd.ExecuteReader();
                    // if so an error is returned.
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Aready Exists","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // if not the details of the user are entered into the system.
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into Normal-Users values (@FirstName,@LastName,@Email,@Username,@Password,@ConfirmPassword", cnn);
                        cmd.Parameters.AddWithValue("FirstName", fn);
                        cmd.Parameters.AddWithValue("LastName", ln);
                        cmd.Parameters.AddWithValue("Email", em);
                        cmd.Parameters.AddWithValue("Username", un);
                        cmd.Parameters.AddWithValue("Password", ps);
                        cmd.Parameters.AddWithValue("ConfirmPassword", cp);
                        MessageBox.Show("Account created Successfully. You can now Login to your account", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Fill in all the required entries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
