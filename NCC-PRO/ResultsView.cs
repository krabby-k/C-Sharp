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
using System.IO;

namespace NCC_PRO
{
    public partial class ResultsView : Form
    {

        public ResultsView()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //connection string variable
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\NCC-PRO\Database.mdf;Integrated Security=True";
            // creating a new connection
            SqlConnection cn = new SqlConnection(str);
            // creating an sql query statement
            SqlCommand cmd = new SqlCommand("select * from Results ;", cn);
            // retrieving data from data source.
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            // instatiation of a new datatable.
            DataTable dt = new DataTable();
            // retrival of rows from the table
            sda.Fill(dt);
            // instantiation of a datasource
            BindingSource bs = new BindingSource();
            // fetching rows in order to display them as a datatable
            bs.DataSource = dt;
            // preview the data onour gridview
            dgView1.DataSource = bs;
            // update the records
            sda.Update(dt);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage ad = new AdminPage();
            ad.ShowDialog();
        }

        private void btnExpt_Click(object sender, EventArgs e)
        {
            if (dgView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xel = new Microsoft.Office.Interop.Excel.Application();
                xel.Application.Workbooks.Add(Type.Missing);
                for (int x = 1; x < dgView1.Columns.Count +1; x++)
                {
                    xel.Cells[1, x] = dgView1.Columns[x - 1].HeaderText;
                }
                for (int x = 0; x<dgView1.Rows.Count; x++)
                {
                    for (int y = 0; y<dgView1.Columns.Count; y++)
                    {
                        xel.Cells[x + 2, y + 1] = dgView1.Rows[x].Cells[y].Value;
                    }
                }
                xel.Columns.AutoFit();
                xel.Visible = true;
            }
            Application.Exit();
        }

        private void ResultsView_Load(object sender, EventArgs e)
        {

        }
    }
}
