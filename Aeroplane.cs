using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Airline_Reservation_System
{
    class Aeroplane: Connection
    {
        int aeroplane_ID { get; set; }
        int No_Of_seats { get; set; }
        string airline_Name { get; set; }
        string scheduleDate { get; set; }
        string aeroplane_type { get; set; }
       
        
        //Default Constructor 
        public Aeroplane()
        {

        }

        //Constructor for Insering Data
        public Aeroplane( int No_Of_seats, string airline_Name, string aeroplane_type)
        {
            this.No_Of_seats = No_Of_seats;
            this.airline_Name = airline_Name;
            this.aeroplane_type = aeroplane_type;
            
        }


        //Constructor for Updating Data
        public Aeroplane(int aeroplane_ID, int No_Of_seats, string airline_Name, string aeroplane_type)
        {
            this.aeroplane_ID = aeroplane_ID;
            this.No_Of_seats = No_Of_seats;
            this.airline_Name = airline_Name;
            this.aeroplane_type = aeroplane_type;
            
        }

        public string AddAeroplane()
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = @"INSERT INTO Aeroplane(No_Of_seats, airline_Name, aeroplane_type)
           VALUES(" + No_Of_seats + ",'" + airline_Name + "'," + aeroplane_type+ "')";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Aeroplane Added Successfully.";

        }

        public string UpdateAeroPlane()
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = "UPDATE Aeroplane SET No_Of_seats='" + No_Of_seats +
                                "',airline_Name='" + airline_Name + "'," +
                                "aeroplane_type='" + aeroplane_type + "'," +
                                
                                "WHERE aeroplane_ID='" + aeroplane_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "AeroPlane Updated Successfully.";

        }


        public string DeleteAeroplane(int aeroplane_ID)
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = @"DELETE FROM AeroPlane WHERE aeroplane_ID = " + aeroplane_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "AeroPlane Deleted Successfully.";

        }

        public List<Aeroplane> Search_Aeroplane()
        {
            List<Aeroplane> Aeroplanes = new List<Aeroplane>();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Aeroplane", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {
                    Aeroplane aeroplane = new Aeroplane();
                    aeroplane.aeroplane_ID = int.Parse(rows["aeroplane_ID"].ToString());
                    aeroplane.No_Of_seats = int.Parse(rows["No_Of_seats"].ToString());
                    aeroplane.airline_Name = rows["airline_Name"].ToString();
                    aeroplane.aeroplane_type = rows["aeroplane_type"].ToString();

                    Aeroplanes.Add(aeroplane);
                }
            }
            catch (Exception ex)
            {

                return Aeroplanes;
            }

            return Aeroplanes;

        }

        public Aeroplane Search_Aeroplane(string aeroplane_ID)
        {
            Aeroplane Aeroplanes = new Aeroplane();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Employee Where aeroplane_ID =" + aeroplane_ID + "'", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {

                    Aeroplane aeroplane = new Aeroplane();
                    aeroplane.aeroplane_ID = int.Parse(rows["aeroplane_ID"].ToString());
                    aeroplane.No_Of_seats = int.Parse(rows["No_Of_seats"].ToString());
                    aeroplane.airline_Name = rows["airline_Name"].ToString();
                    aeroplane.aeroplane_type = rows["aeroplane_type"].ToString();
                }
            }
            catch (Exception ex)
            {

                return Aeroplanes;
            }

            return Aeroplanes;

        }

    }
}
