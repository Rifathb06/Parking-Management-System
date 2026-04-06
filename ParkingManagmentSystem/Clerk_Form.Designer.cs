namespace ParkingManagmentSystem
{
    partial class Clerk_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clerk_Form));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.text_parkingmanagement = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Label_ParkingDetails = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_Enter = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_UserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_RegisterParking = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ImageButton_RegisterParking = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImageButton_Logout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label_ClerkName = new System.Windows.Forms.Label();
            this.ImageButton_clerk = new Guna.UI2.WinForms.Guna2ImageButton();
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.registerSlot1 = new ParkingManagmentSystem.RegisterSlot();
            this.changePassword1 = new ParkingManagmentSystem.ChangePassword();
            this.parkingDetails1 = new ParkingManagmentSystem.ParkingDetails();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_parkingmanagement
            // 
            this.text_parkingmanagement.BackColor = System.Drawing.Color.Transparent;
            this.text_parkingmanagement.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_parkingmanagement.ForeColor = System.Drawing.Color.White;
            this.text_parkingmanagement.Location = new System.Drawing.Point(580, 30);
            this.text_parkingmanagement.Name = "text_parkingmanagement";
            this.text_parkingmanagement.Size = new System.Drawing.Size(440, 47);
            this.text_parkingmanagement.TabIndex = 32;
            this.text_parkingmanagement.Text = "Parking management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.guna2ImageButton1);
            this.panel2.Controls.Add(this.text_parkingmanagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1557, 96);
            this.panel2.TabIndex = 88;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1479, 21);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(50, 42);
            this.guna2ImageButton1.TabIndex = 105;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // Label_ParkingDetails
            // 
            this.Label_ParkingDetails.BackColor = System.Drawing.Color.Transparent;
            this.Label_ParkingDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ParkingDetails.Location = new System.Drawing.Point(23, 497);
            this.Label_ParkingDetails.Name = "Label_ParkingDetails";
            this.Label_ParkingDetails.Size = new System.Drawing.Size(167, 34);
            this.Label_ParkingDetails.TabIndex = 45;
            this.Label_ParkingDetails.Text = "Parking Details";
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton3.Image")));
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2ImageButton3.Location = new System.Drawing.Point(50, 416);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.Size = new System.Drawing.Size(102, 75);
            this.guna2ImageButton3.TabIndex = 44;
            this.guna2ImageButton3.UseTransparentBackground = true;
            this.guna2ImageButton3.Click += new System.EventHandler(this.guna2ImageButton3_Click);
            // 
            // Button_Enter
            // 
            this.Button_Enter.Animated = true;
            this.Button_Enter.BorderRadius = 10;
            this.Button_Enter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_Enter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_Enter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_Enter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_Enter.FillColor = System.Drawing.Color.Crimson;
            this.Button_Enter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Button_Enter.ForeColor = System.Drawing.Color.White;
            this.Button_Enter.Location = new System.Drawing.Point(67, 158);
            this.Button_Enter.Name = "Button_Enter";
            this.Button_Enter.Size = new System.Drawing.Size(69, 34);
            this.Button_Enter.TabIndex = 34;
            this.Button_Enter.Text = "Enter";
            this.Button_Enter.Click += new System.EventHandler(this.Button_Enter_Click);
            // 
            // TextBox_UserID
            // 
            this.TextBox_UserID.Animated = true;
            this.TextBox_UserID.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_UserID.BorderColor = System.Drawing.Color.White;
            this.TextBox_UserID.BorderRadius = 10;
            this.TextBox_UserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_UserID.DefaultText = "";
            this.TextBox_UserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_UserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_UserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_UserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_UserID.FillColor = System.Drawing.Color.LightSlateGray;
            this.TextBox_UserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_UserID.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.TextBox_UserID.ForeColor = System.Drawing.Color.White;
            this.TextBox_UserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_UserID.Location = new System.Drawing.Point(15, 116);
            this.TextBox_UserID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBox_UserID.Name = "TextBox_UserID";
            this.TextBox_UserID.PasswordChar = '\0';
            this.TextBox_UserID.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextBox_UserID.PlaceholderText = "Enter you UserID";
            this.TextBox_UserID.SelectedText = "";
            this.TextBox_UserID.Size = new System.Drawing.Size(186, 34);
            this.TextBox_UserID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextBox_UserID.TabIndex = 33;
            this.TextBox_UserID.TextChanged += new System.EventHandler(this.TextBox_UserID_TextChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(18, 654);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(172, 32);
            this.guna2HtmlLabel3.TabIndex = 43;
            this.guna2HtmlLabel3.Text = "Change\r\nPassword";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2ImageButton2.Location = new System.Drawing.Point(57, 578);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.Size = new System.Drawing.Size(79, 88);
            this.guna2ImageButton2.TabIndex = 42;
            this.guna2ImageButton2.UseTransparentBackground = true;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(56, 911);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 34);
            this.guna2HtmlLabel2.TabIndex = 41;
            this.guna2HtmlLabel2.Text = "Logout";
            // 
            // Label_RegisterParking
            // 
            this.Label_RegisterParking.BackColor = System.Drawing.Color.Transparent;
            this.Label_RegisterParking.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RegisterParking.Location = new System.Drawing.Point(19, 334);
            this.Label_RegisterParking.Name = "Label_RegisterParking";
            this.Label_RegisterParking.Size = new System.Drawing.Size(182, 34);
            this.Label_RegisterParking.TabIndex = 39;
            this.Label_RegisterParking.Text = "Register Parking";
            // 
            // ImageButton_RegisterParking
            // 
            this.ImageButton_RegisterParking.BackColor = System.Drawing.Color.Transparent;
            this.ImageButton_RegisterParking.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_RegisterParking.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_RegisterParking.Image = ((System.Drawing.Image)(resources.GetObject("ImageButton_RegisterParking.Image")));
            this.ImageButton_RegisterParking.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton_RegisterParking.ImageRotate = 0F;
            this.ImageButton_RegisterParking.ImageSize = new System.Drawing.Size(70, 70);
            this.ImageButton_RegisterParking.Location = new System.Drawing.Point(56, 253);
            this.ImageButton_RegisterParking.Name = "ImageButton_RegisterParking";
            this.ImageButton_RegisterParking.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_RegisterParking.Size = new System.Drawing.Size(102, 75);
            this.ImageButton_RegisterParking.TabIndex = 38;
            this.ImageButton_RegisterParking.UseTransparentBackground = true;
            this.ImageButton_RegisterParking.Click += new System.EventHandler(this.ImageButton_RegisterParking_Click);
            // 
            // ImageButton_Logout
            // 
            this.ImageButton_Logout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.Image = ((System.Drawing.Image)(resources.GetObject("ImageButton_Logout.Image")));
            this.ImageButton_Logout.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton_Logout.ImageRotate = 0F;
            this.ImageButton_Logout.ImageSize = new System.Drawing.Size(70, 70);
            this.ImageButton_Logout.Location = new System.Drawing.Point(44, 826);
            this.ImageButton_Logout.Name = "ImageButton_Logout";
            this.ImageButton_Logout.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.Size = new System.Drawing.Size(107, 96);
            this.ImageButton_Logout.TabIndex = 40;
            this.ImageButton_Logout.Click += new System.EventHandler(this.ImageButton_Logout_Click);
            // 
            // label_ClerkName
            // 
            this.label_ClerkName.AutoSize = true;
            this.label_ClerkName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClerkName.Location = new System.Drawing.Point(39, 112);
            this.label_ClerkName.Name = "label_ClerkName";
            this.label_ClerkName.Size = new System.Drawing.Size(135, 32);
            this.label_ClerkName.TabIndex = 0;
            this.label_ClerkName.Text = "ClerkName";
            this.label_ClerkName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_ClerkName.Click += new System.EventHandler(this.label_ClerkName_Click);
            // 
            // ImageButton_clerk
            // 
            this.ImageButton_clerk.BackColor = System.Drawing.Color.Transparent;
            this.ImageButton_clerk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImageButton_clerk.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_clerk.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_clerk.Image = ((System.Drawing.Image)(resources.GetObject("ImageButton_clerk.Image")));
            this.ImageButton_clerk.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton_clerk.ImageRotate = 0F;
            this.ImageButton_clerk.ImageSize = new System.Drawing.Size(90, 90);
            this.ImageButton_clerk.Location = new System.Drawing.Point(50, 6);
            this.ImageButton_clerk.Name = "ImageButton_clerk";
            this.ImageButton_clerk.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_clerk.Size = new System.Drawing.Size(110, 112);
            this.ImageButton_clerk.TabIndex = 36;
            this.ImageButton_clerk.UseTransparentBackground = true;
            // 
            // countdowntimer
            // 
            this.countdowntimer.Interval = 1000;
            this.countdowntimer.Tick += new System.EventHandler(this.countdowntimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.Label_ParkingDetails);
            this.panel1.Controls.Add(this.guna2ImageButton3);
            this.panel1.Controls.Add(this.Button_Enter);
            this.panel1.Controls.Add(this.TextBox_UserID);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.guna2ImageButton2);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.Label_RegisterParking);
            this.panel1.Controls.Add(this.ImageButton_RegisterParking);
            this.panel1.Controls.Add(this.ImageButton_Logout);
            this.panel1.Controls.Add(this.ImageButton_clerk);
            this.panel1.Controls.Add(this.label_ClerkName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 1000);
            this.panel1.TabIndex = 87;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // registerSlot1
            // 
            this.registerSlot1.BackColor = System.Drawing.Color.White;
            this.registerSlot1.Location = new System.Drawing.Point(215, 99);
            this.registerSlot1.Name = "registerSlot1";
            this.registerSlot1.Size = new System.Drawing.Size(1546, 900);
            this.registerSlot1.TabIndex = 89;
            this.registerSlot1.Load += new System.EventHandler(this.registerSlot1_Load);
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.White;
            this.changePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePassword1.Location = new System.Drawing.Point(414, 131);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(1154, 818);
            this.changePassword1.TabIndex = 90;
            this.changePassword1.Load += new System.EventHandler(this.changePassword1_Load);
            // 
            // parkingDetails1
            // 
            this.parkingDetails1.BackColor = System.Drawing.Color.White;
            this.parkingDetails1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("parkingDetails1.BackgroundImage")));
            this.parkingDetails1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.parkingDetails1.Location = new System.Drawing.Point(215, 99);
            this.parkingDetails1.Name = "parkingDetails1";
            this.parkingDetails1.Size = new System.Drawing.Size(1546, 900);
            this.parkingDetails1.TabIndex = 91;
            // 
            // Clerk_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1766, 1000);
            this.Controls.Add(this.parkingDetails1);
            this.Controls.Add(this.changePassword1);
            this.Controls.Add(this.registerSlot1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clerk_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clerk_Form";
            this.Load += new System.EventHandler(this.Clerk_Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel text_parkingmanagement;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_ParkingDetails;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private Guna.UI2.WinForms.Guna2Button Button_Enter;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_UserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_RegisterParking;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_RegisterParking;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_Logout;
        private System.Windows.Forms.Label label_ClerkName;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_clerk;
        private System.Windows.Forms.Timer countdowntimer;
        private System.Windows.Forms.Panel panel1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private RegisterSlot registerSlot1;
        private ChangePassword changePassword1;
        private ParkingDetails parkingDetails1;
    }
}