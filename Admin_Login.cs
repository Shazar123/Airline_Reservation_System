using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation_System
{
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_Registration obj = new Admin_Registration();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Airline obj = new Airline();
            string message = obj.AdminLogin(email.Text, password.Text);
            if (message == "Login")
            {
                MessageBox.Show("Login Successfull");
                AdminDashboard dobj = new AdminDashboard();
                dobj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
