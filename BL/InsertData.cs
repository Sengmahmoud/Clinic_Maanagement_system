using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Doctor_App.BL
{
    class InsertData
    {
        public void add_patient(int pid, string pname, int age, string gender,string phone , string email ,DateTime visitdate, string visit_type, int reservnum, decimal cost)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = pid;
            param[1] = new SqlParameter("@pname", SqlDbType.NVarChar);
            param[1].Value = pname;
            param[2] = new SqlParameter("@age", SqlDbType.Int);
            param[2].Value = age;
            param[3] = new SqlParameter("@gender", SqlDbType.NVarChar);
            param[3].Value = gender;
            param[4] = new SqlParameter("@phone", SqlDbType.NVarChar);
            param[4].Value = phone;
            param[5] = new SqlParameter("@email", SqlDbType.NVarChar);
            param[5].Value = email;
            param[6] = new SqlParameter("@visit_date", SqlDbType.Date);
            param[6].Value = visitdate;
            param[7] = new SqlParameter("@visit_type", SqlDbType.NVarChar);
            param[7].Value = visit_type;
            param[8] = new SqlParameter("@reverse_num", SqlDbType.Int);
            param[8].Value = reservnum;
            param[9] = new SqlParameter("@cost", SqlDbType.Decimal);
            param[9].Value =cost ;
            DAL.Open();
            DAL.excutedata("add_patient_data", param);
            DAL.Close();
        }
        public void add_patient_treats(int pid, int tid)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = pid;
            param[1] = new SqlParameter("@tid", SqlDbType.Int);
            param[1].Value = tid;
            DAL.Open();
            DAL.excutedata("insert_into_patient_treat", param);
            DAL.Close();
        }

        public void add_user(string username,string pass, string type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", SqlDbType.NVarChar);
            param[0].Value = username;
            param[1] = new SqlParameter("@pass", SqlDbType.NVarChar);
            param[1].Value = pass;
            param[2] = new SqlParameter("@type", SqlDbType.NVarChar);
            param[2].Value = type;
            DAL.Open();
            DataTable dt = DAL.SelectData("add_user", param);
            DAL.Close();


        }
        public void update_len_wit_stre(decimal legth, decimal wight, string stress)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@length", SqlDbType.Decimal);
            param[0].Value = legth;
            param[1] = new SqlParameter("@wight", SqlDbType.Decimal);
            param[1].Value = wight;
            param[2] = new SqlParameter("@stress", SqlDbType.NVarChar);
            param[2].Value = stress;
            DAL.Open();
            DataTable dt = DAL.SelectData("put_lenth_wigth_stress", param);
            DAL.Close();



        }

        public void register_isteshara(int pid,DateTime visit_date,string visit_type)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@pid", SqlDbType.Int);
            param[0].Value = pid;
            param[1] = new SqlParameter("@visit_date", SqlDbType.Date);
            param[1].Value = visit_date;
            param[2] = new SqlParameter("@visit_type", SqlDbType.NVarChar);
            param[2].Value = visit_type;
            DAL.Open();
            DataTable dt = DAL.SelectData("register_patient_istechara", param);
            DAL.Close();



        }


    }
}
