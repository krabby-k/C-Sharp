using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Main
{
    class DbConnect
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\Main\MyDb.mdf;Integrated Security=True");

        // get connection
        public SqlConnection getConnection
        {
            get
            {
                return cn;
            }
        }
        // Method for Opening a connection
        public void openConnect()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }
        // Method for Closing a connection
        public void closeConnect()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
    }
}
