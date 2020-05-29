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
    public partial class patient_per_month : Form
    {
        public patient_per_month()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.get_month(Convert.ToDateTime(dateTimePicker1.Text));
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();

            dt = sel.tot_cost_month(Convert.ToDateTime(dateTimePicker1.Text));

            DataRow dr2 = dt.Rows[0];

            costlbl.Text = dr2["total"].ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
            timelbl.Text = DateTime.Now.ToString("hh:mm:ss tt"); ;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Doctor_App.Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void patient_per_month_Load(object sender, EventArgs e)
        {

        }
    }
}
