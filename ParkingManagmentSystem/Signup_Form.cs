using Microsoft.Win32;
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
    public partial class Signup_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        Manager m= new Manager();
        Clerk c = new Clerk();
        Customer customer= new Customer();
        Checker checker = new Checker();
        public Signup_Form()
        {
            InitializeComponent();
        }

        private void label_Back_to_login_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }

        private void radioButton_Customer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Clerk_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_TokenChecker_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_Manager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassLOGIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassLOGIN.Checked == true)
            {

                textBox_Password.UseSystemPasswordChar = false;
                textBox_ConfirmPassword.UseSystemPasswordChar = false;


            }
            else
            {

                textBox_Password.UseSystemPasswordChar = true;
                textBox_ConfirmPassword.UseSystemPasswordChar = true;


            }
        }

        private void textBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_NID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GeneratedUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Signup_Click(object sender, EventArgs e)
        {
            bool registrationSucceeded = false;
                if (textBox_Name.Text == "")
                {
                    MessageBox.Show("Please Insert your Name", "Name Missing Error!", MessageBoxButtons.OKCancel);
                }
                else
                {
                    if (radioButton_Manager.Checked == true)
                    {
                        if (textBox_NID.TextLength != 8)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_phone.TextLength != 11)
                        {
                            MessageBox.Show("Please Correct your Phone Number", "Phone Number Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                        {
                            MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Password did not match!\n Try Again!", "Password Error!");
                        }
                        else
                        {
                            try
                            {
                                string name = textBox_Name.Text;
                                string phone = textBox_phone.Text;
                                string position = "MANAGER";
                                string pas = textBox_Password.Text;
                                float salary = 15000;
                                string nid = textBox_NID.Text;
                                if (!int.TryParse(nid, out int Nid))
                                {
                                    MessageBox.Show("NID must be numeric", "NID Error!", MessageBoxButtons.OKCancel);
                                    return;
                                }
                                string GeneratedID = name.Substring(0, 2) + position + nid.Substring(2, 3);
                                textBox_GeneratedUserID.Text = GeneratedID;
                                m = new Manager(name, Nid, phone, GeneratedID, pas, position, salary);
                                registrationSucceeded = true;
                            }
                            catch
                            {
                                MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                            }
                        }
                    }
                    else if (radioButton_Clerk.Checked == true)
                    {
                        if (textBox_NID.TextLength != 8)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_phone.TextLength != 11)
                        {
                            MessageBox.Show("Please Correct your Phone Number", "Phone Number Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                        {
                            MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Password did not match!\n Try Again!", "Password Error!");
                        }
                        else
                        {
                            try
                            {
                                string name = textBox_Name.Text;
                                string phone = textBox_phone.Text;
                                string position = "CLERK";
                                string pas = textBox_Password.Text;
                                float salary = 8000;
                                string nid = textBox_NID.Text;
                                if (!int.TryParse(nid, out int Nid))
                                {
                                    MessageBox.Show("NID must be numeric", "NID Error!", MessageBoxButtons.OKCancel);
                                    return;
                                }
                                string GeneratedID = name.Substring(0, 2) + position + nid.Substring(2, 3);
                                textBox_GeneratedUserID.Text = GeneratedID;
                                c = new Clerk(name, Nid, phone, GeneratedID, pas, position, salary);
                                registrationSucceeded = true;
                            }
                            catch
                            {
                                MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                            }
                        }
                    }
                    else if (radioButton_TokenChecker.Checked == true)
                    {
                        if (textBox_NID.TextLength != 8)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_phone.TextLength != 11)
                        {
                            MessageBox.Show("Please Correct your Phone Number", "Phone Number Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                        {
                            MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Password did not match!\n Try Again!", "Password Error!");
                        }
                        else
                        {
                            try
                            {
                                string name = textBox_Name.Text;
                                string phone = textBox_phone.Text;
                                string position = "CHECKER";
                                string pas = textBox_Password.Text;
                                float salary = 5000;
                                string nid = textBox_NID.Text;
                                if (!int.TryParse(nid, out int Nid))
                                {
                                    MessageBox.Show("NID must be numeric", "NID Error!", MessageBoxButtons.OKCancel);
                                    return;
                                }
                                string GeneratedID = name.Substring(0, 2) + position + nid.Substring(2, 3);
                                textBox_GeneratedUserID.Text = GeneratedID;
                                checker = new Checker(name, Nid, phone, GeneratedID, pas, position, salary);
                                registrationSucceeded = true;
                            }
                            catch
                            {
                                MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                            }
                        }
                    }
                    else if (radioButton_Customer.Checked == true)
                    {
                        if (textBox_NID.TextLength != 8)
                        {
                            MessageBox.Show("Please Correct your NID", "NID Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_phone.TextLength != 11)
                        {
                            MessageBox.Show("Please Correct your Phone Number", "Phone Number Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_ConfirmPassword.Text == "" && textBox_Password.Text == "")
                        {
                            MessageBox.Show("Set Your Password", "Password Error!", MessageBoxButtons.OKCancel);
                        }
                        else if (textBox_Password.Text != textBox_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Password did not match!\n Try Again!", "Password Error!");
                        }
                        else
                        {
                            try
                            {
                                string name = textBox_Name.Text;
                                string phone = textBox_phone.Text;
                                string position = "CUSTOMER";
                                string pas = textBox_Password.Text;
                                string nid = textBox_NID.Text;
                                if (!int.TryParse(nid, out int Nid))
                                {
                                    MessageBox.Show("NID must be numeric", "NID Error!", MessageBoxButtons.OKCancel);
                                    return;
                                }
                                string GeneratedID = name.Substring(0, 2) + position + nid.Substring(2, 3);
                                textBox_GeneratedUserID.Text = GeneratedID;
                                customer = new Customer(name, Nid, phone, GeneratedID, pas);
                                registrationSucceeded = true;
                            }
                            catch
                            {
                                MessageBox.Show("Error\nTry Again!!", "Error!", MessageBoxButtons.OKCancel);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("      Select your position", "Error!", MessageBoxButtons.OKCancel);
                    }
                }
            if (registrationSucceeded)
            {
                textBox_Name.Text = "";
                textBox_NID.Text = "";
                textBox_phone.Text = "";
                textBox_Password.Text = "";
                textBox_ConfirmPassword.Text = "";
            }
        }

        private void Signup_Form_Load(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM EmpTable WHERE position='MANAGER'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int managerCount = (int)cmd.ExecuteScalar();
            if (managerCount > 0)
            {
                radioButton_Manager.Enabled = false;
                radioButton_Manager.Hide();
                MessageBox.Show("     Welcome to the Parking Zone\n", "Manager", MessageBoxButtons.OKCancel);
            }
            else
            {
                radioButton_Manager.Enabled = true;
            }
            con.Close();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_Name.Text = "";
            textBox_NID.Text = "";
            textBox_phone.Text = "";
            textBox_Password.Text = "";
            textBox_ConfirmPassword.Text = "";
            textBox_GeneratedUserID.Text = "";
            radioButton_Clerk.Checked = false;
            radioButton_Manager.Checked = false;
            radioButton_TokenChecker.Checked = false;
            radioButton_Customer.Checked = false;
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
