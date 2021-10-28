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
    public partial class courseForm : Form
    {
        CourseCls course = new CourseCls();
        public courseForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCoursename.Text == "" || txtDesc.Text == "" || txtTime.Text == "")
            {
                MessageBox.Show("Fill in all Course Details", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cn = txtCoursename.Text;
                int hr = Convert.ToInt32(txtTime.Text);
                string desc = txtDesc.Text;

                if (course.setNewCourse(cn, hr, desc))
                {
                    displayData();
                    btnClear.PerformClick();
                    MessageBox.Show("New Course Created", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Course not Created", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCoursename.Clear();
            txtDesc.Clear();
            txtTime.Clear();

        }
        // method to display data 
        private void displayData()
        {
            dgv_Course.DataSource = course.getCourseList(new SqlCommand("select * from Course"));
        }

        private void courseForm_Load(object sender, EventArgs e)
        {
            // display course list in data grid view
            displayData();
        }

    }
}
