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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            timer1.Start();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {

            Doctor_App.Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.show_users();
            dataGridView1.DataSource = dt;
        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.delete_user(Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value));
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows[0].Index);
        }
    }
}
