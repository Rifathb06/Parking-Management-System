using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace ParkingManagmentSystem
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Button1_LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login(textBox_UserID.Text, textBox_Password.Text);
                
                if (login.LoginOp() == true)
                {

                    this.Hide();
                }
            }
            catch
            {

                MessageBox.Show("Exception Occur!! ", "Error!", MessageBoxButtons.OKCancel);
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label_Signup_Now_Click(object sender, EventArgs e)
        {
            new Signup_Form().Show();
            this.Hide();
        }

        private void checkBox_ShowPassLOGIN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassLOGIN.Checked == true)
            {

                textBox_Password.UseSystemPasswordChar = false;


            }
            else
            {

                textBox_Password.UseSystemPasswordChar = true;


            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox_UserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
