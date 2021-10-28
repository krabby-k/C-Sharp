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
    public partial class ManageCourseForm : Form
    {
        CourseCls course = new CourseCls();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            displayData();
        }
        // display course data 
        private void displayData()
        {
            dgv_Course.DataSource = course.getCourseList(new SqlCommand("select * from Course"));
        }
        // clearing the text boxex
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCoursename.Clear();
            txtDesc.Clear();
            txtTime.Clear();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCoursename.Text == "" || txtDesc.Text == "" || txtTime.Text == ""||txtId.Text.Equals(""))
            {
                MessageBox.Show("Fill in all Course Details", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                string cn = txtCoursename.Text;
                int hr = Convert.ToInt32(txtTime.Text);
                string desc = txtDesc.Text;

                if (course.updateCourseDetails(id, cn, hr, desc))
                {
                    displayData();
                    btnClear.PerformClick();
                    MessageBox.Show("Course Details Updated successfully", "Manage Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Course Details update failed", "Manage Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Need Course Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    if (course.deleteCoure(id))
                    {
                        displayData();
                        btnClear.PerformClick();
                        MessageBox.Show("Course Details Deleted successfully", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch(Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void dgv_Course_Click(object sender, EventArgs e)
        {
            txtId.Text = dgv_Course.CurrentRow.Cells[0].Value.ToString();
            txtCoursename.Text = dgv_Course.CurrentRow.Cells[1].Value.ToString();
            txtTime.Text = dgv_Course.CurrentRow.Cells[2].Value.ToString();
            txtDesc.Text = dgv_Course.CurrentRow.Cells[3].Value.ToString();
        }
        
        // to search course and display it on the data grid view
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv_Course.DataSource = course.getCourseList(new SqlCommand("select * from Course where concat (CourseName,Hour) like '%"+txtSearch.Text+"%'"));
        }
    }
}
