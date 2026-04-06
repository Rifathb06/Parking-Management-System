using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace ParkingManagmentSystem
{
    public class Person
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QHCFKMG\\SQLEXPRESS;Initial Catalog=ParkingManagement;Integrated Security=True");

        public string Name;
        public int Nid;
        public string Phone;
        public string UserID;
        public string Password;
        public string Position;
        public float Salary;


        public Person()
        {

        }

        public Person(string name, int nid, string phone, string userID, string password, string position, float salary)
        {
            this.Name = name;
            this.Nid = nid;
            this.Phone = phone;
            this.UserID = userID;
            this.Password = password;
            this.Position = position;
            this.Salary = salary;

            EmployeeOp();
        }
        public Person(string name, int nid, string phone, string userID, string password)
        {
            this.Name = name;
            this.Nid = nid;
            this.Phone = phone;
            this.UserID = userID;
            this.Password = password;

            CustomerOp();
        }
        public string Name1 { get => Name; set => Name = value; }
        public int Nid1 { get => Nid; set => Nid = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string UserID1 { get => UserID; set => UserID = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Position1 { get => Position; set => Position = value; }
        public float Salary1 { get => Salary; set => Salary = value; }

        public void EmployeeOp()
        {
            string query1 = "INSERT INTO EmpTable VALUES (@Name, @Nid, @Phone, @UserID, @Password, @Position, @Salary)";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@Name", this.Name1);
            cmd.Parameters.AddWithValue("@Nid", this.Nid1);
            cmd.Parameters.AddWithValue("@Phone", this.Phone1);
            cmd.Parameters.AddWithValue("@UserID", this.UserID1);
            cmd.Parameters.AddWithValue("@Password", this.Password1);
            cmd.Parameters.AddWithValue("@Position", this.Position1);
            cmd.Parameters.AddWithValue("@Salary", this.Salary1);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OK);
            }
            con.Close();
        }
        public void CustomerOp()
        {
            string query2 = "INSERT INTO CustomerTable VALUES (@Name, @Nid, @Phone, @UserID, @Password)";
            SqlCommand cmd = new SqlCommand(query2, con);
            cmd.Parameters.AddWithValue("@Name", this.Name1);
            cmd.Parameters.AddWithValue("@Nid", this.Nid1);
            cmd.Parameters.AddWithValue("@Phone", this.Phone1);
            cmd.Parameters.AddWithValue("@UserID", this.UserID1);
            cmd.Parameters.AddWithValue("@Password", this.Password1);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error!", "Connection Error!", MessageBoxButtons.OK);
            }
            con.Close();
        }
        public void ShowInfo()
        {

        }

    }
}
