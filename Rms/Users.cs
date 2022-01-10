using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Rms
{
    class Users
    {
        Dbconnect cn = new Dbconnect();

        // a method to add new users 
        public bool addUsers(string fname, string lname, string email, string uname, string gender, string contact, string pass, string rpass)
        {
            string start = "insert into Customers (FirstName,LastName,Email,Username,Gender,contact,Password,RepeatPassword) values (@fn,@ln,@em,@un,@gn,@ct,@ps,@rp)";
            SqlCommand cmd = new SqlCommand(start, cn.GetConnection);

            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@un", SqlDbType.VarChar).Value = uname;
            cmd.Parameters.Add("@gn", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@ct", SqlDbType.VarChar).Value = contact;
            cmd.Parameters.Add("@ps", SqlDbType.VarChar).Value = pass;
            cmd.Parameters.Add("@rp", SqlDbType.VarChar).Value = rpass;

            cn.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.closeConnection();
                return true;
            }
            else
            {
                cn.closeConnection();
                return false;
            }

        }

        public DataTable getUser(SqlCommand comd)
        {
            comd.Connection = cn.GetConnection;
            SqlDataAdapter apt = new SqlDataAdapter(comd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
        public bool userExists(string uname)
        {
            string query = "select * from Customers where Username = @un";
            SqlCommand cmd = new SqlCommand(query, cn.GetConnection);

            cmd.Parameters.AddWithValue("@un", uname);
            cn.openConnection();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        
    }
}
