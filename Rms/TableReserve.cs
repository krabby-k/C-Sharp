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
    public partial class TableReserve : Form
    {
        ReservationCls rsvc = new ReservationCls();

        public TableReserve()
        {
            InitializeComponent();
            InitializeTimePicker();
        }
        private DateTimePicker timePicker;
        private void InitializeTimePicker()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:mm tt";
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(480, 415);
            Controls.Add(timePicker);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            string nm, ph, em, op;
            int py;
            DateTime dt, tm;
            nm = txt_name.Text;
            ph = txt_phone.Text;
            em = txt_email.Text;
            op = cmb_Opt.Text;
            py = Convert.ToInt32(cmb_party.SelectedItem);
            dt = dateTimePicker1.Value;
            tm = timePicker.Value;

            if (verify())
            {
                if (rsvc.newReservation(nm, ph, em, dt, op, py, tm))
                {
                    MessageBox.Show("Your Reservation has been created", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //added these two lines to display price
                    int result = py * 20;
                    MessageBox.Show("Reservation prices are $" + result, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in making your reservation", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                clearFields();
            }
            else
            {
                MessageBox.Show("Provide information in all the fields", "Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verify()
        {
            if ((txt_email.Text == "")||(txt_name.Text =="") || (txt_phone.Text==""))
            {
                return false;
            }
            return true;
        }
        private void clearFields()
        {
            txt_phone.Clear();
            txt_name.Clear();
            txt_email.Clear();
            
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            Welcome w = new Welcome();
            this.Hide();
            w.Show();
        }

        private void btn_man_Click(object sender, EventArgs e)
        {
            Update_reserve upd = new Update_reserve();
            this.Hide();
            upd.Show();
        }
    }
}
