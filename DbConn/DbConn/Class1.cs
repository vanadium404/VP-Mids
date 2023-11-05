using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DbConn
{
    internal class DBCONN

    {
        public string _connectionString;
        public DBCONN(string con)
        {
            this._connectionString = con;
        }

        // This is function that will be used for all Insert Update Del Ops
        // We have to pass parameters from Form1.cs and parameters will be the arrays
        public int UpdateDeleteInsert(string qry, SqlParameter[] param=null )
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand(qry, con);
            if(param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            return cmd.ExecuteNonQuery();
        }

        // To View Data From the Database Connection Oriented
        public SqlDataReader SelectConn(string qry, SqlParameter[] param=null)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            // Param not equals null means we want to select all rows we dont
            // want to select using Primary key
            if(param != null)
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddRange(param);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;

            }
            // It means we want to search for a specific record
            else
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;
            }
        }

        public DataTable SelectConnLess(string qry, SqlParameter[] param = null)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(qry, con);
            con.Close();
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

    }
}
