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
    public partial class AirlineForm4 : Form
    {
        public AirlineForm4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool permission = false;
            if (comboBox1.SelectedItem.ToString() == "Yes")
            {
                permission = true;
            }
            Airline obj = new Airline(textBox1.Text, comboBox2.SelectedItem.ToString(), textBox4.Text, Convert.ToInt16(textBox5.Text),permission);
            string message = obj.AddAirLine();
            MessageBox.Show(message);
            FillGrigview();



        }

        private void airlineGrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminDashboard obj = new AdminDashboard();
            obj.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AirlineForm4_Load(object sender, EventArgs e)
        {
            FillGrigview();

        }

        public void FillGrigview()
        {
            Airline obj = new Airline();
            DataTable airlines = obj.Search_Airline();
            airlines.Columns["airline_ID"].ColumnName = "ID";
            airlines.Columns["airline_Name"].ColumnName = "Name";
            airlines.Columns["airline_type"].ColumnName = "Type";
            airlines.Columns["airline_Description"].ColumnName = "Description";
            airlines.Columns["noOfPlanes"].ColumnName = "AeroPlanes";
            airlines.Columns["airline_permission"].ColumnName = "Status";
            airlineGrd.DataSource = airlines;


            //ADDing AirLine_ID to Combobox for Updating
            comboBox3.DataSource = airlines;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "ID";

            //ADDing AirLine_ID to Combobox for Deleting
            comboBox4.DataSource = airlines;
            comboBox4.DisplayMember = "Name";
            comboBox4.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(comboBox3.SelectedValue.ToString());
            Airline obj = new Airline();
            obj.Search_Airline(ID);
            comboBox5.SelectedIndex = comboBox5.Items.IndexOf(obj.getAirlineType()); ;
            textBox2.Text = obj.getAirlineDescription();
            textBox3.Text = obj.getNoOfPlanes();
            textBox8.Text = obj.getAirlineName();
            comboBox6.SelectedIndex = comboBox6.Items.IndexOf(obj.getAirline_permission());
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(comboBox4.SelectedValue.ToString());
            Airline obj = new Airline();
            obj.Search_Airline(ID);
            comboBox7.SelectedIndex = comboBox7.Items.IndexOf(obj.getAirlineType()); ;
            textBox9.Text = obj.getAirlineName();
            textBox6.Text = obj.getAirlineDescription();
            textBox7.Text = obj.getNoOfPlanes();
            comboBox8.SelectedIndex = comboBox8.Items.IndexOf(obj.getAirline_permission());
        }
    }
}
