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
    public partial class ManageBookings : Form
    {
        ReservationCls rsvCls = new ReservationCls();
        public ManageBookings()
        {
            InitializeComponent();
            InitializeTimePicker();
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {

        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            // verifies that the search textbox is not empty 
            if (txt_search.Text.Equals(""))
            {
                MessageBox.Show("Provide a name", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //if not checks the database for the information based on the name
            else
            {
                dgv_rsv.DataSource = rsvCls.getReservationList(txt_search.Text);
            }
        }



        // initilize our time picker to dislay datetime in a format of our chosing
        // we can then call the method upon loading of the page
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

        //verify that the textboxes have details provided in them
        bool verify()
        {
            if ((txt_email.Text == "") || (txt_name.Text == "") || (txt_phone.Text == "") || (txt_Id.Text == ""))
            {
                return false;
            }
            return true;
        }

        // calls the method to display the reservation details onto the datagridview
        public void showTable()
        {
            dgv_rsv.DataSource = rsvCls.listAll(new SqlCommand("select * from Reservations"));
        }

        private void btn_canc_Click_1(object sender, EventArgs e)
        {
            welcomeAdmin w = new welcomeAdmin();
            this.Close();
            w.Show();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_Id.Text.Equals(""))
            {
                MessageBox.Show("Provide Reservation Id", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(txt_Id.Text);
                    if (rsvCls.cancelReservation(id))
                    {
                        btn_del.PerformClick();
                        MessageBox.Show("Reservation details Canceled successfully", "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_Id.Text);
            string n = txt_name.Text;
            string ph = txt_phone.Text;
            string em = txt_email.Text;
            string ch = cmb_Opt.Text;
            int py = Convert.ToInt32(cmb_party.SelectedItem);
            DateTime dt = dateTimePicker1.Value;
            DateTime tm = timePicker.Value;

            if (verify())
            {
                try
                {
                    if (rsvCls.updateReservations(id, n, ph, em, dt, ch, py, tm))
                    {
                        showTable();
                        MessageBox.Show("Reservation Details Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int result = py * 20;
                        MessageBox.Show("Reservation prices are $" + result, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Fill in all the fields", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_rsv_Click(object sender, EventArgs e)
        {
            txt_Id.Text = dgv_rsv.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dgv_rsv.CurrentRow.Cells[1].Value.ToString();
            txt_phone.Text = dgv_rsv.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_rsv.CurrentRow.Cells[3].Value.ToString();
            cmb_Opt.SelectedItem = dgv_rsv.CurrentRow.Cells[5].Value.ToString();
            cmb_party.SelectedItem = dgv_rsv.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Value = (DateTime)dgv_rsv.CurrentRow.Cells[4].Value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            TableReserve tr = new TableReserve();
            this.Hide();
            tr.Show();
        }
    }
}
