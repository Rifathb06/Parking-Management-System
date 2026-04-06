using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class RegisterSlot : UserControl
    {

        Clerk cl = new Clerk();
        Clerk_Form clerk_Form;
        Customer customer;
        string ClerkName;
        string UserID;
        float Duration;
        Clerk_Form log;
        public string UserType { get; set; }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        /*float duration1 = float.Parse(textBox_Duration.Text);
        float price11 = duration1 * 50;
        string result = price11.ToString(); ;
        textBox_Amount.Text = result;*/
        public RegisterSlot()
        {
            InitializeComponent();
        }



        private void button_Book_Click(object sender, EventArgs e)
        {
            if (textBox_CustomerName.Text == "" || textBox_CustomerID.Text == "" || textBox_SlotNumber.Text == "" || textBox_VehicleNumber.Text == "" || textBox_Duration.Text == "")
            {
                MessageBox.Show("Please Enter your Details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    // Fetch inputs from text boxes within this user control
                    string nid = textBox_CustomerID.Text;
                    string slot = textBox_SlotNumber.Text;
                    string vehicleNo = textBox_VehicleNumber.Text;
                    int Nid = int.Parse(nid);
                    int Slot = int.Parse(slot);
                    string duration = textBox_Duration.Text;


                    cl = new Clerk();
                    cl.Name = textBox_CustomerName.Text;
                    cl.Nid1 = Nid;
                    cl.Slot = Slot;


                    cl.VehicalNumber = vehicleNo;



                    Duration = float.Parse(duration);
                    // radioButton_SuperToken.Checked = false;
                    //cl.Ttype1 = "NORMAL";
                    cl.Duration1 = Duration;

                    button_Print.Visible = true;
                    cl.TokenOperation();

                    // Calculate the price based on duration
                    float duration1 = float.Parse(textBox_Duration.Text);
                    float price11 = duration1 * 150; // Assume 150 is the rate
                    textBox_Amount.Text = price11.ToString();

                    // Branch the logic based on the UserType

                    // Adjust UI for Clerk
                    button_Remove.Hide();
                    button_Remove.SendToBack();
                    
                    //button_Print.Visible = true;    // Show print button for clerks
                    button_Print.Show();
                    button_Print.BringToFront();    // Bring print button to the front
                    button_Print.BringToFront();    // Bring print button to the front
                                                    //button_Remove.Visible = false;  // Hide/remove button for clerks
                                                    //button_Payment.Visible = false; // Hide payment button for clerks


                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numerical values for ID, Phone Number, and Duration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            //RegisterSlot_Load();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string TokenPrice = cl.TokenPrice1.ToString();
            string TokenID = cl.GenerateID1;
            string SlotNumber = textBox_SlotNumber.Text;
            //e.Graphics.BackgroundImage();
            e.Graphics.DrawString("------------------- Parking Token -------------------", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Slot Number:- " + SlotNumber, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 50));
            e.Graphics.DrawString("Token Price:- " + TokenPrice, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString("Token ID:- " + TokenID, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 150));

            e.Graphics.DrawString("Paid", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 250));

        }

        private void button_Print_Click(object sender, EventArgs e)
        {

            try
            {



                string slot = textBox_SlotNumber.Text;
                int Slot = int.Parse(slot);
                string text = textBox_PhoneNumber.Text;
                cl.PhoneNumber = text;
                cl.ShowAllToken(Slot);
                string TokenPrice = cl.TokenPrice1.ToString();
                // MessageBox.Show(TokenPrice, "Amount", MessageBoxButtons.OKCancel);
                PrintDialog printD1 = new PrintDialog();
                printD1.Document = printDocument1;
                DialogResult result = printD1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }

                // Clear the input fields and reset UI
                textBox_CustomerID.Text = "";
                textBox_CustomerName.Text = "";
                textBox_Duration.Text = "";
                textBox_VehicleNumber.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_SlotNumber.Text = "";
                textBox_Amount.Text = "";

                button_Print.Hide();
                button_Remove.Show();
                button_Remove.BringToFront();

                RegisterSlot_Load(); // Load the register slot UI again
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numerical values for the slot.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        private void textBox_Duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_VehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SlotNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void RegisterSlot_Load(object sender, EventArgs e)
        {
            button_Print.Hide();
            button_Print.SendToBack();
            button_Remove.Show();
            button_Remove.Visible = true;
            button_Remove.BringToFront();
            RefreshSlotColors();
        }
        // Helper: loads slot button colors using a single DB query (fixes duplicate cmd2 and missing White resets)
        private void RefreshSlotColors()
        {
            var bookedSlots = new System.Collections.Generic.HashSet<int>();
            try
            {
                string query = "SELECT slot FROM SlotTable";
                if (con.State == ConnectionState.Closed) con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (int.TryParse(reader["slot"].ToString(), out int s))
                            bookedSlots.Add(s);
                    }
                }
            }
            catch { /* connection issue handled below */ }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }

            var slotButtons = new Guna.UI2.WinForms.Guna2Button[]
            {
                button_SLOT1,  button_SLOT2,  button_SLOT3,  button_SLOT4,  button_SLOT5,  button_SLOT6,
                button_SLOT7,  button_SLOT8,  button_SLOT9,  button_SLOT10, button_SLOT11, button_SLOT12,
                button_SLOT13, button_SLOT14, button_SLOT15, button_SLOT16, button_SLOT17, button_SLOT18,
                button_SLOT19, button_SLOT20, button_SLOT21, button_SLOT22, button_SLOT23, button_SLOT24,
                button_SLOT25, button_SLOT26, button_SLOT27, button_SLOT28, button_SLOT29, button_SLOT30,
                button_SLOT31, button_SLOT32, button_SLOT33, button_SLOT34, button_SLOT35, button_SLOT36
            };

            for (int i = 0; i < slotButtons.Length; i++)
            {
                slotButtons[i].FillColor = bookedSlots.Contains(i + 1)
                    ? System.Drawing.Color.Teal
                    : System.Drawing.Color.White;
            }
        }


        private void RegisterSlot_Load()
        {
            button_Print.Hide();
            button_Print.SendToBack();
            button_Remove.Show();
            button_Remove.Visible = true;
            button_Remove.BringToFront();
            RefreshSlotColors();
        }

        private void button_SLOT1_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "1";
            button_SLOT1.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT2_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "2";
            button_SLOT2.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT3_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "3";
            button_SLOT3.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT4_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "4";
            button_SLOT4.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT5_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "5";
            button_SLOT5.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT6_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "6";
            button_SLOT6.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT7_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "7";
            button_SLOT7.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT8_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "8";
            button_SLOT8.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT9_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "9";
            button_SLOT9.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT10_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "10";
            button_SLOT10.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT11_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "11";
            button_SLOT11.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT12_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "12";
            button_SLOT12.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT13_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "13";
            button_SLOT13.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT14_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "14";
            button_SLOT14.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT15_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "15";
            button_SLOT15.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT16_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "16";
            button_SLOT16.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT17_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "17";
            button_SLOT17.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT18_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "18";
            button_SLOT18.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT19_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "19";
            button_SLOT19.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT20_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "20";
            button_SLOT20.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT21_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "21";
            button_SLOT21.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT22_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "22";
            button_SLOT22.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT23_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "23";
            button_SLOT23.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT24_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "24";
            button_SLOT24.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT25_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "25";
            button_SLOT25.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT26_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "26";
            button_SLOT26.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT27_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "27";
            button_SLOT27.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT28_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "28";
            button_SLOT28.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT29_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "29";
            button_SLOT29.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT30_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "30";
            button_SLOT30.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT31_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "31";
            button_SLOT31.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT32_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "32";
            button_SLOT32.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT33_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "33";
            button_SLOT33.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT34_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "34";
            button_SLOT34.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT35_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "35";
            button_SLOT35.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_SLOT36_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "36";
            button_SLOT36.FillColor = System.Drawing.Color.Teal;
            RegisterSlot_Load();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM SlotTable WHERE Slot='" + 1 + "'";
            string query2 = "DELETE FROM SlotTable WHERE Slot='" + 2 + "'";
            string query3 = "DELETE FROM SlotTable WHERE Slot='" + 3 + "'";
            string query4 = "DELETE FROM SlotTable WHERE Slot='" + 4 + "'";
            string query5 = "DELETE FROM SlotTable WHERE Slot='" + 5 + "'";
            string query6 = "DELETE FROM SlotTable WHERE Slot='" + 6 + "'";
            string query7 = "DELETE FROM SlotTable WHERE Slot='" + 7 + "'";
            string query8 = "DELETE FROM SlotTable WHERE Slot='" + 8 + "'";
            string query9 = "DELETE FROM SlotTable WHERE Slot='" + 9 + "'";
            string query10 = "DELETE FROM SlotTable WHERE Slot='" + 10 + "'";
            string query11 = "DELETE FROM SlotTable WHERE Slot='" + 11 + "'";
            string query12 = "DELETE FROM SlotTable WHERE Slot='" + 12 + "'";
            string query13 = "DELETE FROM SlotTable WHERE Slot='" + 13 + "'";
            string query14 = "DELETE FROM SlotTable WHERE Slot='" + 14 + "'";
            string query15 = "DELETE FROM SlotTable WHERE Slot='" + 15 + "'";
            string query16 = "DELETE FROM SlotTable WHERE Slot='" + 16 + "'";
            string query17 = "DELETE FROM SlotTable WHERE Slot='" + 17 + "'";
            string query18 = "DELETE FROM SlotTable WHERE Slot='" + 18 + "'";
            string query19 = "DELETE FROM SlotTable WHERE Slot='" + 19 + "'";
            string query20 = "DELETE FROM SlotTable WHERE Slot='" + 20 + "'";
            string query21 = "DELETE FROM SlotTable WHERE Slot='" + 21 + "'";
            string query22 = "DELETE FROM SlotTable WHERE Slot='" + 22 + "'";
            string query23 = "DELETE FROM SlotTable WHERE Slot='" + 23 + "'";
            string query24 = "DELETE FROM SlotTable WHERE Slot='" + 24 + "'";
            string query25 = "DELETE FROM SlotTable WHERE Slot='" + 25 + "'";
            string query26 = "DELETE FROM SlotTable WHERE Slot='" + 26 + "'";
            string query27 = "DELETE FROM SlotTable WHERE Slot='" + 27 + "'";
            string query28 = "DELETE FROM SlotTable WHERE Slot='" + 28 + "'";
            string query29 = "DELETE FROM SlotTable WHERE Slot='" + 29 + "'";
            string query30 = "DELETE FROM SlotTable WHERE Slot='" + 30 + "'";
            string query31 = "DELETE FROM SlotTable WHERE Slot='" + 31 + "'";
            string query32 = "DELETE FROM SlotTable WHERE Slot='" + 32 + "'";
            string query33 = "DELETE FROM SlotTable WHERE Slot='" + 33 + "'";
            string query34 = "DELETE FROM SlotTable WHERE Slot='" + 34 + "'";
            string query35 = "DELETE FROM SlotTable WHERE Slot='" + 35 + "'";
            string query36 = "DELETE FROM SlotTable WHERE Slot='" + 36 + "'";
            if (con.State == ConnectionState.Open)
            {

                if (textBox_SlotNumber.Text == "1")
                {
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT1.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "2")
                {
                    SqlCommand cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT2.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "3")
                {
                    SqlCommand cmd = new SqlCommand(query3, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT3.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "4")
                {
                    SqlCommand cmd = new SqlCommand(query4, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT4.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "5")
                {
                    SqlCommand cmd = new SqlCommand(query5, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT5.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "6")
                {
                    SqlCommand cmd = new SqlCommand(query6, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT6.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "7")
                {
                    SqlCommand cmd = new SqlCommand(query7, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT7.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "8")
                {
                    SqlCommand cmd = new SqlCommand(query8, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT8.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "9")
                {
                    SqlCommand cmd = new SqlCommand(query9, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT9.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "10")
                {
                    SqlCommand cmd = new SqlCommand(query10, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT10.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "11")
                {
                    SqlCommand cmd = new SqlCommand(query11, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT11.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "12")
                {
                    SqlCommand cmd = new SqlCommand(query12, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT12.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "13")
                {
                    SqlCommand cmd = new SqlCommand(query13, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT13.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "14")
                {
                    SqlCommand cmd = new SqlCommand(query14, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT14.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "15")
                {
                    SqlCommand cmd = new SqlCommand(query15, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT15.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "16")
                {
                    SqlCommand cmd = new SqlCommand(query16, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT16.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "17")
                {
                    SqlCommand cmd = new SqlCommand(query17, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT17.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "18")
                {
                    SqlCommand cmd = new SqlCommand(query18, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT18.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "19")
                {
                    SqlCommand cmd = new SqlCommand(query19, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT19.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "20")
                {
                    SqlCommand cmd = new SqlCommand(query20, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT20.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "21")
                {
                    SqlCommand cmd = new SqlCommand(query21, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT21.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "22")
                {
                    SqlCommand cmd = new SqlCommand(query22, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT22.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "23")
                {
                    SqlCommand cmd = new SqlCommand(query23, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT23.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "24")
                {
                    SqlCommand cmd = new SqlCommand(query24, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT24.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "25")
                {
                    SqlCommand cmd = new SqlCommand(query25, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT25.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "26")
                {
                    SqlCommand cmd = new SqlCommand(query26, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT26.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "27")
                {
                    SqlCommand cmd = new SqlCommand(query27, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT27.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "28")
                {
                    SqlCommand cmd = new SqlCommand(query28, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT28.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "29")
                {
                    SqlCommand cmd = new SqlCommand(query29, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT29.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "30")
                {
                    SqlCommand cmd = new SqlCommand(query30, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT30.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "31")
                {
                    SqlCommand cmd = new SqlCommand(query31, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT31.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "32")
                {
                    SqlCommand cmd = new SqlCommand(query32, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT32.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "33")
                {
                    SqlCommand cmd = new SqlCommand(query33, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT33.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "34")
                {
                    SqlCommand cmd = new SqlCommand(query34, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT34.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "35")
                {
                    SqlCommand cmd = new SqlCommand(query35, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT35.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "36")
                {
                    SqlCommand cmd = new SqlCommand(query36, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT36.FillColor = System.Drawing.Color.White;
                }


            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Open();
                if (textBox_SlotNumber.Text == "1")
                {
                    SqlCommand cmd = new SqlCommand(query1, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT1.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "2")
                {
                    SqlCommand cmd = new SqlCommand(query2, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT2.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "3")
                {
                    SqlCommand cmd = new SqlCommand(query3, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT3.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "4")
                {
                    SqlCommand cmd = new SqlCommand(query4, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT4.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "5")
                {
                    SqlCommand cmd = new SqlCommand(query5, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT5.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "6")
                {
                    SqlCommand cmd = new SqlCommand(query6, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT6.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "7")
                {
                    SqlCommand cmd = new SqlCommand(query7, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT7.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "8")
                {
                    SqlCommand cmd = new SqlCommand(query8, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT8.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "9")
                {
                    SqlCommand cmd = new SqlCommand(query9, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT9.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "10")
                {
                    SqlCommand cmd = new SqlCommand(query10, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT10.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "11")
                {
                    SqlCommand cmd = new SqlCommand(query11, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT11.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "12")
                {
                    SqlCommand cmd = new SqlCommand(query12, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT12.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "13")
                {
                    SqlCommand cmd = new SqlCommand(query13, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT13.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "14")
                {
                    SqlCommand cmd = new SqlCommand(query14, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT14.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "15")
                {
                    SqlCommand cmd = new SqlCommand(query15, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT15.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "16")
                {
                    SqlCommand cmd = new SqlCommand(query16, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT16.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "17")
                {
                    SqlCommand cmd = new SqlCommand(query17, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT17.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "18")
                {
                    SqlCommand cmd = new SqlCommand(query18, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT18.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "19")
                {
                    SqlCommand cmd = new SqlCommand(query19, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT19.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "20")
                {
                    SqlCommand cmd = new SqlCommand(query20, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT20.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "21")
                {
                    SqlCommand cmd = new SqlCommand(query21, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT21.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "22")
                {
                    SqlCommand cmd = new SqlCommand(query22, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT22.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "23")
                {
                    SqlCommand cmd = new SqlCommand(query23, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT23.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "24")
                {
                    SqlCommand cmd = new SqlCommand(query24, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT24.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "25")
                {
                    SqlCommand cmd = new SqlCommand(query25, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT25.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "26")
                {
                    SqlCommand cmd = new SqlCommand(query26, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT26.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "27")
                {
                    SqlCommand cmd = new SqlCommand(query27, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT27.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "28")
                {
                    SqlCommand cmd = new SqlCommand(query28, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT28.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "29")
                {
                    SqlCommand cmd = new SqlCommand(query29, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT29.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "30")
                {
                    SqlCommand cmd = new SqlCommand(query30, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT30.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "31")
                {
                    SqlCommand cmd = new SqlCommand(query31, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT31.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "32")
                {
                    SqlCommand cmd = new SqlCommand(query32, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT32.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "33")
                {
                    SqlCommand cmd = new SqlCommand(query33, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT33.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "34")
                {
                    SqlCommand cmd = new SqlCommand(query34, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT34.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "35")
                {
                    SqlCommand cmd = new SqlCommand(query35, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT35.FillColor = System.Drawing.Color.White;
                }
                else if (textBox_SlotNumber.Text == "36")
                {
                    SqlCommand cmd = new SqlCommand(query36, con);
                    cmd.ExecuteNonQuery();
                    textBox_SlotNumber.Clear();
                    button_SLOT36.FillColor = System.Drawing.Color.White;
                }
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
            }

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_CustomerID.Text = "";
            textBox_CustomerName.Text = "";
            textBox_Duration.Text = "";
            textBox_VehicleNumber.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_SlotNumber.Text = "";
            textBox_Duration.Text = "";
            textBox_Amount.Text = "";
        }

        
    }
}
