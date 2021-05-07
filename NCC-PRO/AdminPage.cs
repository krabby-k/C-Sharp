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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnCsurv_Click(object sender, EventArgs e)
        {
            this.Hide();
            //open Survey creation page.
            surveycreationpage create = new surveycreationpage();
            create.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit the Application.
            Application.Exit();
        }

        private void btnVsurv_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Open the survey Preview page.
            Admin_Available_Surveys_Preview avail = new Admin_Available_Surveys_Preview();
            avail.ShowDialog();
        }

        private void btnReslt_Click(object sender, EventArgs e)
        {
            this.Hide();
            // loading the results view page
            ResultsView r = new ResultsView();
            r.ShowDialog();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }
    }
}
