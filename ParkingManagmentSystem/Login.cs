using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
     class Login
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");
        private string userID;
        private string password;
       
        public Login()
        {
        }

        public Login(string userID, string password)
        {


            this.userID = userID;
            this.password = password;

        }

        public string UserID { get => userID; set => userID = value; }
        public string Password1 { get => password; set => password = value; }

        public bool LoginOp()
        {
            bool flag = false;
            string type = "";

            try
            {
                // Extract the user role directly from the UserID using String.Contains
                if (userID.Contains("MANAGER"))
                {
                    type = "MANAGER";
                }
                else if (userID.Contains("CLERK"))
                {
                    type = "CLERK";
                }
                else if (userID.Contains("CHECKER"))
                {
                    type = "CHECKER";
                }
                else if (userID.Contains("CUSTOMER"))
                {
                    type = "CUSTOMER";
                }
                else
                {
                    MessageBox.Show("Invalid UserID format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return flag;  // Return early if the UserID doesn't match any known roles
                }

                con.Open();
                SqlCommand cmd;

                // Determine if the user is an employee or a customer
                if (type == "MANAGER" || type == "CLERK" || type == "CHECKER")
                {
                    string query1 = "SELECT Position FROM EmpTable WHERE UserID=@userID AND Password=@password";
                    cmd = new SqlCommand(query1, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@password", password);

                    string resultType = cmd.ExecuteScalar() as string;  // Check the result of the query

                    if (resultType == null)
                    {
                        MessageBox.Show("UserID or Password Invalid\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);
                    }
                    else if (resultType == type)
                    {
                        // If credentials match, open the respective form
                        if (type == "CLERK")
                        {
                            new Clerk_Form().Show();
                        }
                        else if (type == "MANAGER")
                        {
                            new Manager_Form().Show();
                        }
                        else if (type == "CHECKER")
                        {
                            new Checker_Form().Show();
                        }
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("Role mismatch! Please check your UserID and password.", "Role Error", MessageBoxButtons.OKCancel);
                    }
                }
                else if (type == "CUSTOMER")
                {
                    string query2 = "SELECT * From CustomerTable WHERE UserID=@userID AND Password=@password";
                    cmd = new SqlCommand(query2, con);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@password", password);

                    object resultObj = cmd.ExecuteScalar();  // Check the result of the query

                    if (resultObj != null)
                    {
                        Customer_Form cusDefault = new Customer_Form();
                        cusDefault.SetUserID(userID);
                        cusDefault.Show();
                        flag = true;
                    }
                    else
                    {
                        MessageBox.Show("UserID or Password Invalid\n Try Again!!", "Wrong credential!", MessageBoxButtons.OKCancel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close(); // Ensure the connection is closed
                }
            }

            return flag;
        }
        
    }
}
