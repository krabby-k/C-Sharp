using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NCC_PRO
{
    class SaveData
    {
        // variable 
        string save = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\NCC-PRO\Database.mdf;Integrated Security=True";       
        // method to insert data into db
        public void MyData(string statement)
        {
            SqlConnection cn = new SqlConnection(save);
            cn.Open();
            SqlCommand cmd = new SqlCommand(statement, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
