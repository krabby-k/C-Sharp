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
    public partial class ScoreForm : Form
    {
        CourseCls course = new CourseCls();
        StudentCl student = new StudentCl();
        ScoreClass score = new ScoreClass();

        
        public ScoreForm()
        {
            InitializeComponent();
        }

        // create a functin to display data on the score data grid view
        private void displayScore()
        {
            dgv_Score.DataSource = score.getStudentList(new SqlCommand("select * from Scores"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //Populate cmb_courses with names
            cmb_Course.DataSource = course.getCourseList(new SqlCommand("select * from Course"));
            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.ValueMember = "";
            // to display score details on score data grid 
            displayScore();
            // to display student list 
            dgv_StudList.DataSource = student.getStudentList(new SqlCommand("select StdId, StdFirstName, StdLastName from Student"));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStudId.Text == "" || txtscore.Text == "")
            {
                MessageBox.Show("Fill in all Score Details", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cn = cmb_Course.Text; 
                int stdId = Convert.ToInt32(txtStudId.Text);
                int scr = Convert.ToInt32(txtscore.Text);
                string desc = txtDesc.Text;

                if (score.setScore(stdId,cn,scr, desc))
                {
                    displayScore();
                    btnClear.PerformClick();
                    MessageBox.Show("New Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Score not Added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudId.Clear();
            txtscore.Clear();
            txtDesc.Clear();
            cmb_Course.SelectedIndex = 0;
        }

        private void dgv_StudList_Click(object sender, EventArgs e)
        {
            txtStudId.Text = dgv_StudList.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
