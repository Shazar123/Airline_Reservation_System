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
    public partial class ReservationForm7 : Form
    {
        public ReservationForm7()
        {
            InitializeComponent();
        }

        //update Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToString(textBox2.Text) != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != "" 
                    && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "")
                {
                    Reservation obj = new Reservation(1,textBox1.Text,textBox2.Text,dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString(),textBox9.Text,textBox11.Text,Convert.ToInt16(textBox2.Text),textBox4.Text,Convert.ToInt32(textBox6.Text),Convert.ToDouble(textBox8.Text),Convert.ToInt32(textBox10.Text), textBox12.Text);
                    string message = obj.UpdateReservation();
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
                Reservation obj = new Reservation();
                obj.DeleteReservation(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        //insert Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToString(textBox2.Text) != "" && textBox3.Text != "" && textBox4.Text != "" && textBox6.Text != ""
                    && textBox8.Text != "" && textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "")
                {
                    Reservation obj = new Reservation(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString(), textBox9.Text, textBox11.Text, Convert.ToInt16(textBox2.Text), textBox4.Text, Convert.ToInt32(textBox6.Text), Convert.ToDouble(textBox8.Text), Convert.ToInt32(textBox10.Text));
                    string message = obj.AddReservation();
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

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard obj = new AdminDashboard();
            obj.Show();
            this.Hide();
        }
    }
    }

