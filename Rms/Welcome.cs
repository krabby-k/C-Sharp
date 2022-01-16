using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Rms
{
    public partial class Welcome : Form
    {
        ReservationCls rsvCls = new ReservationCls();
        public Welcome()
        {
            InitializeComponent();
            showTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableReserve main = new TableReserve();
            this.Hide();
            main.Show();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            TableReserve main = new TableReserve();
            this.Hide();
            main.Show();
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            intro main = new intro();
            this.Hide();
            main.Show();
        }
        public void showTable()
        {
            dgv_rsv.DataSource = rsvCls.listAll(new SqlCommand("select review from Review"));
        }

    }
}
