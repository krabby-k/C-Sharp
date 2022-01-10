using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rms
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            Login main = new Login();
            this.Hide();
            main.Show();
        }

        private void btn_admn_Click(object sender, EventArgs e)
        {
            AdminLog main = new AdminLog();
            this.Hide();
            main.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
