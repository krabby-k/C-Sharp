using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class ScoreClass
    {
        DbConnect con = new DbConnect();
        // a method to add scores
        public bool setScore(int sid, string cn, float sc, string desc)
        {
            SqlCommand cmd = new SqlCommand("insert into Scores(StudentId,CourseName,Score,Description) values (@sid,@cn,@sc,@desc)", con.getConnection);
            //@sid,@cn,@sc,@desc
            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = sid;
            cmd.Parameters.Add("@cn", SqlDbType.VarChar).Value = cn;
            cmd.Parameters.Add("@sc", SqlDbType.Int).Value = sc;
            cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc;
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
        public DataTable getStudentList(SqlCommand cmnd)
        {
            cmnd.Connection = con.getConnection;
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
        
    }
}
