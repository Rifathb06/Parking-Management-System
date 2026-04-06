using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    class Customer:Person
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        private string GenerateID;
        private Token[] token = new Token[36];
        
        private int slot;
        private int uniqId;
        private string phoneNumber;
        private string vehicalNumber;
        private float Duration;
        private static float TokenPrice;
        public Customer()
        {
        }

        public Customer(string name, int nid, string phone, string userID, string password) : base(name, nid, phone, userID, password)
        {

        }
        public string GenerateID1 { get => GenerateID; set => GenerateID = value; }
        public string VehicalNumber { get => vehicalNumber; set => vehicalNumber = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int Slot { get => slot; set => slot = value; }
        public int UniqId1 { get => uniqId; set => uniqId = value; }
        public float Duration1 { get => Duration; set => Duration = value; }
        public float TokenPrice1 { get => TokenPrice; set => TokenPrice = value; }

        public bool InsertToken(Token t)
        {
            if (t == null)
                return false;
            token[slot] = t;
            token[slot].PriceOperation(Duration);
            return true;
        }

        public void TokenOperation()
        {
            try
            {

                // Generate a unique ID for the token
                GenerateID = Name.Substring(0, 2) + vehicalNumber;
                Token to = new Token(GenerateID, slot, TokenPrice1, Duration1);

                // Check if the slot is already booked
                string checkQuery = "SELECT COUNT(*) FROM SlotTable WHERE slot = @slot";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@slot", slot);

                con.Open();
                int slotCount = (int)checkCmd.ExecuteScalar(); // Get the number of records with the same slot number

                if (slotCount > 0)
                {
                    // Slot is already booked, show error message and exit the method
                    MessageBox.Show("Slot already booked! Please choose another slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return; // Exit the method
                }

                // Insert the token if the slot is available
                if (InsertToken(to))
                {

                    string insertQuery = "INSERT INTO SlotTable (slot, TokenID, vehicalNumber) VALUES (@slot, @TokenID, @vehicalNumber)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@slot", slot);
                    insertCmd.Parameters.AddWithValue("@TokenID", GenerateID);
                    insertCmd.Parameters.AddWithValue("@vehicalNumber", vehicalNumber);


                    if (con.State == ConnectionState.Open)
                    {
                        insertCmd.ExecuteNonQuery();
                        MessageBox.Show("Slot successfully booked!", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Error in database connection!", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Error: Failed to insert token.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        public void ShowAllToken(int t)
        {
            try
            {
                /*if (t < 0 || t >= token.Length || token[t] == null)
                {
                    MessageBox.Show("Invalid token index or token is null", "Error", MessageBoxButtons.OKCancel);
                    return;
                }*/

                TokenPrice = token[t].Price;
                string Price = TokenPrice.ToString();
                string duration = token[t].Duration1.ToString(); // Get the Duration from the token
                Phone = PhoneNumber;

                // Include Duration in the query
                string query2 = "INSERT INTO ParkingDetails VALUES ('" + Name + "','" + Nid + "','" + Phone + "','" + vehicalNumber + "','" + GenerateID1 + "','" + Price + "','" + duration + "')";

                SqlCommand cmd1 = new SqlCommand(query2, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd1.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered", "Serra", MessageBoxButtons.OKCancel);
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!\n" + ex.ToString(), "Inside Clerk!", MessageBoxButtons.OKCancel);
            }
        }
    }
}
