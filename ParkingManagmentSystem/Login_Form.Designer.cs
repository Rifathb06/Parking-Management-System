namespace ParkingManagmentSystem
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.Label_UserID = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.checkBox_ShowPassLOGIN = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Button1_LOGIN = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Signup_Now = new System.Windows.Forms.Label();
            this.label_DontHaveAccount = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.Location = new System.Drawing.Point(695, 343);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(103, 30);
            this.label_Password.TabIndex = 74;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.White;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_Password.Location = new System.Drawing.Point(698, 376);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_Password.Size = new System.Drawing.Size(394, 43);
            this.textBox_Password.TabIndex = 71;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // Label_UserID
            // 
            this.Label_UserID.AutoSize = true;
            this.Label_UserID.BackColor = System.Drawing.Color.Transparent;
            this.Label_UserID.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_UserID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_UserID.Location = new System.Drawing.Point(698, 254);
            this.Label_UserID.Name = "Label_UserID";
            this.Label_UserID.Size = new System.Drawing.Size(77, 30);
            this.Label_UserID.TabIndex = 73;
            this.Label_UserID.Text = "UserID";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.BackColor = System.Drawing.Color.White;
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_UserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_UserID.Location = new System.Drawing.Point(698, 287);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(394, 43);
            this.textBox_UserID.TabIndex = 72;
            this.textBox_UserID.TextChanged += new System.EventHandler(this.textBox_UserID_TextChanged);
            // 
            // checkBox_ShowPassLOGIN
            // 
            this.checkBox_ShowPassLOGIN.AutoSize = true;
            this.checkBox_ShowPassLOGIN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_ShowPassLOGIN.CheckedState.BorderRadius = 0;
            this.checkBox_ShowPassLOGIN.CheckedState.BorderThickness = 0;
            this.checkBox_ShowPassLOGIN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_ShowPassLOGIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShowPassLOGIN.Location = new System.Drawing.Point(962, 425);
            this.checkBox_ShowPassLOGIN.Name = "checkBox_ShowPassLOGIN";
            this.checkBox_ShowPassLOGIN.Size = new System.Drawing.Size(138, 25);
            this.checkBox_ShowPassLOGIN.TabIndex = 70;
            this.checkBox_ShowPassLOGIN.Text = "Show Password";
            this.checkBox_ShowPassLOGIN.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.checkBox_ShowPassLOGIN.UncheckedState.BorderRadius = 0;
            this.checkBox_ShowPassLOGIN.UncheckedState.BorderThickness = 1;
            this.checkBox_ShowPassLOGIN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkBox_ShowPassLOGIN.UseVisualStyleBackColor = false;
            this.checkBox_ShowPassLOGIN.CheckedChanged += new System.EventHandler(this.checkBox_ShowPassLOGIN_CheckedChanged);
            // 
            // Button1_LOGIN
            // 
            this.Button1_LOGIN.Animated = true;
            this.Button1_LOGIN.BorderRadius = 10;
            this.Button1_LOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button1_LOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button1_LOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button1_LOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button1_LOGIN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Button1_LOGIN.ForeColor = System.Drawing.Color.White;
            this.Button1_LOGIN.Location = new System.Drawing.Point(698, 456);
            this.Button1_LOGIN.Name = "Button1_LOGIN";
            this.Button1_LOGIN.Size = new System.Drawing.Size(394, 59);
            this.Button1_LOGIN.TabIndex = 69;
            this.Button1_LOGIN.Text = "Login";
            this.Button1_LOGIN.Click += new System.EventHandler(this.Button1_LOGIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(839, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 39);
            this.label1.TabIndex = 68;
            this.label1.Text = "WELCOME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(846, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // label_Signup_Now
            // 
            this.label_Signup_Now.AutoSize = true;
            this.label_Signup_Now.BackColor = System.Drawing.Color.Transparent;
            this.label_Signup_Now.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Signup_Now.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_Signup_Now.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Signup_Now.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_Signup_Now.Location = new System.Drawing.Point(906, 532);
            this.label_Signup_Now.Name = "label_Signup_Now";
            this.label_Signup_Now.Size = new System.Drawing.Size(103, 21);
            this.label_Signup_Now.TabIndex = 66;
            this.label_Signup_Now.Text = "Signup Now ";
            this.label_Signup_Now.Click += new System.EventHandler(this.label_Signup_Now_Click);
            // 
            // label_DontHaveAccount
            // 
            this.label_DontHaveAccount.AutoSize = true;
            this.label_DontHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.label_DontHaveAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_DontHaveAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DontHaveAccount.ForeColor = System.Drawing.Color.Black;
            this.label_DontHaveAccount.Location = new System.Drawing.Point(754, 532);
            this.label_DontHaveAccount.Name = "label_DontHaveAccount";
            this.label_DontHaveAccount.Size = new System.Drawing.Size(157, 21);
            this.label_DontHaveAccount.TabIndex = 65;
            this.label_DontHaveAccount.Text = "Don\'t have account !!";
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.Transparent;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(47, 32);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(89, 35);
            this.button_Clear.TabIndex = 64;
            this.button_Clear.Text = "Exit";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1144, 632);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.Label_UserID);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.checkBox_ShowPassLOGIN);
            this.Controls.Add(this.Button1_LOGIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Signup_Now);
            this.Controls.Add(this.label_DontHaveAccount);
            this.Controls.Add(this.button_Clear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label Label_UserID;
        private System.Windows.Forms.TextBox textBox_UserID;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_ShowPassLOGIN;
        private Guna.UI2.WinForms.Guna2Button Button1_LOGIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Signup_Now;
        private System.Windows.Forms.Label label_DontHaveAccount;
        private System.Windows.Forms.Button button_Clear;
    }
}