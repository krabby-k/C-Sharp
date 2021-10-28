using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class manageStdForm : Form
    {
        StudentCl scl = new StudentCl();
        public manageStdForm()
        {
            InitializeComponent();
        }
        public void show_Table()
        {
            dgv_student.DataSource = scl.getStudentList(new SqlCommand("Select * from Student"));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)dgv_student.Columns[7];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void dgv_student_Click(object sender, EventArgs e)
        {
            txtId.Text = dgv_student.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dgv_student.CurrentRow.Cells[1].Value.ToString();
            txtLName.Text = dgv_student.CurrentRow.Cells[2].Value.ToString();
            dtpD.Value = (DateTime)dgv_student.CurrentRow.Cells[3].Value;
            if (dgv_student.CurrentRow.Cells[4].Value.ToString() == "Male") rbnMale.Checked = true;
            txtPhone.Text = dgv_student.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dgv_student.CurrentRow.Cells[6].Value.ToString();
            txtFees.Text = dgv_student.CurrentRow.Cells[8].Value.ToString();
            byte[] img = (byte[])dgv_student.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pbxProf.Image = Image.FromStream(ms);
        }

        private void manageStdForm_Load(object sender, EventArgs e)
        {
            show_Table();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // check student photo from the computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbxProf.Image = Image.FromFile(opf.FileName);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            dtpD.Value = DateTime.Now;
            rbnMale.Checked = true;
            txtEmail.Clear();
            txtFees.Clear();
            txtFname.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            pbxProf.Image = null;
        }
        bool verify()
        {
            if ((txtFname.Text == "") || (txtLName.Text == "") || (txtFees.Text == "")
                || (txtPhone.Text == "") || (txtEmail.Text == "") || (pbxProf.Image == null))
            {
                return false;
            }
            else
                return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgv_student.DataSource = scl.searchStdDetails(txtSearch.Text);
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)dgv_student.Columns[7];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // update student records.
            int id = Convert.ToInt32(txtId.Text);
            string fn = txtFname.Text;
            string ln = txtLName.Text;
            string em = txtEmail.Text;
            string fs = txtFees.Text;
            string pn = txtPhone.Text;
            DateTime dob = dtpD.Value;
            string gd = rbnMale.Checked ? "Male" : "Female";


            // check student age betweeen 15 and 100
            int byear = dtpD.Value.Year;
            int cur_year = DateTime.Now.Year;
            if ((cur_year - byear) < 10 || (cur_year - byear) > 100)
            {
                MessageBox.Show("The Student's age msut be between 10 and 100", "invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    // get phot  from picture box
                    MemoryStream ms = new MemoryStream();
                    pbxProf.Image.Save(ms, pbxProf.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (scl.updateStudentDetails(id,fn, ln, dob, pn, gd, em, img, fs))
                    {
                        show_Table();
                        MessageBox.Show("Student Details Updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Empty Field", "Update student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if (scl.deleteStudent(id))
                    {
                        show_Table();
                        btnClear.PerformClick();
                        MessageBox.Show("Student Details Deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
    
}