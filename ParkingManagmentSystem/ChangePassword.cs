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
    public partial class ChangePassword : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            if (textBox_UserID.Text == "")
            {
                MessageBox.Show("Please Insert your UserID", "Name Missing Error!", MessageBoxButtons.OKCancel);
            }
            else
            {
                if (textBox_ConfirmPassword.Text == "" && textBox_newPassword.Text == "" && textBox_Password.Text == "")
                {
                    MessageBox.Show("Please fill in all password fields", "Password Error!", MessageBoxButtons.OKCancel);
                }
                else
                {
                    if (textBox_newPassword.Text != textBox_ConfirmPassword.Text)
                    {
                        MessageBox.Show("Passwords do not match! Try Again!", "Password Error!");
                    }
                    else
                    {
                        try
                        {
                            // Open the SQL connection
                            con.Open();

                            string userid = textBox_UserID.Text.Substring(2, 2);
                            string checkOldPasswordQuery;
                            string updatePasswordQuery;

                            if (userid == "MA" || userid == "CL" || userid == "CH")
                            {
                                // Check if old password matches in EmpTable
                                checkOldPasswordQuery = "SELECT Password FROM EmpTable WHERE UserID = @UserID AND Password = @OldPassword";
                                updatePasswordQuery = "UPDATE EmpTable SET Password = @Password WHERE UserID = @UserID";
                            }
                            else if (userid == "CU")
                            {
                                // Check if old password matches in CustomerTBL
                                checkOldPasswordQuery = "SELECT Password FROM CustomerTable WHERE UserID = @UserID AND Password = @OldPassword";
                                updatePasswordQuery = "UPDATE CustomerTable SET Password = @Password WHERE UserID = @UserID";
                            }
                            else
                            {
                                MessageBox.Show("UserID not found!", "Error", MessageBoxButtons.OKCancel);
                                return;
                            }

                            // Verify the old password
                            SqlCommand checkOldPasswordCmd = new SqlCommand(checkOldPasswordQuery, con);
                            checkOldPasswordCmd.Parameters.AddWithValue("@UserID", textBox_UserID.Text);
                            checkOldPasswordCmd.Parameters.AddWithValue("@OldPassword", textBox_Password.Text);
                            var result = checkOldPasswordCmd.ExecuteScalar();

                            if (result != null)
                            {
                                // Old password matches, proceed to update the new password
                                SqlCommand updateCmd = new SqlCommand(updatePasswordQuery, con);
                                updateCmd.Parameters.AddWithValue("@Password", textBox_newPassword.Text);
                                updateCmd.Parameters.AddWithValue("@UserID", textBox_UserID.Text);

                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK);
                                    // Optionally redirect to login form after successful password change
                                    new Login_Form().Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Old password is incorrect!", "Error", MessageBoxButtons.OK);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OKCancel);
                        }
                        finally
                        {
                            if (con.State == ConnectionState.Open)
                            {
                                con.Close();
                            }
                        }
                    }
                }
            }
        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
                textBox_newPassword.UseSystemPasswordChar = false;
                textBox_ConfirmPassword.UseSystemPasswordChar = false;

            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
                textBox_newPassword.UseSystemPasswordChar = true;
                textBox_ConfirmPassword.UseSystemPasswordChar = true;

            }

        }

        private void textBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_ChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
