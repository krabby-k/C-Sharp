using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Rms
{
    class Dbconnect
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\Rms\Db.mdf;Integrated Security=True");

        // get connection
        public SqlConnection GetConnection
        {
            get
            {
                return cn;
            }
        }

        //open connection
        public void openConnection()
        {
            if (cn.State == ConnectionState.Closed)
                cn.Open();
        }

        //close connection

        public void closeConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
    }
}
