using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cp1
{
    class Student
    {
        public static SqlConnection con = null;
        public void myconnect()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brian\source\repos\krabby-k\C-sharp\Cp1\Db.mdf;Integrated Security=True");
            con.Open();
        }
    }
}
