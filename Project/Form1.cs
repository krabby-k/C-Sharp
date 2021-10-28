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

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.myDataSet.Users);

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //variable declaration
            string fn, ln, em, un, ps, cp;
            fn = txtFname.Text;
            ln = txtLname.Text;
            em = txtLname.Text;
            un = txtUname.Text;
            ps = txtPass.Text;
            cp = txtCpas.Text;

            // connection string statement to link the form to the database.
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

            // we first check whether all the field are filled. if not the last else statement is executed.
            if (fn != string.Empty || ln != string.Empty || em != string.Empty || un != string.Empty || ps != string.Empty || cp != string.Empty)
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
                        MessageBox.Show("Username Aready Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
