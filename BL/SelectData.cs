using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_App.BL
{
    class SelectData
    {
         

        public DataTable patient_name(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@visit_date", SqlDbType.DateTime);
            param[0].Value = date;
            DAL.Open();
            DataTable dt = new DataTable();
            dt = DAL.SelectData("get_resevations", param);
            DAL.Close();
            return dt;
        }

        public DataTable tot_cost(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@visit_date", SqlDbType.Date);
            param[0].Value = date;
            DAL.Open();
            DataTable dt = DAL.SelectData("tot_cost", param);
            DAL.Close();
            return dt;
        }

        public DataTable patientdata(int reservnum,DateTime visitdate)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@reversnum", SqlDbType.Int);
            param[0].Value = reservnum;
            param[1] = new SqlParameter("@visit_date", SqlDbType.Date);
            param[1].Value = visitdate;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_patient_data_by_reversnum", param);
            DAL.Close();
            return dt;  
        }

        public DataTable get_reversnum(DateTime visitdate)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@visit_date", SqlDbType.DateTime);
            param[0].Value = visitdate;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_reservnum", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_treatments(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = name;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_treatments", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_Patientss()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            DataTable dt = DAL.SelectData("get_patients_data", null);
            DAL.Close();
            return dt;
        }
        public DataTable searchpatient(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = name;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_patient_by_name", param);
            DAL.Close();
            return dt;
        }

        public DataTable treatid(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[0].Value = name;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_treatid", param);
            DAL.Close();
            return dt;
        }
        public DataTable gettreaname(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = id;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_treat_to_rosheta", param);
            DAL.Close();
            return dt;
        }

        public DataTable delete_patient(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = id;
            DAL.Open();
            DataTable dt = DAL.SelectData("delete_patient", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_month(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@visit_date", SqlDbType.DateTime);
            param[0].Value = date;
            DAL.Open();
            DataTable dt = DAL.SelectData("patients_per_month", param);
            DAL.Close();
            return dt;
        }
        public DataTable tot_cost_month(DateTime date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@visit_date", SqlDbType.DateTime);
            param[0].Value = date;
            DAL.Open();
            DataTable dt = DAL.SelectData("total_cost_per_month", param);
            DAL.Close();
            return dt;
        }

        public DataTable user_login(string id, string pass, string type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar);
            param[0].Value = id;
            param[1] = new SqlParameter("@pass", SqlDbType.NVarChar);
            param[1].Value = pass;
            param[2] = new SqlParameter("@type", SqlDbType.NVarChar);
            param[2].Value = type;
            DAL.Open();
            DataTable dt = DAL.SelectData("login_user", param);
            DAL.Close();
            return dt;
        }
        public DataTable delete_user(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.Open();
            DataTable dt = DAL.SelectData("delete_user", param);
            DAL.Close();
            return dt;
        }
        public DataTable show_users()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           
            DAL.Open();
            DataTable dt = DAL.SelectData("get_users", null);
            DAL.Close();
            return dt;
        }
        public DataTable get_rosheta(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = id;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_treatrosheta", param);
            DAL.Close();
            return dt;
        }
        public DataTable get_patient_history(int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = id;
            DAL.Open();
            DataTable dt = DAL.SelectData("get_patient_report", param);
            DAL.Close();
            return dt;
        }
        public DataTable getpatientidarchif()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DAL.Open();
            DataTable dt = DAL.SelectData("get_pid_from_archif", null);
            DAL.Close();
            return dt;
        }
    }
}
