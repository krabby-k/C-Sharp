using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCC_PRO
{
    public partial class surveycreationpage : Form
    {
        // creating a new intance of the class Savedata
        SaveData sd = new SaveData();
        public surveycreationpage()
        {
            InitializeComponent();
        }

        private void surveycreationpage_Load(object sender, EventArgs e)
        {

        }

        private void surveycreationpage_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // varible creation and instatiation
            string t, q1, q2, q3, q4, q5, q6;
            t = txtTittle.Text;
            q1 = txtQ1.Text;
            q2 = txtQ2.Text;
            q3 = txtQ3.Text;
            q4 = txtQ4.Text;
            q5 = txtQ5.Text;
            q6 = txtQ6.Text;
            // calling the method myData 
            sd.MyData("insert into Survey(SurveyTittle,Q1,Q2,Q3,Q4,Q5,Q6) " +
                "values('" + t + "','" + q1 + "','" + q2 + "','" + q3 + "','" + q4 + "','" + q5 + "','" + q6 + "')");
            
            this.Close();
        }
    }
}
