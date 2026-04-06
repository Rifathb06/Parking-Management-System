using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ParkingManagmentSystem
{

    public partial class BookParking : UserControl
    {
        private string userID;
        private float Duration;
        Customer customer = new Customer();
        Customer_Form CF = new Customer_Form();


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");


        public float Amount { get; set; }


        public BookParking()
        {
            InitializeComponent();
        }

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private void BookParking_Load(object sender, EventArgs e)
        {
            textBox_CustomerName.Hide();
            textBox_CustomerID.Hide();
            textBox_PhoneNumber.Hide();
            // Check if essential details are entered
            BookParking_Load();


        }

        private void BookParking_Load()
        {
            textBox_CustomerName.Hide();
            textBox_CustomerID.Hide();
            textBox_PhoneNumber.Hide();
            string query1 = "Select TokenID from SlotTable where slot='" + 1 + "'";
            string query2 = "Select TokenID from SlotTable where slot='" + 2 + "'";
            string query3 = "Select TokenID from SlotTable where slot='" + 3 + "'";
            string query4 = "Select TokenID from SlotTable where slot='" + 4 + "'";
            string query5 = "Select TokenID from SlotTable where slot='" + 5 + "'";
            string query6 = "Select TokenID from SlotTable where slot='" + 6 + "'";
            string query7 = "Select TokenID from SlotTable where slot='" + 7 + "'";
            string query8 = "Select TokenID from SlotTable where slot='" + 8 + "'";
            string query9 = "SELECT TokenID FROM SlotTable WHERE Slot='" + 9 + "'";
            string query10 = "Select TokenID from SlotTable where slot='" + 10 + "'";
            string query11 = "Select TokenID from SlotTable where slot='" + 11 + "'";
            string query12 = "Select TokenID from SlotTable where slot='" + 12 + "'";
            string query13 = "Select TokenID from SlotTable where slot='" + 13 + "'";
            string query14 = "Select TokenID from SlotTable where slot='" + 14 + "'";
            string query15 = "Select TokenID from SlotTable where slot='" + 15 + "'";
            string query16 = "Select TokenID from SlotTable where slot='" + 16 + "'";
            string query17 = "Select TokenID from SlotTable where slot='" + 17 + "'";
            string query18 = "Select TokenID from SlotTable where slot='" + 18 + "'";
            string query19 = "Select TokenID from SlotTable where slot='" + 19 + "'";
            string query20 = "Select TokenID from SlotTable where slot='" + 20 + "'";
            string query21 = "Select TokenID from SlotTable where slot='" + 21 + "'";
            string query22 = "Select TokenID from SlotTable where slot='" + 22 + "'";
            string query23 = "Select TokenID from SlotTable where slot='" + 23 + "'";
            string query24 = "Select TokenID from SlotTable where slot='" + 24 + "'";
            string query25 = "Select TokenID from SlotTable where slot='" + 25 + "'";
            string query26 = "Select TokenID from SlotTable where slot='" + 26 + "'";
            string query27 = "Select TokenID from SlotTable where slot='" + 27 + "'";
            string query28 = "Select TokenID from SlotTable where slot='" + 28 + "'";
            string query29 = "Select TokenID from SlotTable where slot='" + 29 + "'";
            string query30 = "Select TokenID from SlotTable where slot='" + 30 + "'";
            string query31 = "Select TokenID from SlotTable where slot='" + 31 + "'";
            string query32 = "Select TokenID from SlotTable where slot='" + 32 + "'";
            string query33 = "Select TokenID from SlotTable where slot='" + 33 + "'";
            string query34 = "Select TokenID from SlotTable where slot='" + 34 + "'";
            string query35 = "Select TokenID from SlotTable where slot='" + 35 + "'";
            string query36 = "Select TokenID from SlotTable where slot='" + 36 + "'";



            //string u = log.UserID1;
            // con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                SqlCommand cmd25 = new SqlCommand(query25, con);
                SqlCommand cmd26 = new SqlCommand(query26, con);
                SqlCommand cmd27 = new SqlCommand(query27, con);
                SqlCommand cmd28 = new SqlCommand(query28, con);
                SqlCommand cmd29 = new SqlCommand(query29, con);
                SqlCommand cmd30 = new SqlCommand(query30, con);
                SqlCommand cmd31 = new SqlCommand(query31, con);
                SqlCommand cmd32 = new SqlCommand(query32, con);
                SqlCommand cmd33 = new SqlCommand(query33, con);
                SqlCommand cmd34 = new SqlCommand(query34, con);
                SqlCommand cmd35 = new SqlCommand(query35, con);
                SqlCommand cmd36 = new SqlCommand(query36, con);

                if (cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.FillColor = System.Drawing.Color.Teal;

                }
                else
                {
                    button_SLOT1.FillColor = System.Drawing.Color.White;
                }
                con.Close();


                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT2.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT3.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT4.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT5.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT6.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT7.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT8.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT9.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT10.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT11.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT12.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT13.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT14.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT15.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT16.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT17.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT18.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT19.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT20.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT21.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT22.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT23.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button_SLOT24.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT24.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd25.ExecuteReader().HasRows)
                {
                    button_SLOT25.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT25.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd26.ExecuteReader().HasRows)
                {
                    button_SLOT26.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT26.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd27.ExecuteReader().HasRows)
                {
                    button_SLOT27.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT27.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd28.ExecuteReader().HasRows)
                {
                    button_SLOT28.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT28.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd29.ExecuteReader().HasRows)
                {
                    button_SLOT29.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT29.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd30.ExecuteReader().HasRows)
                {
                    button_SLOT30.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT30.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd31.ExecuteReader().HasRows)
                {
                    button_SLOT31.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT31.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd32.ExecuteReader().HasRows)
                {
                    button_SLOT32.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT32.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd33.ExecuteReader().HasRows)
                {
                    button_SLOT33.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT33.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd34.ExecuteReader().HasRows)
                {
                    button_SLOT34.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT34.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd35.ExecuteReader().HasRows)
                {
                    button_SLOT35.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT35.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd36.ExecuteReader().HasRows)
                {
                    button_SLOT36.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT36.FillColor = System.Drawing.Color.White;
                }
                con.Close();


            }
            else if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlCommand cmd4 = new SqlCommand(query4, con);
                SqlCommand cmd5 = new SqlCommand(query5, con);
                SqlCommand cmd6 = new SqlCommand(query6, con);
                SqlCommand cmd7 = new SqlCommand(query7, con);
                SqlCommand cmd8 = new SqlCommand(query8, con);
                SqlCommand cmd9 = new SqlCommand(query9, con);
                SqlCommand cmd10 = new SqlCommand(query10, con);
                SqlCommand cmd11 = new SqlCommand(query11, con);
                SqlCommand cmd12 = new SqlCommand(query12, con);
                SqlCommand cmd13 = new SqlCommand(query13, con);
                SqlCommand cmd14 = new SqlCommand(query14, con);
                SqlCommand cmd15 = new SqlCommand(query15, con);
                SqlCommand cmd16 = new SqlCommand(query16, con);
                SqlCommand cmd17 = new SqlCommand(query17, con);
                SqlCommand cmd18 = new SqlCommand(query18, con);
                SqlCommand cmd19 = new SqlCommand(query19, con);
                SqlCommand cmd20 = new SqlCommand(query20, con);
                SqlCommand cmd21 = new SqlCommand(query21, con);
                SqlCommand cmd22 = new SqlCommand(query22, con);
                SqlCommand cmd23 = new SqlCommand(query23, con);
                SqlCommand cmd24 = new SqlCommand(query24, con);
                SqlCommand cmd25 = new SqlCommand(query25, con);
                SqlCommand cmd26 = new SqlCommand(query26, con);
                SqlCommand cmd27 = new SqlCommand(query27, con);
                SqlCommand cmd28 = new SqlCommand(query28, con);
                SqlCommand cmd29 = new SqlCommand(query29, con);
                SqlCommand cmd30 = new SqlCommand(query30, con);
                SqlCommand cmd31 = new SqlCommand(query31, con);
                SqlCommand cmd32 = new SqlCommand(query32, con);
                SqlCommand cmd33 = new SqlCommand(query33, con);
                SqlCommand cmd34 = new SqlCommand(query34, con);
                SqlCommand cmd35 = new SqlCommand(query35, con);
                SqlCommand cmd36 = new SqlCommand(query36, con);
                if (cmd1.ExecuteReader().HasRows)
                {
                    button_SLOT1.FillColor = System.Drawing.Color.Teal;

                }
                else
                {
                    button_SLOT1.FillColor = System.Drawing.Color.White;
                }
                con.Close();


                con.Open();
                if (cmd2.ExecuteReader().HasRows)
                {
                    button_SLOT2.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT2.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd3.ExecuteReader().HasRows)
                {
                    button_SLOT3.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT3.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd4.ExecuteReader().HasRows)
                {
                    button_SLOT4.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT4.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd5.ExecuteReader().HasRows)
                {
                    button_SLOT5.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT5.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd6.ExecuteReader().HasRows)
                {
                    button_SLOT6.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT6.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd7.ExecuteReader().HasRows)
                {
                    button_SLOT7.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT7.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd8.ExecuteReader().HasRows)
                {
                    button_SLOT8.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT8.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd9.ExecuteReader().HasRows)
                {
                    button_SLOT9.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT9.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd10.ExecuteReader().HasRows)
                {
                    button_SLOT10.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT10.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd11.ExecuteReader().HasRows)
                {
                    button_SLOT11.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT11.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd12.ExecuteReader().HasRows)
                {
                    button_SLOT12.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT12.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd13.ExecuteReader().HasRows)
                {
                    button_SLOT13.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT13.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd14.ExecuteReader().HasRows)
                {
                    button_SLOT14.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT14.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd15.ExecuteReader().HasRows)
                {
                    button_SLOT15.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT15.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd16.ExecuteReader().HasRows)
                {
                    button_SLOT16.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT16.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd17.ExecuteReader().HasRows)
                {
                    button_SLOT17.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT17.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd18.ExecuteReader().HasRows)
                {
                    button_SLOT18.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT18.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd19.ExecuteReader().HasRows)
                {
                    button_SLOT19.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT19.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd20.ExecuteReader().HasRows)
                {
                    button_SLOT20.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT20.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd21.ExecuteReader().HasRows)
                {
                    button_SLOT21.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT21.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd22.ExecuteReader().HasRows)
                {
                    button_SLOT22.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT22.FillColor = System.Drawing.Color.White;
                }
                con.Close();
                con.Open();
                if (cmd23.ExecuteReader().HasRows)
                {
                    button_SLOT23.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT23.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd24.ExecuteReader().HasRows)
                {
                    button_SLOT24.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT24.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd25.ExecuteReader().HasRows)
                {
                    button_SLOT25.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT25.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd26.ExecuteReader().HasRows)
                {
                    button_SLOT26.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT26.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd27.ExecuteReader().HasRows)
                {
                    button_SLOT27.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT27.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd28.ExecuteReader().HasRows)
                {
                    button_SLOT28.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT28.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd29.ExecuteReader().HasRows)
                {
                    button_SLOT29.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT29.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd30.ExecuteReader().HasRows)
                {
                    button_SLOT30.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT30.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd31.ExecuteReader().HasRows)
                {
                    button_SLOT31.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT31.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd32.ExecuteReader().HasRows)
                {
                    button_SLOT32.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT32.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd33.ExecuteReader().HasRows)
                {
                    button_SLOT33.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT33.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd34.ExecuteReader().HasRows)
                {
                    button_SLOT34.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT34.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd35.ExecuteReader().HasRows)
                {
                    button_SLOT35.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT35.FillColor = System.Drawing.Color.White;
                }
                con.Close();

                con.Open();
                if (cmd36.ExecuteReader().HasRows)
                {
                    button_SLOT36.FillColor = System.Drawing.Color.Teal;
                }
                else
                {
                    button_SLOT36.FillColor = System.Drawing.Color.White;
                }
                con.Close();


            }
            else
            {
                MessageBox.Show("Connection Error!", "Error", MessageBoxButtons.OKCancel);
            }

        }

        private void button_Book_Click(object sender, EventArgs e)
        {
            if (textBox_SlotNumber.Text == "" || textBox_VehicleNumber.Text == "" || textBox_Duration.Text == "")
            {
                MessageBox.Show("Please Enter your Details", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit if required fields are empty
            }
            else
            {
                try
                {
                    // Open the database connection
                    con.Open();

                    // Query to fetch Name, Nid, and Phone using the UserID
                    string query = "SELECT Name, NID, PhoneNumber FROM CustomerTable WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", userID); // Assuming userID is already set in this scope

                    // Execute the command and read the data
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Fetch data from the query result
                        string name = reader["Name"].ToString();
                        string nid = reader["NID"].ToString();
                        string phone = reader["PhoneNumber"].ToString();

                        // Assign the fetched data to the corresponding UI elements
                        textBox_CustomerName.Text = name;
                        textBox_CustomerID.Text = nid;
                        textBox_PhoneNumber.Text = phone;

                        // Optionally, assign these values to local variables if needed
                        customer = new Customer(); // Assuming you are using a Clerk object
                        customer.Name = name;
                        customer.Nid1 = int.Parse(nid); // Convert to integer as Nid is likely numeric
                        customer.Phone = phone;
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided UserID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    reader.Close(); // Close the reader after fetching data

                    // Continue with your existing logic to process the booking
                    string slot = textBox_SlotNumber.Text;
                    string vehicleNo = textBox_VehicleNumber.Text;
                    int Slot = int.Parse(slot);
                    string duration = textBox_Duration.Text;

                    customer.Slot = Slot;
                    customer.VehicalNumber = vehicleNo;

                    Duration = float.Parse(duration); // Assuming Duration is a float value
                    customer.Duration1 = Duration;

                    // Show print button

                    // Token operation
                    customer.TokenOperation();

                    // Calculate price based on duration
                    float duration1 = float.Parse(textBox_Duration.Text);
                    float price11 = duration1 * 150; // Assuming 150 is the rate
                    textBox_Amount.Text = price11.ToString();
                    this.Amount = price11;

                    // Hide or show buttons based on user type (e.g., Clerk, Customer)


                    if (!string.IsNullOrEmpty(userID))
                    {
                        MessageBox.Show("Booking slot for UserID: " + userID);
                        // Perform booking operation using the UserID
                    }
                    else
                    {
                        MessageBox.Show("UserID is not set!");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numerical values for ID, Phone Number, and Duration.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure that the connection is closed even if an error occurs
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string TokenPrice = customer.TokenPrice1.ToString();
            string TokenID = customer.GenerateID1;
            string SlotNumber = textBox_SlotNumber.Text;
            //e.Graphics.BackgroundImage();
            e.Graphics.DrawString("------------------- Parking Token -------------------", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("Slot Number:- " + SlotNumber, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 50));
            e.Graphics.DrawString("Token Price:- " + TokenPrice, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 100));
            e.Graphics.DrawString("Token ID:- " + TokenID, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 150));

            e.Graphics.DrawString("Paid by bKash", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 250));

        }
        public void PerformPrint()
        {
            try
            {
                string slot = textBox_SlotNumber.Text;
                int Slot = int.Parse(slot);
                string text = textBox_PhoneNumber.Text;
                customer.PhoneNumber = text;
                customer.ShowAllToken(Slot);
                string TokenPrice = customer.TokenPrice1.ToString();

                PrintDialog printD1 = new PrintDialog();
                printD1.Document = printDocument1;
                DialogResult result = printD1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    printDocument1.Print();
                }

                // Clear the input fields and reset UI
                textBox_Duration.Text = "";
                textBox_VehicleNumber.Text = "";
                textBox_SlotNumber.Text = "";
                textBox_Amount.Text = "";



                BookParking_Load(); // Reload the UI
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
        private void button_Print_Click(object sender, EventArgs e)
        {
            Payment_Form paymentForm = new Payment_Form(this); // Pass current BookParking instance
            paymentForm.Show();
            this.Hide();

        }

        private void textBox_CustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_CustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_VehicleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Duration_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_SlotNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Amount_TextChanged(object sender, EventArgs e)
        {

        }


        private void button_SLOT1_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "1";
            button_SLOT1.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT2_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "2";
            button_SLOT2.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT3_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "3";
            button_SLOT3.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT4_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "4";
            button_SLOT4.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT5_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "5";
            button_SLOT5.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT6_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "6";
            button_SLOT6.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT7_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "7";
            button_SLOT7.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT8_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "8";
            button_SLOT8.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT9_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "9";
            button_SLOT9.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT10_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "10";
            button_SLOT10.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT11_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "11";
            button_SLOT11.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT12_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "12";
            button_SLOT12.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT13_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "13";
            button_SLOT13.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT14_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "14";
            button_SLOT14.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT15_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "15";
            button_SLOT15.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT16_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "16";
            button_SLOT16.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT17_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "17";
            button_SLOT17.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT18_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "18";
            button_SLOT18.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT19_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "19";
            button_SLOT19.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT20_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "20";
            button_SLOT20.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT21_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "21";
            button_SLOT21.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT22_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "22";
            button_SLOT22.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT23_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "23";
            button_SLOT23.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT24_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "24";
            button_SLOT24.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT25_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "25";
            button_SLOT25.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT26_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "26";
            button_SLOT26.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT27_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "27";
            button_SLOT27.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT28_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "28";
            button_SLOT28.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT29_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "29";
            button_SLOT29.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT30_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "30";
            button_SLOT30.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT31_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "31";
            button_SLOT31.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT32_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "32";
            button_SLOT32.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT33_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "33";
            button_SLOT33.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT34_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "34";
            button_SLOT34.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT35_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "35";
            button_SLOT35.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_SLOT36_Click(object sender, EventArgs e)
        {
            textBox_SlotNumber.Text = "36";
            button_SLOT36.FillColor = System.Drawing.Color.Teal;
            BookParking_Load();
        }

        private void button_Payment_Click(object sender, EventArgs e)
        {
            Payment_Form paymentForm = new Payment_Form(this); // Pass the current instance of BookParking
            paymentForm.Show();
            this.Hide();

        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Duration.Text = "";
            textBox_VehicleNumber.Text = "";

            textBox_SlotNumber.Text = "";
            textBox_Duration.Text = "";
            textBox_Amount.Text = "";
        }
    }
}
