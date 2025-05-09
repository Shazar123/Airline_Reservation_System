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
    public partial class AeroplaneForm1 : Form
    {
        public AeroplaneForm1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToString(textBox2.Text) != "" && textBox3.Text != "" )
                {
                    Aeroplane obj = new Aeroplane(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text);
                    string message = obj.AddAeroplane();
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Fill All Fields..");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToString(textBox2.Text) != "" && textBox3.Text != "")
                {
                    Aeroplane obj = new Aeroplane(1, Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text);
                    string message = obj.UpdateAeroPlane();
                    MessageBox.Show(message);
                }
                else
                {
                    MessageBox.Show("Fill All Fields..");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    

   

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            Aeroplane obj = new Aeroplane();
                obj.DeleteAeroplane(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard obj = new AdminDashboard();
            obj.Show();
            this.Hide();
        }
    }
    }

