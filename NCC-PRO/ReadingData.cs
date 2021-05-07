using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NCC_PRO
{
    class ReadingData
    {
        // variable save for storing the conection string
        string save = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\NCC-PRO\Database.mdf;Integrated Security=True";
        SqlConnection cn;
        // method for starting a connection
        public void CreateConnection()
        {
            cn = new SqlConnection(save);
            cn.Open();
        }
        //method for closing connection
        public void CloseConnection()
        {
            cn.Close();
        }
        //method to execute datareader
        public SqlDataReader Reader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
