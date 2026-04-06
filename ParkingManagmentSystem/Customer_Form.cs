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
    public partial class Customer_Form : Form
    {
        
        Login_Form login_form = new Login_Form();
        string UserID;
        BookParking bookParkingControl;
        Customer customer;
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        RegisterSlot registerSlot;

        public Customer_Form()
        {
            InitializeComponent();

            //registerSlot.UserType = "Customer"; // Set user type to Customer
            // Add the user control to your form, for example:
            // Initialize the BookSlot control
            bookParkingControl = new BookParking();

            // Assuming you have a panel or a placeholder for your user control
            
        }

        public void SetUserID(string userID)
        {
            this.UserID = userID; // Set UserID in Customer_Form

            // Pass the UserID to the BookSlot control
            bookParkingControl.UserID = this.UserID;
        }
        private void Customer_Form_Load(object sender, EventArgs e)
        {
            // Ensure the connection is opened before executing the command
            con.Open();

            // SQL query to fetch the customer details using UserID
            string query = "SELECT Name FROM CustomerTable WHERE UserID = @UserID"; // Assuming CustomerName is the column holding the name
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserID", UserID); // Correct parameter name to match the SQL query

            // Execute the command and retrieve the customer name
            //string result = cmd.ExecuteScalar().ToString(); // This will return the first column of the first row in the result set

            // Check if the result is not null and set the label text
           
                var nameResult = cmd.ExecuteScalar();
                label_CustomerName.Text = nameResult?.ToString() ?? "Unknown";


            // Hide/change visibility of controls as needed
            
            // Close the connection
            con.Close();
        }
        

        private void ImageButton_RegisterParking_Click(object sender, EventArgs e)
        {
            
          

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label_CustomerName_Click(object sender, EventArgs e)
        {

        }

        private void ImageButton_Logout_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        
    }
}
