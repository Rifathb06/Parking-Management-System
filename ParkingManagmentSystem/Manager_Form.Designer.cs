namespace ParkingManagmentSystem
{
    partial class Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.Label_RegisterParking = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Label_ParkingDetails = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.text_parkingmanagement = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
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
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1637, 1019);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manager_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Label_RegisterParking;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label_ParkingDetails;
        private Guna.UI2.WinForms.Guna2HtmlLabel text_parkingmanagement;
    }
}