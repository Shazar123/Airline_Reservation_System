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
    public partial class EmployeeForm5 : Form
    {
        public EmployeeForm5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" && Convert.ToString(textBox3.Text) != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    Employee obj = new Employee(textBox2.Text, Convert.ToString(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
                    string message = obj.AddEmployee();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != "" && Convert.ToString(textBox3.Text) != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {
                    Employee obj = new Employee(1,textBox2.Text, Convert.ToString(textBox3.Text), textBox4.Text, textBox5.Text, textBox6.Text);
                    string message = obj.UpdateEmployee();
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
                Employee obj = new Employee();
                obj.DeleteEmployee(1);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
