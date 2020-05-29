namespace Doctor_App.PL
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobtn_admin = new System.Windows.Forms.RadioButton();
            this.radiobtn_user = new System.Windows.Forms.RadioButton();
            this.user_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // radiobtn_admin
            // 
            this.radiobtn_admin.AutoSize = true;
            this.radiobtn_admin.Location = new System.Drawing.Point(160, 177);
            this.radiobtn_admin.Name = "radiobtn_admin";
            this.radiobtn_admin.Size = new System.Drawing.Size(54, 17);
            this.radiobtn_admin.TabIndex = 2;
            this.radiobtn_admin.TabStop = true;
            this.radiobtn_admin.Text = "Admin";
            this.radiobtn_admin.UseVisualStyleBackColor = true;
            // 
            // radiobtn_user
            // 
            this.radiobtn_user.AutoSize = true;
            this.radiobtn_user.Location = new System.Drawing.Point(33, 177);
            this.radiobtn_user.Name = "radiobtn_user";
            this.radiobtn_user.Size = new System.Drawing.Size(47, 17);
            this.radiobtn_user.TabIndex = 3;
            this.radiobtn_user.TabStop = true;
            this.radiobtn_user.Text = "User";
            this.radiobtn_user.UseVisualStyleBackColor = true;
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(33, 27);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(165, 20);
            this.user_txt.TabIndex = 4;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(33, 108);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(165, 20);
            this.pass_txt.TabIndex = 5;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(170, 220);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 29);
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(33, 220);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cancelbtn.Size = new System.Drawing.Size(75, 29);
            this.cancelbtn.TabIndex = 7;
            this.cancelbtn.Text = "cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.radiobtn_user);
            this.Controls.Add(this.radiobtn_admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobtn_admin;
        private System.Windows.Forms.RadioButton radiobtn_user;
        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}