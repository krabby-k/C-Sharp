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
    public partial class Update_reserve : Form
    {
        // creating a new instance of the class reservationCls
        ReservationCls rsvCls = new ReservationCls();
        public Update_reserve()
        {
            InitializeComponent();
            InitializeTimePicker(); 
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

        // populate the reseravtion details on the text boxes and datetimepickers upon clicking on a particular column
        private void dgv_rsv_Click(object sender, EventArgs e)
        {
            txt_Id.Text = dgv_rsv.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dgv_rsv.CurrentRow.Cells[1].Value.ToString();
            txt_phone.Text = dgv_rsv.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_rsv.CurrentRow.Cells[3].Value.ToString();
            cmb_Opt.SelectedItem = dgv_rsv.CurrentRow.Cells[5].Value.ToString();
            cmb_party.SelectedItem = dgv_rsv.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Value = (DateTime)dgv_rsv.CurrentRow.Cells[4].Value;
            //timePicker.Value = (DateTime)dgv_rsv.CurrentRow.Cells[7].Value;

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
            dgv_rsv.DataSource = rsvCls.listAll(new SqlCommand ("select * from Reservations"));
        }


        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            
            string n = txt_name.Text;
            string ph = txt_phone.Text;
            string em = txt_email.Text;
            string ch = cmb_Opt.Text;
            int py = Convert.ToInt32(cmb_party.SelectedItem);
            DateTime dt = dateTimePicker1.Value;
            DateTime tm = timePicker.Value;

            if (verify())
            {
                int id = Int32.Parse(txt_Id.Text);
                try
                {
                    if (rsvCls.updateReservations(id, n, ph, em, dt, ch, py, tm))
                    {
                        showTable();
                        MessageBox.Show("Reservation Details Updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        int result = py * 20;
                        MessageBox.Show("Reservation prices are $"+ result, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                catch(Exception ex)
                {
                    {
                        MessageBox.Show(ex.Message, "Cancel Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private TextBox tb1;
        private void initializetb()
        {
            TextBox tb1 = new TextBox();
            tb1.Location = new Point(47, 260);
            tb1.Size = new Size(907, 65);
            tb1.Multiline = true;
            tb1.BackColor = Color.Cyan;
            this.Controls.Add(tb1);
        }
        
        private void btn_chk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please leave a Review on the textbox that appears" +
                " Then click on the finish button", "Review", MessageBoxButtons.OK);
            
            initializetb();
        }
      

        private void btn_fin_Click(object sender, EventArgs e)
        {
            //string t = tb1.Text;
            //rsvCls.addReview(t);
            //MessageBox.Show("Review added Successfully", "Review", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            Welcome main = new Welcome();
            this.Hide();
            main.Show();
        }
    }
}
