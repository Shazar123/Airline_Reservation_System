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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AirlineForm4 obj = new AirlineForm4();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AeroplaneForm1 obj = new AeroplaneForm1();
            obj.Show();
            this.Hide();

        }

        private void Flights_Click(object sender, EventArgs e)
        {
            Flights obj = new Flights();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationForm7 obj = new ReservationForm7();
            obj.Show();
            this.Hide();
        }
    }
}
