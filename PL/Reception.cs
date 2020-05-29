using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_App.PL
{
    public partial class Reception : Form
    {
        string visit_type;
        public Reception()
        {
            InitializeComponent();
        //    doctor_namecompbox.SelectedIndexChanged += doctor_namecompbox_SelectedIndexChanged;
            string[] gender = new string[2];
            gender[0] = "Male";
            gender[1] = "Female";
            gendercompobox.Items.AddRange(gender);
         //   listBox1.SelectionMode = System.Windows.Forms.SelectionMode.One;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Reception_Load(object sender, EventArgs e)
        {
            BL.SelectData select = new BL.SelectData();
            DataTable dt = new DataTable();
          //  doctor_namecompbox.Items.Clear();
            //dt = select.doctor_name();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow row = dt.Rows[i];
            //    doctor_namecompbox.Items.Add(row["Name"]);
            //}

        }
        private void doctor_namecompbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gendercompobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Idtxt_TextChanged(object sender, EventArgs e)
        {
            var sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.get_Patientss();
            DataRow dr = dt.Rows[0];
            for(int i=0;i<dt.Rows.Count;i++)
            {
                if(Idtxt.Text==dr["patientID"].ToString())
                {
                    Nametxt.Text = dr["PName"].ToString();
                    Agetxt.Text = dr["age"].ToString();
                    gendercompobox.Text = dr["gender"].ToString();
                    phonenum.Text = dr["phone"].ToString();
                    emailtxt.Text = dr["email"].ToString();
                 
                 
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try {

                if (kashf_rdiobtn.Checked)
                {
                    visit_type = "كشف";
                }
                else
                    visit_type = "استشارة";

                BL.SelectData sel = new BL.SelectData();
                DataTable dt = new DataTable();
                //dtp = selpat.get_Patientss();
                //if (dtp.Rows.Count < 50)
                //{

                BL.InsertData insert_patientdata = new BL.InsertData();
                dt = sel.get_Patientss();
                DataRow dr = dt.Rows[0];
              
                    if (Idtxt.Text == dr["patientID"].ToString())
                    {
                        insert_patientdata.register_isteshara(Convert.ToInt32(Idtxt.Text), dateTimePicker1.Value.Date, visit_type);
                    MessageBox.Show("add successfuly");
                }
                    else
                    {

                      
                        insert_patientdata.add_patient(
                       Convert.ToInt32(Idtxt.Text),
                       Nametxt.Text,
                       Convert.ToInt32(Agetxt.Text),
                       gendercompobox.SelectedItem.ToString(),
                       phonenum.Text,
                       emailtxt.Text,
                       dateTimePicker1.Value.Date,
                       visit_type,
                       Convert.ToInt32(reversnum.Value.ToString()),
                        Convert.ToDecimal(costtxt.Text)

                        );


                        MessageBox.Show("add successfuly");
                        //////////////////////////////////////////////////////
                        Idtxt.Clear();
                        Nametxt.Clear();
                        Agetxt.Clear();
                        phonenum.Clear();
                        emailtxt.Clear();
                    
                }
                //    costtxt.Clear();
                //}

                //else
                //    MessageBox.Show("error =D");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void showreservbtn_Click(object sender, EventArgs e)
        {
            try
            {
                BL.SelectData sel = new BL.SelectData();
                DataTable dt = new DataTable();
                dt = sel.patient_name(dateTimePicker1.Value.Date);
                dataGridView1.DataSource = dt;
               



                BL.SelectData sel1 = new BL.SelectData();

                dt = sel.tot_cost(dateTimePicker1.Value.Date);
              
                    DataRow dr2 = dt.Rows[0];

                    costlbl.Text = dr2["total"].ToString();
               



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

        private void costlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.delete_patient(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows[0].Index);
        }
    }
}
