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
    public partial class welcomeAdmin : Form
    {
        public welcomeAdmin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            intro main = new intro();
            this.Hide();
            main.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TableReserve main = new TableReserve();
            this.Hide();
            main.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ManageBookings main = new ManageBookings();
            this.Hide();
            main.Show();
        }
    }
}
