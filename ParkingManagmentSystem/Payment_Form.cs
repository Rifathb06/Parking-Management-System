using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class Payment_Form : Form
    {
        Customer customer;
        Customer_Form CF;
        private BookParking bookParking;

        // Constructor that takes a BookSlot object
        public Payment_Form(BookParking bookParking)
        {
            InitializeComponent();
            this.bookParking = bookParking;
        }
        
        private void Payment_Form_Load(object sender, EventArgs e)
        {
            label_Amount.Text = $"Pay: ${bookParking.Amount:F2}";  // Display the amount as currency
        }

        private void TextBox_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (TextBox_Number.Text != "" && TextBox_Number.Text.Length == 11)
            {
                MessageBox.Show("Payment Successful", "Successful", MessageBoxButtons.OKCancel);

                // After payment, trigger the print function in BookSlot
                bookParking.PerformPrint();
            }
            else
            {
                MessageBox.Show("Enter the Details", "Error", MessageBoxButtons.OKCancel);
            }
        }
        private void Button_Close_Click(object sender, EventArgs e)
        {
            new Customer_Form().Show();
            this.Hide();
        }

        private void label_Amount_Click(object sender, EventArgs e)
        {

        }
    }
}
