namespace ParkingManagmentSystem
{
    partial class Checker_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checker_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.countdowntimer = new System.Windows.Forms.Timer(this.components);
            this.button_Check = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Enter = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_UserID = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_Checker = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ImageButton_clerk = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Button_ChangePassword = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox_checkVehicle = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_CheckToken_TokenChecker = new Guna.UI2.WinForms.Guna2TextBox();
            this.text_parkingmanagement = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Button_Verify = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImageButton_Logout = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dataGridView_NotificationBox_TokenChecker = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Button_Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changePassword1 = new ParkingManagmentSystem.ChangePassword();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotificationBox_TokenChecker)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countdowntimer
            // 
            this.countdowntimer.Interval = 1000;
            this.countdowntimer.Tick += new System.EventHandler(this.countdowntimer_Tick);
            // 
            // button_Check
            // 
            this.button_Check.Animated = true;
            this.button_Check.BackColor = System.Drawing.Color.Transparent;
            this.button_Check.BorderRadius = 10;
            this.button_Check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_Check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_Check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_Check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_Check.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(1051, 200);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(222, 59);
            this.button_Check.TabIndex = 51;
            this.button_Check.Text = "Check";
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
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
            this.Button_Enter.Location = new System.Drawing.Point(71, 159);
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
            this.TextBox_UserID.Location = new System.Drawing.Point(17, 117);
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
            // text_Checker
            // 
            this.text_Checker.BackColor = System.Drawing.Color.Transparent;
            this.text_Checker.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Checker.Location = new System.Drawing.Point(59, 113);
            this.text_Checker.Name = "text_Checker";
            this.text_Checker.Size = new System.Drawing.Size(93, 34);
            this.text_Checker.TabIndex = 37;
            this.text_Checker.Text = "            Checker         ";
            this.text_Checker.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.text_Checker.Click += new System.EventHandler(this.text_Checker_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 551);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(172, 32);
            this.guna2HtmlLabel3.TabIndex = 43;
            this.guna2HtmlLabel3.Text = "Change\r\nPassword";
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
            this.ImageButton_clerk.ImageSize = new System.Drawing.Size(80, 80);
            this.ImageButton_clerk.Location = new System.Drawing.Point(53, 12);
            this.ImageButton_clerk.Name = "ImageButton_clerk";
            this.ImageButton_clerk.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_clerk.Size = new System.Drawing.Size(110, 112);
            this.ImageButton_clerk.TabIndex = 36;
            this.ImageButton_clerk.UseTransparentBackground = true;
            // 
            // Button_ChangePassword
            // 
            this.Button_ChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.Button_ChangePassword.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_ChangePassword.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("Button_ChangePassword.Image")));
            this.Button_ChangePassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.Button_ChangePassword.ImageRotate = 0F;
            this.Button_ChangePassword.ImageSize = new System.Drawing.Size(70, 70);
            this.Button_ChangePassword.Location = new System.Drawing.Point(65, 475);
            this.Button_ChangePassword.Name = "Button_ChangePassword";
            this.Button_ChangePassword.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_ChangePassword.Size = new System.Drawing.Size(79, 88);
            this.Button_ChangePassword.TabIndex = 42;
            this.Button_ChangePassword.UseTransparentBackground = true;
            this.Button_ChangePassword.Click += new System.EventHandler(this.Button_ChangePassword_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(59, 851);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 34);
            this.guna2HtmlLabel2.TabIndex = 41;
            this.guna2HtmlLabel2.Text = "Logout";
            // 
            // textBox_checkVehicle
            // 
            this.textBox_checkVehicle.BorderRadius = 10;
            this.textBox_checkVehicle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_checkVehicle.DefaultText = "";
            this.textBox_checkVehicle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_checkVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_checkVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_checkVehicle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_checkVehicle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_checkVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox_checkVehicle.ForeColor = System.Drawing.Color.Black;
            this.textBox_checkVehicle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_checkVehicle.Location = new System.Drawing.Point(661, 200);
            this.textBox_checkVehicle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_checkVehicle.Name = "textBox_checkVehicle";
            this.textBox_checkVehicle.PasswordChar = '\0';
            this.textBox_checkVehicle.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBox_checkVehicle.PlaceholderText = "Check Vehical Number";
            this.textBox_checkVehicle.SelectedText = "";
            this.textBox_checkVehicle.Size = new System.Drawing.Size(315, 59);
            this.textBox_checkVehicle.TabIndex = 50;
            this.textBox_checkVehicle.TextChanged += new System.EventHandler(this.textBox_checkVehicle_TextChanged);
            // 
            // textBox_CheckToken_TokenChecker
            // 
            this.textBox_CheckToken_TokenChecker.BorderRadius = 10;
            this.textBox_CheckToken_TokenChecker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_CheckToken_TokenChecker.DefaultText = "";
            this.textBox_CheckToken_TokenChecker.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_CheckToken_TokenChecker.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_CheckToken_TokenChecker.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_CheckToken_TokenChecker.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_CheckToken_TokenChecker.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_CheckToken_TokenChecker.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CheckToken_TokenChecker.ForeColor = System.Drawing.Color.Black;
            this.textBox_CheckToken_TokenChecker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_CheckToken_TokenChecker.Location = new System.Drawing.Point(275, 200);
            this.textBox_CheckToken_TokenChecker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_CheckToken_TokenChecker.Name = "textBox_CheckToken_TokenChecker";
            this.textBox_CheckToken_TokenChecker.PasswordChar = '\0';
            this.textBox_CheckToken_TokenChecker.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.textBox_CheckToken_TokenChecker.PlaceholderText = "Check Token ID";
            this.textBox_CheckToken_TokenChecker.SelectedText = "";
            this.textBox_CheckToken_TokenChecker.Size = new System.Drawing.Size(315, 59);
            this.textBox_CheckToken_TokenChecker.TabIndex = 49;
            this.textBox_CheckToken_TokenChecker.TextChanged += new System.EventHandler(this.textBox_CheckToken_TokenChecker_TextChanged);
            // 
            // text_parkingmanagement
            // 
            this.text_parkingmanagement.BackColor = System.Drawing.Color.Transparent;
            this.text_parkingmanagement.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_parkingmanagement.ForeColor = System.Drawing.Color.White;
            this.text_parkingmanagement.Location = new System.Drawing.Point(370, 37);
            this.text_parkingmanagement.Name = "text_parkingmanagement";
            this.text_parkingmanagement.Size = new System.Drawing.Size(440, 47);
            this.text_parkingmanagement.TabIndex = 32;
            this.text_parkingmanagement.Text = "Parking management System";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(70, 375);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(66, 34);
            this.guna2HtmlLabel1.TabIndex = 39;
            this.guna2HtmlLabel1.Text = "Verify";
            // 
            // Button_Verify
            // 
            this.Button_Verify.BackColor = System.Drawing.Color.Transparent;
            this.Button_Verify.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Verify.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Verify.Image = ((System.Drawing.Image)(resources.GetObject("Button_Verify.Image")));
            this.Button_Verify.ImageOffset = new System.Drawing.Point(0, 0);
            this.Button_Verify.ImageRotate = 0F;
            this.Button_Verify.ImageSize = new System.Drawing.Size(70, 70);
            this.Button_Verify.Location = new System.Drawing.Point(53, 294);
            this.Button_Verify.Name = "Button_Verify";
            this.Button_Verify.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Verify.Size = new System.Drawing.Size(102, 75);
            this.Button_Verify.TabIndex = 38;
            this.Button_Verify.UseTransparentBackground = true;
            this.Button_Verify.Click += new System.EventHandler(this.Button_Verify_Click);
            // 
            // ImageButton_Logout
            // 
            this.ImageButton_Logout.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.Image = ((System.Drawing.Image)(resources.GetObject("ImageButton_Logout.Image")));
            this.ImageButton_Logout.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton_Logout.ImageRotate = 0F;
            this.ImageButton_Logout.ImageSize = new System.Drawing.Size(70, 70);
            this.ImageButton_Logout.Location = new System.Drawing.Point(48, 766);
            this.ImageButton_Logout.Name = "ImageButton_Logout";
            this.ImageButton_Logout.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton_Logout.Size = new System.Drawing.Size(107, 96);
            this.ImageButton_Logout.TabIndex = 40;
            this.ImageButton_Logout.Click += new System.EventHandler(this.ImageButton_Logout_Click);
            // 
            // dataGridView_NotificationBox_TokenChecker
            // 
            this.dataGridView_NotificationBox_TokenChecker.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_NotificationBox_TokenChecker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_NotificationBox_TokenChecker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_NotificationBox_TokenChecker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_NotificationBox_TokenChecker.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_NotificationBox_TokenChecker.Location = new System.Drawing.Point(289, 351);
            this.dataGridView_NotificationBox_TokenChecker.Name = "dataGridView_NotificationBox_TokenChecker";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_NotificationBox_TokenChecker.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_NotificationBox_TokenChecker.ShowCellToolTips = false;
            this.dataGridView_NotificationBox_TokenChecker.Size = new System.Drawing.Size(965, 477);
            this.dataGridView_NotificationBox_TokenChecker.TabIndex = 48;
            this.dataGridView_NotificationBox_TokenChecker.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NotificationBox_TokenChecker_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Button_Exit);
            this.panel2.Controls.Add(this.text_parkingmanagement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 105);
            this.panel2.TabIndex = 47;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Button_Exit.Image")));
            this.Button_Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.Button_Exit.ImageRotate = 0F;
            this.Button_Exit.ImageSize = new System.Drawing.Size(40, 40);
            this.Button_Exit.Location = new System.Drawing.Point(1081, 24);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Button_Exit.Size = new System.Drawing.Size(50, 42);
            this.Button_Exit.TabIndex = 71;
            this.Button_Exit.UseTransparentBackground = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.Button_Enter);
            this.panel1.Controls.Add(this.TextBox_UserID);
            this.panel1.Controls.Add(this.text_Checker);
            this.panel1.Controls.Add(this.guna2HtmlLabel3);
            this.panel1.Controls.Add(this.ImageButton_clerk);
            this.panel1.Controls.Add(this.Button_ChangePassword);
            this.panel1.Controls.Add(this.guna2HtmlLabel2);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.Button_Verify);
            this.panel1.Controls.Add(this.ImageButton_Logout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 923);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // changePassword1
            // 
            this.changePassword1.BackColor = System.Drawing.Color.White;
            this.changePassword1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.changePassword1.Location = new System.Drawing.Point(209, 102);
            this.changePassword1.Name = "changePassword1";
            this.changePassword1.Size = new System.Drawing.Size(1154, 818);
            this.changePassword1.TabIndex = 52;
            this.changePassword1.Load += new System.EventHandler(this.changePassword1_Load);
            // 
            // Checker_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1363, 923);
            this.Controls.Add(this.changePassword1);
            this.Controls.Add(this.button_Check);
            this.Controls.Add(this.textBox_checkVehicle);
            this.Controls.Add(this.textBox_CheckToken_TokenChecker);
            this.Controls.Add(this.dataGridView_NotificationBox_TokenChecker);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Checker_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checker_Form";
            this.Load += new System.EventHandler(this.Checker_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NotificationBox_TokenChecker)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer countdowntimer;
        private Guna.UI2.WinForms.Guna2Button button_Check;
        private Guna.UI2.WinForms.Guna2Button Button_Enter;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_UserID;
        private Guna.UI2.WinForms.Guna2HtmlLabel text_Checker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_clerk;
        private Guna.UI2.WinForms.Guna2ImageButton Button_ChangePassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_checkVehicle;
        private Guna.UI2.WinForms.Guna2TextBox textBox_CheckToken_TokenChecker;
        private Guna.UI2.WinForms.Guna2HtmlLabel text_parkingmanagement;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Verify;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButton_Logout;
        private System.Windows.Forms.DataGridView dataGridView_NotificationBox_TokenChecker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private ChangePassword changePassword1;
        private Guna.UI2.WinForms.Guna2ImageButton Button_Exit;
    }
}