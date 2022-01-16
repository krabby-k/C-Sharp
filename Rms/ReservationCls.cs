using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Rms
{
    class ReservationCls
    {
        Dbconnect dc = new Dbconnect();

        public bool newReservation(string name, string phone, string email, DateTime dt, string opt, int prt, DateTime tm)
        {
            string rsv = "insert into Reservations(Name,Phone,Email,Date,Choice,Party,Time) values(@n,@ph,@em,@dt,@op,@py,@tm)";
            SqlCommand cmd = new SqlCommand(rsv, dc.GetConnection);

            cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@dt", SqlDbType.Date).Value = dt;
            cmd.Parameters.Add("@op", SqlDbType.VarChar).Value = opt;
            cmd.Parameters.Add("@py", SqlDbType.Int).Value = prt;
            cmd.Parameters.Add("@tm", SqlDbType.DateTime).Value = tm;

            dc.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                dc.closeConnection();
                return true;
            }
            else
            {
                dc.closeConnection();
                return false;
            }
        }
        //method to get datagrid view to list contents based on the search parameter
        public DataTable getReservationList(string sqlc)
        {
            string rslist = "Select * from Reservations where concat (ReserveId,Name,Phone,Email,Date,Choice,Party,Time) like '%" + sqlc + "%'";
            SqlCommand cmnd = new SqlCommand(rslist, dc.GetConnection);
            SqlDataAdapter apt = new SqlDataAdapter(cmnd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }

        // method to list everything from the table
        public DataTable listAll(SqlCommand cmd)
        {
            cmd.Connection = dc.GetConnection;
            SqlDataAdapter apt = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            apt.Fill(tb);
            return tb;
        }

        public bool updateReservations(int id, string name, string phone,string email, DateTime dt, string choice, int prt, DateTime tm)
        {
            
            string query = "Update Reservations set Name=@n, Phone=@ph, Email=@em, Date=@dt, Choice=@ch, Party=@py, Time=@tm where ReserveId=@id";
            SqlCommand cmd = new SqlCommand(query, dc.GetConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@n", SqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("@ph", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@em", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@dt", SqlDbType.Date).Value = dt;
            cmd.Parameters.Add("@ch", SqlDbType.VarChar).Value = choice;
            cmd.Parameters.Add("@py", SqlDbType.Int).Value = prt;
            cmd.Parameters.Add("@tm", SqlDbType.DateTime).Value = tm;

            dc.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                dc.closeConnection();
                return true;
            }
            else
            {
                dc.closeConnection();
                return false;
            }
        }
        public bool cancelReservation(int id)
        {
            SqlCommand cmd = new SqlCommand("Delete from Reservations where ReserveId=@id", dc.GetConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            dc.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                dc.closeConnection();
                return true;
            }
            else
            {
                dc.closeConnection();
                return false;
            }
        }
        public bool addReview(string review)
        {
            string q = "insert into Review (review) values(@r)";
            SqlCommand cmd = new SqlCommand(q, dc.GetConnection);

            cmd.Parameters.Add("@r", SqlDbType.VarChar).Value = review;

            if (cmd.ExecuteNonQuery() == 1)
            {
                dc.closeConnection();
                return true;
            }
            else
            {
                dc.closeConnection();
                return false;
            }
        }

    }
}
