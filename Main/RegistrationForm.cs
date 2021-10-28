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
    public partial class RegistrationForm : Form
    {
        StudentCl scl = new StudentCl();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // check student photo from the computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "select Photo(*.jpg;*.png;*gif)|*.jpg;*.png;*gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbxProf.Image = Image.FromFile(opf.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // add a new student 
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
                    if (scl.addStudent(fn, ln, dob,  pn, gd, em, img, fs))
                    {
                        show_Table();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Empty Field", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // method to confirm all fields have an input
        bool verify()
        {
            if ((txtFname.Text == "") || (txtLName.Text == "")||(txtFees.Text == "")
                || (txtPhone.Text == "") || (txtEmail.Text == "") || (pbxProf.Image == null))
            {
                return false;
            }
            else
                return true;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpD.Value = DateTime.Now;
            rbnMale.Checked = true;
            txtEmail.Clear();
            txtFees.Clear();
            txtFname.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            pbxProf.Image = null;
        }
        public void show_Table()
        {
            dgv_student.DataSource = scl.getStudentList(new SqlCommand("Select * from Student"));
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn = (DataGridViewImageColumn)dgv_student.Columns[7];
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            show_Table();
        }

        private void pbxProf_Click(object sender, EventArgs e)
        {

        }
    }
}
