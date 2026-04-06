namespace ParkingManagmentSystem
{
    partial class ChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.checkBox_ShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Label_userId = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.Button_Confirm = new Guna.UI2.WinForms.Guna2Button();
            this.Label_ChangePassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label_ConfirmPass = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(388, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 77;
            this.label1.Text = "New Password";
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.BackColor = System.Drawing.Color.White;
            this.textBox_newPassword.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_newPassword.Location = new System.Drawing.Point(393, 425);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.Size = new System.Drawing.Size(340, 43);
            this.textBox_newPassword.TabIndex = 76;
            this.textBox_newPassword.UseSystemPasswordChar = true;
            // 
            // checkBox_ShowPass
            // 
            this.checkBox_ShowPass.AutoSize = true;
            this.checkBox_ShowPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_ShowPass.CheckedState.BorderRadius = 0;
            this.checkBox_ShowPass.CheckedState.BorderThickness = 0;
            this.checkBox_ShowPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox_ShowPass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox_ShowPass.Location = new System.Drawing.Point(598, 565);
            this.checkBox_ShowPass.Name = "checkBox_ShowPass";
            this.checkBox_ShowPass.Size = new System.Drawing.Size(142, 25);
            this.checkBox_ShowPass.TabIndex = 75;
            this.checkBox_ShowPass.Text = "Show Password";
            this.checkBox_ShowPass.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.checkBox_ShowPass.UncheckedState.BorderRadius = 0;
            this.checkBox_ShowPass.UncheckedState.BorderThickness = 1;
            this.checkBox_ShowPass.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBox_ShowPass.CheckedChanged += new System.EventHandler(this.checkBox_ShowPass_CheckedChanged);
            // 
            // Label_userId
            // 
            this.Label_userId.AutoSize = true;
            this.Label_userId.BackColor = System.Drawing.Color.Transparent;
            this.Label_userId.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_userId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_userId.Location = new System.Drawing.Point(388, 207);
            this.Label_userId.Name = "Label_userId";
            this.Label_userId.Size = new System.Drawing.Size(75, 30);
            this.Label_userId.TabIndex = 74;
            this.Label_userId.Text = "UserID";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.BackColor = System.Drawing.Color.White;
            this.textBox_UserID.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_UserID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_UserID.Location = new System.Drawing.Point(393, 241);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(340, 43);
            this.textBox_UserID.TabIndex = 73;
            this.textBox_UserID.TextChanged += new System.EventHandler(this.textBox_UserID_TextChanged);
            // 
            // Button_Confirm
            // 
            this.Button_Confirm.Animated = true;
            this.Button_Confirm.BorderRadius = 10;
            this.Button_Confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Confirm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Button_Confirm.ForeColor = System.Drawing.Color.White;
            this.Button_Confirm.Location = new System.Drawing.Point(393, 600);
            this.Button_Confirm.Name = "Button_Confirm";
            this.Button_Confirm.Size = new System.Drawing.Size(340, 59);
            this.Button_Confirm.TabIndex = 72;
            this.Button_Confirm.Text = "Confirm";
            this.Button_Confirm.Click += new System.EventHandler(this.Button_Confirm_Click);
            // 
            // Label_ChangePassword
            // 
            this.Label_ChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.Label_ChangePassword.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ChangePassword.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label_ChangePassword.Location = new System.Drawing.Point(384, 120);
            this.Label_ChangePassword.Name = "Label_ChangePassword";
            this.Label_ChangePassword.Size = new System.Drawing.Size(358, 61);
            this.Label_ChangePassword.TabIndex = 71;
            this.Label_ChangePassword.Text = "Change Password";
            this.Label_ChangePassword.Click += new System.EventHandler(this.Label_ChangePassword_Click);
            // 
            // label_ConfirmPass
            // 
            this.label_ConfirmPass.AutoSize = true;
            this.label_ConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.label_ConfirmPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ConfirmPass.Location = new System.Drawing.Point(388, 471);
            this.label_ConfirmPass.Name = "label_ConfirmPass";
            this.label_ConfirmPass.Size = new System.Drawing.Size(227, 30);
            this.label_ConfirmPass.TabIndex = 70;
            this.label_ConfirmPass.Text = "Confirm New Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.BackColor = System.Drawing.Color.White;
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(393, 507);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(340, 43);
            this.textBox_ConfirmPassword.TabIndex = 69;
            this.textBox_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Password.Location = new System.Drawing.Point(388, 296);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(138, 30);
            this.label_Password.TabIndex = 68;
            this.label_Password.Text = "Old Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.White;
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F);
            this.textBox_Password.Location = new System.Drawing.Point(393, 332);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(340, 43);
            this.textBox_Password.TabIndex = 67;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_newPassword);
            this.Controls.Add(this.checkBox_ShowPass);
            this.Controls.Add(this.Label_userId);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.Button_Confirm);
            this.Controls.Add(this.Label_ChangePassword);
            this.Controls.Add(this.label_ConfirmPass);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Name = "ChangePassword";
            this.Size = new System.Drawing.Size(1154, 818);
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox_ShowPass;
        private System.Windows.Forms.Label Label_userId;
        private System.Windows.Forms.TextBox textBox_UserID;
        private Guna.UI2.WinForms.Guna2Button Button_Confirm;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_ChangePassword;
        private System.Windows.Forms.Label label_ConfirmPass;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
    }
}
