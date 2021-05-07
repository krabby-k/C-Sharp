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
    public partial class Surveys : Form
    {
        //instantiation of the class ReadingData.
        ReadingData my = new ReadingData();
        public Surveys()
        {
            InitializeComponent();
            fill_listbox();
        }

        // global variable declaration;
        string que1, que2, que3, que4, que5, que6;

        void fill_listbox()
        {
            // calling the method to establish a connection.
            my.CreateConnection();
            // variable declared ot store the retriev query.
            string query = "select * from Survey  ;";
            
            // calling the method that will read the title of the survey from the database.
            SqlDataReader dr = my.Reader(query);
            // am using a try catch block to check for errors during execution.
            // the catch  block will execute the defined message if error is found in the try block
            try
            {
                // the while loop displays the tittle so long as there is a tittle in the database.
                // and displays it on the label.
                while (dr.Read())
                {
                    string tittle = dr["SurveyTittle"] as string;
                    lbxAvail.Items.Add(tittle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // call a method to close the connection.
            my.CloseConnection();
        }

        private void rbnYQ2_CheckedChanged(object sender, EventArgs e)
        {
            que2 = "Yes";
        }

        private void rbnNQ2_CheckedChanged(object sender, EventArgs e)
        {
            que2 = "No";
        }

        private void rbnYQ4_CheckedChanged(object sender, EventArgs e)
        {
            que4 = "Yes";
        }

        private void rbnNQ4_CheckedChanged(object sender, EventArgs e)
        {
            que4 = "No";
        }

        private void rbnYQ5_CheckedChanged(object sender, EventArgs e)
        {
            que5 = "Yes";
        }

        private void rbnQN5_CheckedChanged(object sender, EventArgs e)
        {
            que5 = "No";
        }

        private void rbnVunl_CheckedChanged(object sender, EventArgs e)
        {
            que6 = "Very Unlikely";
        }

        private void rbnUnl_CheckedChanged(object sender, EventArgs e)
        {
            que6 = "Unlikely";
        }

        private void rbnNeu_CheckedChanged(object sender, EventArgs e)
        {
            que6 = "Neutral";
        }

        private void rbnLik_CheckedChanged(object sender, EventArgs e)
        {
            que6 = "Likely";
        }

        private void rbnVlik_CheckedChanged(object sender, EventArgs e)
        {
            que6 = "Very Likely";
        }

        private void cmbQ1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Surveys_Load(object sender, EventArgs e)
        {

        }

        private void lbxAvail_SelectedIndexChanged(object sender, EventArgs e)
        {
            // calling the method to establish a connection.
            my.CreateConnection();
            // variable declared to store the retrive query.
            string query = "select * from Survey where SurveyTittle ='" + lbxAvail.Text + "' ;";

            // calling the method that will read the title of the survey from the database.
            SqlDataReader read = my.Reader(query);
            // using a try catch block to check for errors during execution.
            // the catch  block will execute the defined message if error is found in the try block
            try
            {
                // the while loop displays the details if they are present in the db.
                while (read.Read())
                {
                    string tittle = read["SurveyTittle"] as string;
                    string q1 = read["Q1"] as string;
                    string q2 = read["Q2"] as string;
                    string q3 = read["Q3"] as string;
                    string q4 = read["Q4"] as string;
                    string q5 = read["Q5"] as string;
                    string q6 = read["Q6"] as string;

                    lblQ1.Text = q1;
                    lblQ2.Text = q2;
                    lblQ3.Text = q3;
                    lblQ4.Text = q4;
                    lblQ5.Text = q5;
                    lblQ6.Text = q6;
                    lblTittle.Text = tittle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // close connection method is called.
            my.CloseConnection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //sets the value of the selected items in the combo box to respective variables.
            que1 = cmbQ1.SelectedItem.ToString();
            que3 = cmbQ3.SelectedItem.ToString();
            string tittle = lblTittle.Text;
            //calling the method Createconnection
            my.CreateConnection();
            //variable to store the query statement
            string query = "insert into Results (Q1,Q2,Q3,Q4,Q5,Q6,Tittle) values" +
                "('" + que1 + "','" + que2 + "','" + que3 + "','" + que4 + "','" + que5 + "','" + que6 + "','"+ tittle+"')";
            // calling the method Reader
            SqlDataReader sdr = my.Reader(query);
            MessageBox.Show("Thank you for your feedback. We value the infromation you provided");
            try
            {
                while (sdr.Read())
                {

                }
            }
            catch (Exception ula)
            {
                MessageBox.Show(ula.Message);
            }
            // calling the close connection method.
            my.CloseConnection();
            MessageBox.Show("Return to home Page.", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            //open the user page
            UserPage use = new UserPage();
            use.ShowDialog();
        }
    }
}
