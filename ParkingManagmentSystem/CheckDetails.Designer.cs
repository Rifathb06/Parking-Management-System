namespace ParkingManagmentSystem
{
    partial class CheckDetails
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
            this.button_searchBS = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_searchBS = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_TokenCheckerNF = new System.Windows.Forms.Label();
            this.dataGridView_TokenNF = new System.Windows.Forms.DataGridView();
            this.label_Notification = new System.Windows.Forms.Label();
            this.dataGridView_NF = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TokenNF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NF)).BeginInit();
            this.SuspendLayout();
            // 
            // button_searchBS
            // 
            this.button_searchBS.Animated = true;
            this.button_searchBS.BorderRadius = 10;
            this.button_searchBS.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_searchBS.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_searchBS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_searchBS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_searchBS.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_searchBS.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.button_searchBS.ForeColor = System.Drawing.Color.White;
            this.button_searchBS.Location = new System.Drawing.Point(678, 355);
            this.button_searchBS.Name = "button_searchBS";
            this.button_searchBS.Size = new System.Drawing.Size(149, 53);
            this.button_searchBS.TabIndex = 122;
            this.button_searchBS.Text = "Search";
            // 
            // textBox_searchBS
            // 
            this.textBox_searchBS.Animated = true;
            this.textBox_searchBS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_searchBS.DefaultText = "";
            this.textBox_searchBS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_searchBS.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_searchBS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_searchBS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_searchBS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_searchBS.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.textBox_searchBS.ForeColor = System.Drawing.Color.Black;
            this.textBox_searchBS.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_searchBS.Location = new System.Drawing.Point(345, 358);
            this.textBox_searchBS.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox_searchBS.Name = "textBox_searchBS";
            this.textBox_searchBS.PasswordChar = '\0';
            this.textBox_searchBS.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.textBox_searchBS.PlaceholderText = "Search";
            this.textBox_searchBS.SelectedText = "";
            this.textBox_searchBS.Size = new System.Drawing.Size(258, 50);
            this.textBox_searchBS.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBox_searchBS.TabIndex = 120;
            this.textBox_searchBS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_searchBS.TextChanged += new System.EventHandler(this.textBox_searchBS_TextChanged);
            // 
            // label_TokenCheckerNF
            // 
            this.label_TokenCheckerNF.AutoSize = true;
            this.label_TokenCheckerNF.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TokenCheckerNF.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_TokenCheckerNF.Location = new System.Drawing.Point(522, 46);
            this.label_TokenCheckerNF.Name = "label_TokenCheckerNF";
            this.label_TokenCheckerNF.Size = new System.Drawing.Size(200, 45);
            this.label_TokenCheckerNF.TabIndex = 119;
            this.label_TokenCheckerNF.Text = "Own Details";
            // 
            // dataGridView_TokenNF
            // 
            this.dataGridView_TokenNF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_TokenNF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TokenNF.Location = new System.Drawing.Point(103, 123);
            this.dataGridView_TokenNF.Name = "dataGridView_TokenNF";
            this.dataGridView_TokenNF.Size = new System.Drawing.Size(971, 80);
            this.dataGridView_TokenNF.TabIndex = 118;
            this.dataGridView_TokenNF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TokenNF_CellContentClick);
            // 
            // label_Notification
            // 
            this.label_Notification.AutoSize = true;
            this.label_Notification.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Notification.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_Notification.Location = new System.Drawing.Point(454, 255);
            this.label_Notification.Name = "label_Notification";
            this.label_Notification.Size = new System.Drawing.Size(315, 45);
            this.label_Notification.TabIndex = 117;
            this.label_Notification.Text = "Booked Slot Details";
            // 
            // dataGridView_NF
            // 
            this.dataGridView_NF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_NF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NF.Location = new System.Drawing.Point(103, 425);
            this.dataGridView_NF.Name = "dataGridView_NF";
            this.dataGridView_NF.Size = new System.Drawing.Size(959, 356);
            this.dataGridView_NF.TabIndex = 116;
            this.dataGridView_NF.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_NF_CellContentClick);
            // 
            // CheckDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_searchBS);
            this.Controls.Add(this.textBox_searchBS);
            this.Controls.Add(this.label_TokenCheckerNF);
            this.Controls.Add(this.dataGridView_TokenNF);
            this.Controls.Add(this.label_Notification);
            this.Controls.Add(this.dataGridView_NF);
            this.Name = "CheckDetails";
            this.Size = new System.Drawing.Size(1168, 821);
            this.Load += new System.EventHandler(this.CheckDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TokenNF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button button_searchBS;
        private Guna.UI2.WinForms.Guna2TextBox textBox_searchBS;
        private System.Windows.Forms.Label label_TokenCheckerNF;
        private System.Windows.Forms.DataGridView dataGridView_TokenNF;
        private System.Windows.Forms.Label label_Notification;
        private System.Windows.Forms.DataGridView dataGridView_NF;
    }
}
