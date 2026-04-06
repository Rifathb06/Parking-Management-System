using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class ParkingDetails : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");
        public ParkingDetails()
        {
            InitializeComponent();
            
        }
        
        private void ParkingDetails_Load(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView_TokenNF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView_NotificationBox_TokenChecker.Dock = DockStyle.Fill;
            dataGridView_TokenNF.RowHeadersVisible = false;
            dataGridView_TokenNF.AllowUserToResizeColumns = false;
            dataGridView_TokenNF.AllowUserToResizeRows = false;

            dataGridView_NF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView_NotificationBox_TokenChecker.Dock = DockStyle.Fill;
            dataGridView_NF.RowHeadersVisible = false;
            dataGridView_NF.AllowUserToResizeColumns = false;
            dataGridView_NF.AllowUserToResizeRows = false;

            dataGridView_NF.Refresh();
            dataGridView_TokenNF.Refresh();

            LoadCustomerDetails();
            LoadSlotDetails();


            try
            {
                string query1 = "SELECT * FROM ParkingDetails";
                string query2 = "SELECT * FROM SlotTable";
                //  con.Open();
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlCommand cmd1 = new SqlCommand(query1, con);
                if (con.State == ConnectionState.Open)
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
                    DataTable dtable = new DataTable();
                    DataTable dtable2 = new DataTable();
                    adapter.Fill(dtable);
                    adapter2.Fill(dtable2);
                    dataGridView_TokenNF.DataSource = dtable;
                    dataGridView_NF.DataSource = dtable2;



                }
                else if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query1, con);
                    SqlDataAdapter adapter2 = new SqlDataAdapter(query2, con);
                    DataTable dtable = new DataTable();
                    DataTable dtable2 = new DataTable();
                    adapter.Fill(dtable);
                    adapter2.Fill(dtable2);
                    dataGridView_TokenNF.DataSource = dtable;
                    dataGridView_NF.DataSource = dtable2;
                }

                else
                {
                    MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OKCancel);
                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error!", MessageBoxButtons.OKCancel);
            }
        }
        public void RefreshData()
        {
            
            dataGridView_TokenNF.Refresh();
            dataGridView_NF.Refresh();


            LoadCustomerDetails();
            LoadSlotDetails();

        }

        private void dataGridView_NF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_TokenNF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        

        private void TextBox_searchBS_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_searchBS.Text)) // If the text box is empty
            {
                LoadSlotDetails(); // Reload original data
            }
            else
            {
                // Search query
                string query = "SELECT * FROM SlotTable WHERE slot LIKE '%" + textBox_searchBS.Text + "%' OR TokenID LIKE '%" + textBox_searchBS.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBS.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(dtable);
                con.Close();
                dataGridView_NF.DataSource = dtable; // Display filtered data
            }
        }

        private void TextBox_searchBS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_searchBS.Text != "")
            {
                dataGridView_NF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM SlotTable WHERE slot LIKE '%" + textBox_searchBS.Text + "%' OR TokenID LIKE '%" + textBox_searchBS.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBS.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_NF.DataSource = dv;
                con.Close();
            }
            else
            {
                dataGridView_NF.Refresh();
            }

        }

        private void TextBox_searchBC_Keypress(object sender, KeyPressEventArgs e)
        {
            if (textBox_searchBC.Text != "")
            {
                dataGridView_TokenNF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM ParkingDetails WHERE Name LIKE '%" + textBox_searchBC.Text + "%' OR NID LIKE '%" + textBox_searchBC.Text + "%' OR PhoneNumber LIKE '%" + textBox_searchBC.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBC.Text + "%' OR TokenID LIKE '%" + textBox_searchBC.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_TokenNF.DataSource = dv;
                con.Close();
            }
            else
            {
                dataGridView_TokenNF.Refresh();
            }
        }

        private void TextBox_searchBC_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_searchBC.Text)) // If the text box is empty
            {
                LoadCustomerDetails(); // Reload original data
            }
            else
            {
                // Search query
                string query = "SELECT * FROM ParkingDetails WHERE Name LIKE '%" + textBox_searchBC.Text + "%' OR NID LIKE '%" + textBox_searchBC.Text + "%' OR PhoneNumber LIKE '%" + textBox_searchBC.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBC.Text + "%' OR TokenID LIKE '%" + textBox_searchBC.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(dtable);
                con.Close();
                dataGridView_TokenNF.DataSource = dtable; // Display filtered data
            }
        }

        private void button_searchBS_Click(object sender, EventArgs e)
        {
            if (textBox_searchBS.Text != "")
            {
                dataGridView_NF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM SlotTable WHERE slot LIKE '%" + textBox_searchBS.Text + "%' OR TokenID LIKE '%" + textBox_searchBS.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBS.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_NF.DataSource = dv;
                con.Close();
            }
            else
            {
                dataGridView_NF.Refresh();
            }
        }

        private void button_searchBC_Click(object sender, EventArgs e)
        {
            if (textBox_searchBC.Text != "")
            {
                dataGridView_TokenNF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM ParkingDetails WHERE Name LIKE '%" + textBox_searchBC.Text + "%' OR NID LIKE '%" + textBox_searchBC.Text + "%' OR PhoneNumber LIKE '%" + textBox_searchBC.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBC.Text + "%' OR TokenID LIKE '%" + textBox_searchBC.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_TokenNF.DataSource = dv;
                con.Close();
            }
            else
            {
                dataGridView_TokenNF.Refresh();
            }
        }

        private void textBox_searchBC_Keyup(object sender, KeyEventArgs e)
        {
            
                // If the text box is empty after deleting or pressing backspace, load the original table
                if (textBox_searchBC.Text == "")
                {
                    LoadCustomerDetails();  // Refresh to original data
                }
                else
                {
                    dataGridView_TokenNF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM ParkingDetails WHERE Name LIKE '%" + textBox_searchBC.Text + "%' OR NID LIKE '%" + textBox_searchBC.Text + "%' OR PhoneNumber LIKE '%" + textBox_searchBC.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBC.Text + "%' OR TokenID LIKE '%" + textBox_searchBC.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataSet ds = new DataSet();
                    DataView dv = new DataView();

                    DataTable dtable = new DataTable();
                    con.Open();
                    adapter.Fill(ds);
                    dv = new DataView(ds.Tables[0]);

                    dataGridView_TokenNF.DataSource = dv;
                    con.Close();

                }
            
        }
        private void LoadCustomerDetails()
        {
            // Load all original data from ParkingDetails
            string query = "SELECT * FROM ParkingDetails";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            con.Open();
            adapter.Fill(dtable);
            con.Close();
            dataGridView_TokenNF.DataSource = dtable;
        }

        private void TextBox_searchBS_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_searchBS.Text == "")
            {
                LoadSlotDetails();  // Refresh to original data
            }
            else
            {
                dataGridView_NF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                string query = "SELECT * FROM SlotTable WHERE slot LIKE '%" + textBox_searchBS.Text + "%' OR TokenID LIKE '%" + textBox_searchBS.Text + "%' OR vehicalNumber LIKE '%" + textBox_searchBS.Text + "%';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                DataView dv = new DataView();

                DataTable dtable = new DataTable();
                con.Open();
                adapter.Fill(ds);
                dv = new DataView(ds.Tables[0]);

                dataGridView_NF.DataSource = dv;
                con.Close();
            }
        }
        private void LoadSlotDetails()
        {
            // Load all original data from SlotTable
            string query = "SELECT * FROM SlotTable";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dtable = new DataTable();
            con.Open();
            adapter.Fill(dtable);
            con.Close();
            dataGridView_NF.DataSource = dtable;
        }
    }
}
