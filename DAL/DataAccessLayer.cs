using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Doctor_App.DAL
{
    class DataAccessLayer
    {
        SqlConnection con = new SqlConnection();
        public DataAccessLayer()
        {
            //  con = new SqlConnection();
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection"].ConnectionString); ;
        }
        public void Open()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //select data from db
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void excutedata(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = stored_procedure;
            cmd.Connection = con;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            cmd.ExecuteNonQuery();
        }


    }
}
