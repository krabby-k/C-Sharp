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
    public partial class Dashboard : Form
    {
        StudentCl student = new StudentCl();
        CourseCls course = new CourseCls();
        public Dashboard()
        {
            InitializeComponent();
            custDesign();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lbl_Total.Text = "Total Students : " + student.allStudents();
            lbl_Male.Text = "Male : " + student.maleStudent();
            lbl_Female.Text = "Female : " + student.femaleStudent();
            cmb_Course.DataSource = course.getCourseList(new SqlCommand("select * from Course"));
            cmb_Course.DisplayMember = "CourseName";
            cmb_Course.ValueMember = "";
        }
        private void custDesign()
        {
            pnlTeacher.Visible = false;
            pnl_Course.Visible = false;
            pnl_Score.Visible = false;
            pnl_Stud.Visible = false;
        }
        // a function to hide the submenus
        private void hidePanelMenu()
        {
            if (pnlTeacher.Visible == true)
                pnlTeacher.Visible = false;
            if (pnl_Course.Visible == true)
                pnl_Course.Visible = false;
            if (pnl_Score.Visible == true)
                pnl_Score.Visible = false;
            if (pnl_Stud.Visible == true)
                pnl_Stud.Visible = false;
        }
        // a function to show the submenus
        private void showPanelMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                hidePanelMenu();
                menu.Visible = true;
            }
            else
                menu.Visible = false;
        }

        private void btn_Stud_Click(object sender, EventArgs e)
        {
            showPanelMenu(pnl_Stud);
        }
        #region stdSubMenu
        private void btn_reg_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationForm());
            //..
            // code
            //...
           

            hidePanelMenu();
        }

        private void btn_admStud_Click(object sender, EventArgs e)
        {
            openChildForm(new manageStdForm());
            //..
            // code
            //...
            hidePanelMenu();
        }

        private void btn_PrntStud_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudent());
            //..
            // code
            //...
            hidePanelMenu();
        }
        #endregion stdSubMenu
        private void btn_Course_Click(object sender, EventArgs e)
        {
            showPanelMenu(pnl_Course);
        }
        #region CourSubMenu
        private void btn_Ncourse_Click(object sender, EventArgs e)
        {
            openChildForm(new courseForm());
            //..
            // code
            //...
            hidePanelMenu();
        }

        private void btn_AdmCour_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            //..
            // code
            //...
            hidePanelMenu();
        }

        #endregion CourseSubMenu
        private void btn_Score_Click(object sender, EventArgs e)
        {
            showPanelMenu(pnl_Score);
        }
        #region ScoreSubMenu
        private void btn_Nscore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            //..
            // code
            //...
            hidePanelMenu();
        }

       
        #endregion ScoreSubMenu
        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            showPanelMenu(pnlTeacher);
        }
        #region TrSubMenu

        private void btn_NTeach_Click(object sender, EventArgs e)
        {
            openChildForm(new TeacherForm());
            //..
            // code
            //...
            hidePanelMenu();
        }
        #endregion TrSubMenu

        // to get 
        private Form active = null;
        private void openChildForm(Form childForm)
        {
            if (active != null) active.Close();
            active = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel5.Controls.Add(childForm);
            panel5.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (active != null)
                active.Close();
            panel5.Controls.Add(panel_cover);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
