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
    public partial class Checker_Form : Form
    {
        Checker checker=new Checker();
        string CheckerName;
       string UserID;
        int seconds = 0;

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        public Checker_Form()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                // SQL query to select all data from SlotTable
                string query = "SELECT * FROM SlotTable";

                // Create a data adapter and fill the DataTable with the data from the query
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);

                // Set the DataGridView data source to the DataTable
                dataGridView_NotificationBox_TokenChecker.DataSource = dtable;

                // Ensure the DataGridView fills the available space
                dataGridView_NotificationBox_TokenChecker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }
        private void Checker_Form_Load(object sender, EventArgs e)
        {
            LoadData();
            changePassword1.Hide();

            seconds = 20;
            countdowntimer.Start();

            // checker_Verify1.Show();
            //  checker_Verify1.BringToFront();

            // Adjust DataGridView settings for a clean appearance
            dataGridView_NotificationBox_TokenChecker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView_NotificationBox_TokenChecker.Dock = DockStyle.Fill;
            dataGridView_NotificationBox_TokenChecker.RowHeadersVisible = false;
            dataGridView_NotificationBox_TokenChecker.AllowUserToResizeColumns = false;
            dataGridView_NotificationBox_TokenChecker.AllowUserToResizeRows = false;
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

        private void button_Check_Click(object sender, EventArgs e)
        {
            if (textBox_CheckToken_TokenChecker.Text != "" && textBox_checkVehicle.Text != "")
            {
                try
                {
                    // Using 'using' ensures that the connection is closed automatically after the block finishes
                    using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True"))
                    {
                        con.Open();
                        // Check if the vehicle matches the token
                        string query1 = "SELECT vehicalNumber FROM SlotTable WHERE TokenID=@TokenID";
                        SqlCommand cmd1 = new SqlCommand(query1, con);
                        cmd1.Parameters.AddWithValue("@TokenID", textBox_CheckToken_TokenChecker.Text);
                        string vehicle = cmd1.ExecuteScalar() as string;

                        if (vehicle == textBox_checkVehicle.Text)
                        {
                            try
                            {
                                // Delete the record if the vehicle number matches the token
                                string query3 = "DELETE FROM SlotTable WHERE TokenID=@TokenID";
                                SqlCommand cmd = new SqlCommand(query3, con);
                                cmd.Parameters.AddWithValue("@TokenID", textBox_CheckToken_TokenChecker.Text);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Record removed successfully.", "Success", MessageBoxButtons.OKCancel);

                                // Refresh the DataGridView by reloading the data after deletion
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error while removing the record: " + ex.Message, "Error", MessageBoxButtons.OKCancel);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vehicle ID did not match.", "Error", MessageBoxButtons.OKCancel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during checking process: " + ex.Message, "Error", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Please provide both TokenID and VehicleID.", "Missing Information", MessageBoxButtons.OKCancel);
            }
        }


        private void textBox_CheckToken_TokenChecker_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_checkVehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_NotificationBox_TokenChecker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_NotificationBox_TokenChecker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            changePassword1.Show();
            changePassword1.BringToFront();
        }

        private void Button_Verify_Click(object sender, EventArgs e)
        {
            changePassword1.Hide();
        }

        private void Button_Enter_Click(object sender, EventArgs e)
        {
            countdowntimer.Stop();
            if (TextBox_UserID.Text != "")
            {
                string query1 = "SELECT Name FROM EmpTable WHERE UserID=@UserID;";
                SqlCommand cmd = new SqlCommand(query1, con);
                cmd.Parameters.AddWithValue("@UserID", TextBox_UserID.Text);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                CheckerName = cmd.ExecuteScalar() as string;
                con.Close();

                if (CheckerName == null)
                {
                    MessageBox.Show("UserID not found! Please log in.", "Wrong credential!", MessageBoxButtons.OKCancel);
                    new Login_Form().Show();
                    this.Hide();
                }
                else
                {
                    text_Checker.Text = CheckerName;
                    text_Checker.Enabled = false;
                }
                TextBox_UserID.Hide();
                Button_Enter.Hide();
            }
            else
            {
                MessageBox.Show("Enter UserID!", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void TextBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePassword1_Load(object sender, EventArgs e)
        {

        }

        private void ImageButton_Logout_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_Checker_Click(object sender, EventArgs e)
        {

        }
    }
}
