using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_App.PL
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.SelectData select = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = select.get_Patientss();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BL.SelectData select = new BL.SelectData();
            //DataTable dt = new DataTable();
            //dt = select.searchpatient(pnameorcodetxt.Text);
            //dataGridView1.DataSource = dt;

            //DataTable dt2 = new DataTable();
            //listBox1.Items.Clear();
            //dt2 = select.gettreaname(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));

            //for (int i = 0; i < dt2.Rows.Count; i++)
            //{
            //    DataRow dr = dt2.Rows[i];
            //   listBox1.Items.Add(dr["Name"].ToString());

            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnameorcodetxt_TextChanged(object sender, EventArgs e)
        {
            BL.SelectData select = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = select.searchpatient(pnameorcodetxt.Text);
            dataGridView1.DataSource = dt;

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.delete_patient(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows[0].Index);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.patient_history_rpt myreport = new RPT.patient_history_rpt();
            myreport.SetParameterValue("@pid",Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            RPT.FRM_RPT myform = new RPT.FRM_RPT();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.SelectData select = new BL.SelectData();
            DataTable dt2 = new DataTable();
            listBox1.Items.Clear();
            dt2 = select.gettreaname(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow dr = dt2.Rows[i];
                listBox1.Items.Add(dr["Name"].ToString());
               
            }

          
        }
    }
}
