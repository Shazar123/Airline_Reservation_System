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
    public partial class Admin_Registration : Form
    {
        public Admin_Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Airline obj = new Airline(name.Text, email.Text, password.Text);
            string message =   obj.RegisterAdmin();
            MessageBox.Show(message);
            Admin_Login a1 = new Admin_Login();
            a1.Show();
            this.Hide();

        }

        private void Admin_Registration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home a1 = new Home();
            a1.Show();
            this.Hide();
        }
    }
}
