using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class Clerk_Form : Form
    {
        Login_Form login_form= new Login_Form();
        RegisterSlot registerSlot;
        ParkingDetails parkingDetails = new ParkingDetails();
        string ClerkName;
        string UserID;
        float Duration;
        Clerk_Form log;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        public string UserID1 { get => UserID; set => UserID = value; }
        internal Clerk_Form Log { get => log; set => log = value; }
        int seconds = 0;
        public Clerk_Form()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clerk_Form_Load(object sender, EventArgs e)
        {
            seconds = 20;
            countdowntimer.Start();
            changePassword1.Visible = false;
            parkingDetails1.Visible = false;
            changePassword1.Hide();
            parkingDetails1.Hide();
            registerSlot1.Show();
            registerSlot1.BringToFront();

        }
        private void Clerk_Form_Load()
        {
            changePassword1.Visible = false;
            changePassword1.Hide();
            registerSlot1.Show();
            registerSlot1.BringToFront();
        }
        
        private void TextBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Enter_Click(object sender, EventArgs e)
        {
            if (TextBox_UserID.Text!="")
            {
                countdowntimer.Stop();
                string query1 = "SELECT Name FROM EmpTable WHERE UserID=@UserID;";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@UserID", TextBox_UserID.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                ClerkName = cmd.ExecuteScalar() as string;
                con.Close();

                if (ClerkName == null)
                {
                    MessageBox.Show("UserID not found! Please log in.", "Wrong credential!", MessageBoxButtons.OKCancel);
                    new Login_Form().Show();
                    this.Hide();
                }
                else
                {
                    label_ClerkName.Text = ClerkName;
                    TextBox_UserID.Enabled = false;
                }
                TextBox_UserID.Hide();
                Button_Enter.Hide();
            }
            else
            {
                MessageBox.Show("Enter UserID!", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void label_ClerkName_Click(object sender, EventArgs e)
        {

        }

        private void ImageButton_Logout_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }

        private void button_Book_Click(object sender, EventArgs e)
        {

        }

        private void countdowntimer_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds <= 0)
            {
                countdowntimer.Stop();
                new Login_Form().Show();
                this.Hide();
            }
        }

        

        private void ImageButton_RegisterParking_Click(object sender, EventArgs e)
        {
            changePassword1.Visible = false;
            parkingDetails1.Visible = false;
            changePassword1.Hide();
            parkingDetails1.Hide();

            registerSlot1.Show();
            registerSlot1.BringToFront();
        }

        

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
           registerSlot1.Visible = false;
            registerSlot1.Hide();
            parkingDetails1.Visible = false;
            parkingDetails1.Hide();
            changePassword1.Show();
            changePassword1.BringToFront();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerSlot1_Load(object sender, EventArgs e)
        {

        }

        private void changePassword1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            parkingDetails1.RefreshData();

            registerSlot1.Visible = false;
            registerSlot1.Hide();
            changePassword1.Visible = false;
            changePassword1.Hide();
            parkingDetails1.Show();
            parkingDetails1.BringToFront(); 
        }
    }
}
