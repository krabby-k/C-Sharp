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
    public partial class TeacherForm : Form
    {
        TeacherClass tutor = new TeacherClass();
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFname.Text== "" || txtLname.Text == "" || txtSpec1.Text == "")
            {
                MessageBox.Show("Fill in all Tutor Details", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string fn = txtFname.Text;
                string ln = txtLname.Text;
                string spec1 = txtSpec1.Text;
                string spec2 = txtSpec2.Text;

                if (tutor.AddTutor(fn,ln,spec1,spec2))
                {
                    displayData();
                    btnClear.PerformClick();
                    MessageBox.Show("New Tutor Added", "Add Tutor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Tutor addition failed", "Add Tutor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //function to display data on the data grid view
        private void displayData()
        {
            dgv_Tutor.DataSource = tutor.getTutorList(new SqlCommand("select * from Tutor"));
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // display tutor data
            displayData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtSpec1.Clear();
            txtSpec2.Clear();
        }
    }
}
