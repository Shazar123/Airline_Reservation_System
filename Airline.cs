using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace Airline_Reservation_System
{
    class Airline : Administrator

    {
        int airline_ID { get; set; }
        string airline_Name { get; set; }
        string airline_Type { get; set; }
        string airline_Description { get; set; }
        int noOfPlanes { get; set; }
        bool airline_permission { get; set; }

        public string getAirlineName()
        {
            return airline_Name;
        }

        public string getAirlineType()
        {
            return airline_Type;
        }

        public string getAirlineDescription()
        {
            return airline_Description;
        }

        public string getNoOfPlanes()
        {
            return noOfPlanes.ToString();
        }

        public string getAirline_permission()
        {
            if (airline_permission == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public Airline() : base("", "", "")
        {

        }

        public Airline(string Name, string Email, string Password):base(Name, Email,Password)
        {
            
        }

        //Constructor for Insering Data
        public Airline(string airline_Name, string airline_Type, string airline_Description, int noOfPlanes, bool airline_permission) : base("", "", "")
        {
            this.airline_Name = airline_Name;
            this.airline_Type = airline_Type;

            this.airline_Description = airline_Description;
            this.noOfPlanes = noOfPlanes;
            this.airline_permission = airline_permission;

        }


        //Constructor for Updating Data
        public Airline(int airline_ID, string airline_Name, string airline_Type, string airline_Description, int noOfPlanes, bool airline_permission) : base("", "", "")
        {
            this.airline_ID = airline_ID;
            this.airline_Name = airline_Name;
            this.airline_Type = airline_Type;

            this.airline_Description = airline_Description;
            this.noOfPlanes = noOfPlanes;
            this.airline_permission = airline_permission;
        }

        public override string AddAirLine()
        {
            try
            {
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                string query = @"INSERT INTO Airline(airline_Name, airline_Type, airline_Description, noOfPlanes,airline_permission)VALUES('" + airline_Name + "','" + airline_Type + "','" + airline_Description + "',"+ noOfPlanes + "," + airline_permission + ")";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Added Successfully.";

        }

        public string UpdateAirLine()
        {
            try
            {
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                string query = "UPDATE Employee SET airline_Name='" + airline_Name +
                                "',airline_Type='" + airline_Type + "'," +
                                "airline_Description='" + airline_Description + "'," +
                                "noOfPlanes='" + noOfPlanes + "' " + "airline_permission='" + airline_permission + "' " +
                                "WHERE airline_ID='" + airline_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Updated Successfully.";

        }
        public string DeleteAirLine(int airline_ID)
        {
            try
            {
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                string query = @"DELETE FROM AirLine WHERE airline_ID = " + airline_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Deleted Successfully.";

        }

        public void Search_Airline(int ID)
        {
          
            try
            {
                DataSet ds = new DataSet();
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Airline Where airline_ID =" + ID + "", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {

                    airline_ID = int.Parse(rows["airline_ID"].ToString());
                    airline_Name = rows["airline_Name"].ToString();
                    airline_Description = rows["airline_Description"].ToString();
                    airline_Type = rows["airline_Type"].ToString();
                    noOfPlanes = int.Parse(rows["noOfPlanes"].ToString());
                    airline_permission = Convert.ToBoolean(rows["airline_permission"].ToString());
                    
                }


            }
            catch (Exception ex)
            {

                
            }

            

        }

        public DataTable Search_Airline()
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Airline", conn);
                da.Fill(ds);
                conn.Close();
                 dt = ds.Tables[0];
                //foreach (DataRow rows in dt.Rows)
                //{
                //    Aeroplane aeroplane = new Aeroplane();
                //    aeroplane.aeroplane_ID = int.Parse(rows["aeroplane_ID"].ToString());
                //    aeroplane.No_Of_seats = int.Parse(rows["No_Of_seats"].ToString());
                //    aeroplane.airline_Name = rows["airline_Name"].ToString();
                //    aeroplane.aeroplane_type = rows["aeroplane_type"].ToString();

                //    Aeroplanes.Add(aeroplane);
                //}
            }
            catch (Exception ex)
            {

                return dt;
            }

            return dt;

        }




    }
}

