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
    public partial class CheckDetails : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        
        public CheckDetails()
        {
            InitializeComponent();
        }

        private void CheckDetails_Load(object sender, EventArgs e)
        {
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
            try
            {
                string query1 = "SELECT * FROM Customer where UserID= @userID";
                string query2 = "SELECT * FROM ParkingDetails where vehicalNumber= @";
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
        private void textBox_searchBS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_TokenNF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_NF_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
