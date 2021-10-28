using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Main
{
    class CourseCls
    {
        DbConnect con = new DbConnect();
        // a method to create a  new course
        public bool setNewCourse(string cn, int hr, string desc)
        {
            SqlCommand cmd = new SqlCommand("insert into Course(CourseName,Hour,Description) values (@cn,@hr,@desc)", con.getConnection);
            //@cn,@hr,@desc
            cmd.Parameters.Add("@cn", SqlDbType.VarChar).Value = cn;
            cmd.Parameters.Add("@hr", SqlDbType.Int).Value = hr;
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
        // create a function to get a list of courses
        public DataTable getCourseList(SqlCommand sqlCommand)
        {
            string stdlist = "Select * from Course";
            SqlCommand cmnd = new SqlCommand(stdlist, con.getConnection);
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
        // create method to update course details
        public bool updateCourseDetails(int id, string cn, int hr, string desc)
        {
            SqlCommand cmd = new SqlCommand("update Course set CourseName=@cn, Hour=@hr,Description=@desc where CourseId=@id ", con.getConnection);
            //id, @cn,@hr,@desc
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@cn", SqlDbType.VarChar).Value = cn;
            cmd.Parameters.Add("@hr", SqlDbType.Int).Value = hr;
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
        // create a method to Delete a course
        public bool deleteCoure(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Course where CourseId=@id", con.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
    }
}
