namespace Doctor_App.PL
{
    partial class New_User
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.adminradio = new System.Windows.Forms.RadioButton();
            this.userradio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "كلمة السر";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(25, 57);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(158, 20);
            this.usertxt.TabIndex = 4;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(25, 123);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(158, 20);
            this.passtxt.TabIndex = 5;
            // 
            // adminradio
            // 
            this.adminradio.AutoSize = true;
            this.adminradio.Location = new System.Drawing.Point(151, 185);
            this.adminradio.Name = "adminradio";
            this.adminradio.Size = new System.Drawing.Size(54, 17);
            this.adminradio.TabIndex = 6;
            this.adminradio.TabStop = true;
            this.adminradio.Text = "Admin";
            this.adminradio.UseVisualStyleBackColor = true;
            // 
            // userradio
            // 
            this.userradio.AutoSize = true;
            this.userradio.Location = new System.Drawing.Point(36, 185);
            this.userradio.Name = "userradio";
            this.userradio.Size = new System.Drawing.Size(47, 17);
            this.userradio.TabIndex = 7;
            this.userradio.TabStop = true;
            this.userradio.Text = "User";
            this.userradio.UseVisualStyleBackColor = true;
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.userradio);
            this.Controls.Add(this.adminradio);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.RadioButton adminradio;
        private System.Windows.Forms.RadioButton userradio;
    }
}