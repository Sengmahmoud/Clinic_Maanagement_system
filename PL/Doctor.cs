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
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            patientname_compbox.SelectedIndexChanged += patientname_compbox_SelectedIndexChanged;
            //    treatmentcompbox.SelectedIndexChanged += treatmentcompbox_SelectedIndexChanged;
            //   listView1.Columns.Add("ID", 70);
            // listView1.Columns.Add("Name", 150);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        //// ADD TO List VIEW
        //private void add(int ID, string name)
        //{
        //    string[] row = { Convert.ToString(ID), name };

        //    ListViewItem item = new ListViewItem(row);

        //    listView1.Items.Add(item);
        //}
        private void Doctor_Load(object sender, EventArgs e)
        {
            //BL.SelectData sel = new BL.SelectData();
            //DataTable dt = new DataTable();
            //dt = sel.get_treatments();
           
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    DataRow row = dt.Rows[i];
            //    treatmentcompbox.Items.Add(row["Name"]);
            //}

        }

        //private void patientname_compbox_SelectedIndexChanged(object sender, EventArgs e)
        //{
           
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BL.SelectData select = new BL.SelectData();
            DataTable dt = new DataTable();
            //    patientname_compbox.Items.Clear();
            dt = select.get_reversnum(Convert.ToDateTime(dateTimePicker1.Text));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                patientname_compbox.Items.Add(row["reverse_num"]);
            }
        }
     //   int i = 0;
        private void treatmentcompbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BL.SelectData sel = new BL.SelectData();
            //DataTable dt = new DataTable();
            //dt = sel.get_treatments();

            //      add(i, treatmentcompbox.SelectedItem.ToString());
            //    i++;

          //  listBox1.Items.Add(treatmentcompbox.SelectedItem);
            //   listView1.Items.Add(treatmentcompbox.SelectedItem.ToString());

            // listView1.Items.Clear();
            //    dt = sel.patient_name(Convert.ToDateTime(dateTimePicker1.Text));

            //for (int i = 0; i < dt.Rows.Count; i++)
            // {
            //     DataRow dr = dt.Rows[i];
            //     listView1.Items.Add(dr["Name"].ToString());

            // }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.SelectData sel1 = new BL.SelectData();
            DataTable dt1 = new DataTable();
            dt1 = sel1.getpatientidarchif();
            DataRow dr1 = dt1.Rows[0];
            if (dataGridView1.Rows[0].Cells[0].Value == dr1["PId"])
            {

            }

            else
            {
                BL.SelectData sel = new BL.SelectData();
                DataTable dt = new DataTable();
                BL.InsertData insert = new BL.InsertData();
                //  dt=sel.treatid(listBox1)
                if (listBox1.Items.Count != 0)
                {
                    foreach (string treat in listBox1.Items)
                    {
                        dt = sel.treatid(treat);
                        DataRow dr2 = dt.Rows[0];
                        insert.add_patient_treats(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value), Convert.ToInt32(dr2["ID"].ToString()));
                    }
                }

                MessageBox.Show("add Successfuly");

            }
        }

        private void patientname_compbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.patientdata(Convert.ToInt32(patientname_compbox.SelectedItem), dateTimePicker1.Value.Date);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RPT.rpt_rosheta myreport = new RPT.rpt_rosheta();
            myreport.SetParameterValue("@pid", dataGridView1.Rows[0].Cells[0].Value);
            myreport.SetParameterValue("@visit_date", dataGridView1.Rows[0].Cells[9].Value);
            RPT.FRM_RPT myform = new RPT.FRM_RPT();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {

            Doctor_App.Home h = new Home();
            h.Show();
        }

        private void treattxt_TextChanged(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.get_treatments(treattxt.Text);
            dataGridView2.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dataGridView2.SelectedCells[0].Value);
            treattxt.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BL.InsertData insert = new BL.InsertData();
            insert.update_len_wit_stre(Convert.ToDecimal(dataGridView1.Rows[0].Cells[4].Value), Convert.ToDecimal(dataGridView1.Rows[0].Cells[5].Value), dataGridView1.Rows[0].Cells[6].Value.ToString());
            MessageBox.Show("updated");
        }
    }
}
