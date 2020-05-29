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
    public partial class Login : Form
    {
        string type;
        public Login()
        {
            InitializeComponent();
           
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (radiobtn_admin.Checked)
            {
                type = "Admin";
            }

            else
                type = "User";
            BL.SelectData sel = new BL.SelectData();
            DataTable dt = new DataTable();
            dt = sel.user_login(user_txt.Text, pass_txt.Text, type);
            if (dt.Rows.Count > 0 && radiobtn_admin.Checked)
            {
                Doctor_App.Home h = new Home();
                h.Show();
                this.Hide();
            }

            else if (dt.Rows.Count > 0 && radiobtn_user.Checked)
            {
                PL.Reception resp = new PL.Reception();
                resp.Show();
                this.Hide();
            }
            else
                MessageBox.Show("User name or password is not correct");
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
