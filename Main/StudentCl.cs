using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Main
{
    class StudentCl
    {
        DbConnect cn = new DbConnect();
        // a method to add new students to the database

        public bool addStudent(string fname, string lname, DateTime db, string gnd,
            string phone, string email, byte[] image, string fee)
        {
            string stat = "insert into Student (StdFirstName,StdLastName,Birthdate,Gender,Phone,Email,Photo,Fees) values (@fn,@ln,@dob,@pn,@gd,@em,@img,@fs)";
            SqlCommand cmd = new SqlCommand(stat, cn.getConnection);
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = db;
            cmd.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@gd", SqlDbType.VarChar).Value = gnd;

            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = image;
            cmd.Parameters.Add("@fs", SqlDbType.VarChar).Value = fee;

            cn.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.closeConnect();
                return true;

            }
            else
            {
                cn.closeConnect();
                return false;
            }
        }
        // get table
        public DataTable getStudentList(SqlCommand cmnd)
        {
            cmnd.Connection =  cn.getConnection;
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
        // a function to execute count query for the number of students
        public string exCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cn.getConnection);
            cn.openConnect();
            string total = cmd.ExecuteScalar().ToString();
            cn.closeConnect();
            return total;
        }
        // a function to get total number of students
        public string allStudents()
        {
            return exCount("select count(*) from Student");
        }
        // a functio to get the total number of female students
        public string femaleStudent()
        {
            return exCount("select count(*) from Student where Gender = 'Female'");
        }
        // a function to get the total number of male Students
        public string maleStudent()
        {
            return exCount("select count(*) from Student where Gender = 'Male'");
        }
        // a method to search for student names and email
        public DataTable searchStdDetails(string state)
        {
            string stdlist = "Select * from Student where concat (StdFirstName,StdLastName,Email) like '%" + state + "%'";
            SqlCommand cmnd = new SqlCommand(stdlist, cn.getConnection);
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }
        // Create a method to update student details.
        public bool updateStudentDetails(int id, string fname, string lname, DateTime db, string gnd,
            string phone, string email, byte[] image, string fee)
        {
            string stat = "update Student set StdFirstName=@fn, StdLastName=@ln,Birthdate=@dob,Phone=@pn,Gender=@gd,Email=@em,Photo=@img,Fees=@fs where StdId=@id ";
            SqlCommand cmd = new SqlCommand(stat, cn.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = db;
            cmd.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@gd", SqlDbType.VarChar).Value = gnd;

            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = image;
            cmd.Parameters.Add("@fs", SqlDbType.VarChar).Value = fee;

            cn.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.closeConnect();
                return true;

            }
            else
            {
                cn.closeConnect();
                return false;
            }
        }
        // method to delete Students from db
        public bool deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Student where StdId=@id", cn.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cn.openConnect();
            if (cmd.ExecuteNonQuery() == 1)
            {
                cn.closeConnect();
                return true;
            }
            else
            {
                cn.closeConnect();
                return false;
            }
        }
    }
}
