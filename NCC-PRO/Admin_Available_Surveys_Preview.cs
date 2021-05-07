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
    public partial class Admin_Available_Surveys_Preview : Form
    {
        //instantiation of the class ReadingData.
        ReadingData my = new ReadingData();
        public Admin_Available_Surveys_Preview()
        {
            InitializeComponent();
            fill_listbox();
        }

        private void Admin_Available_Surveys_Preview_Load(object sender, EventArgs e)
        {

        }
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
            // returning to Admin Home Page
            AdminPage ad = new AdminPage();
            ad.ShowDialog();
        }
    }
}
