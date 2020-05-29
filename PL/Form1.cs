using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_App
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();

        }

      
       

        private void docbtn_Click_1(object sender, EventArgs e)
        {
            panel1.Width = docbtn.Width;
            panel1.Left = docbtn.Left;
            panel1.BackColor = Color.Orange;

            PL.Doctor doctor = new PL.Doctor();
            doctor.Show();
        }

        private void recpbtn_Click(object sender, EventArgs e)
        {
            panel1.Width = recpbtn.Width;
            panel1.Left = recpbtn.Left;
            panel1.BackColor = Color.DeepSkyBlue;


            PL.Reception reception = new PL.Reception();
            reception.Show();
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PL.Patients pat = new PL.Patients();
            pat.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");
            timelbl.Text = DateTime.Now.ToString("hh:mm:ss tt"); ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PL.patient_per_month prm = new PL.patient_per_month();
            prm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PL.Users users = new PL.Users();
            users.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PL.New_User newuser = new PL.New_User();
            newuser.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
