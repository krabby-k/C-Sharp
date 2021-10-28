using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class TeacherClass
    {
        DbConnect con = new DbConnect();
        // a method to add new Teacher to the system
        public bool AddTutor(string fn, string ln , string spec1, string spec2)
        {
            SqlCommand cmd = new SqlCommand("insert into Tutor(TFirstName,TLastName,Speciality1,Speciality2) values (@fn,@ln,@spec1,@spec2)", con.getConnection);
            //@fn,@ln,@spec1,@spec2
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fn;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = ln;
            cmd.Parameters.Add("@spec1", SqlDbType.VarChar).Value = spec1;
            cmd.Parameters.Add("@spec2", SqlDbType.VarChar).Value = spec2;
            con.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                con.closeConnect();
                return true;
            }
            else
            {
                con.closeConnect();
                return false;
            }
        }
        // get table
        public DataTable getTutorList(SqlCommand cmnd)
        {
            cmnd.Connection = con.getConnection;
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
    }
}
