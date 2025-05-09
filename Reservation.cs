using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System
{
    class Reservation : Connection
    {
   
         int reservation_ID { get; set; }
         string Passenger_Name { get; set; }
         string reservation_Class { get; set; }
         string reservation_Date { get; set; }
         string reservation_Time { get; set; }
         string reservation_Origin { get; set; } 
         string reservation_Destination { get; set; }
         int aeroplane_ID { get; set; }
         string airline_Name { get; set; }
         int Seat_Number { get; set; }
         double Fare { get; set; } 
         int Ticket_No { get; set; }
         string reservation_Status { get; set; }
        public Reservation()
        {

        }

        //Constructor for Insering Data
        public Reservation(string Passenger_Name, string reservation_Class, string reservation_Date, string reservation_Time, string reservation_Origin, string reservation_Destination, int aeroplane_ID, string airline_Name, int Seat_Number, double Fare, int Ticket_No)
        {
            this.Passenger_Name = Passenger_Name;
            this.reservation_Class = reservation_Class;
            this.reservation_Date = reservation_Date;
            this.reservation_Time = reservation_Time;
            this.reservation_Origin = reservation_Origin;
            this.reservation_Destination = reservation_Destination;
            this.aeroplane_ID = aeroplane_ID;
            this.airline_Name = airline_Name;
            this.Seat_Number = Seat_Number;
            this.Fare = Fare;
            this.Ticket_No = Ticket_No;
            this.reservation_Status = "Booked";
        }


        //Constructor for Updating Data
        public Reservation(int reservation_ID, string Passenger_Name, string reservation_Class, string reservation_Date, string reservation_Time, string reservation_Origin, string reservation_Destination, int aeroplane_ID, string airline_Name, int Seat_Number, double Fare, int Ticket_No, string reservation_Status)
        {
            this.reservation_ID = reservation_ID;
            this.Passenger_Name = Passenger_Name;
            this.reservation_Class = reservation_Class;
            this.reservation_Date = reservation_Date;
            this.reservation_Time = reservation_Time;
            this.reservation_Origin = reservation_Origin;
            this.reservation_Destination = reservation_Destination;
            this.aeroplane_ID = aeroplane_ID;
            this.airline_Name = airline_Name;
            this.Seat_Number = Seat_Number;
            this.Fare = Fare;
            this.Ticket_No = Ticket_No;
            this.reservation_Status = reservation_Status;
        }


        public string AddReservation()
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = @"INSERT INTO Reservation(Passenger_Name, reservation_Class, reservation_Date, reservation_Time,reservation_Origin,reservation_Destination,aeroplane_ID,airline_Name
,Seat_Number,Fare,Ticket_No,reservation_Status)
           VALUES(" + Passenger_Name + ",'" + reservation_Class + "'," + reservation_Date + ",'" + reservation_Time + "','"
                          + reservation_Origin + "','" + reservation_Destination + "','" + aeroplane_ID + "','" + airline_Name + "','" + Seat_Number + "'" +
                          ",'" + Fare + "','" + Ticket_No + "','" + reservation_Status + "')";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Reservation made Successfully.";

        }

        public string UpdateReservation()
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = "UPDATE Reservation SET Passenger_Name='" + Passenger_Name +
                                "',reservation_Class='" + reservation_Class + "'," +
                                "reservation_Date='" + reservation_Date + "'," +
                                "reservation_Time='" + reservation_Time + "'," +
                                "reservation_Origin='" + reservation_Origin + "' " + "reservation_Destination='" + reservation_Destination + "' " +
                                 "aeroplane_ID='" + aeroplane_ID + "' " + "airline_Name='" + airline_Name + "' " +
                                  "Seat_Number='" + Seat_Number + "' " + "Fare='" + Fare + "' " +
                                   "Ticket_No='" + Ticket_No + "' " +
                                    "reservation_Status='" + reservation_Status + "' " +
                                "WHERE reservation_ID='" + reservation_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Reservation Updated Successfully.";

        }
        public string DeleteReservation(int reservation_ID)
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = @"DELETE FROM Reservation WHERE reservation_ID = " + reservation_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Reservation Deleted Successfully.";

        }

        public List<Reservation> Select_Reservation()
        {
            List<Reservation> reservations = new List<Reservation>();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Reservation", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {
                    Reservation reservation = new Reservation();
                    reservation.reservation_ID = int.Parse(rows["reservation_ID"].ToString());
                    reservation.Passenger_Name = rows["Passenger_Name"].ToString();
                    reservation.reservation_Class = rows["reservation_Class"].ToString();
                    reservation.reservation_Date = rows["reservation_Date"].ToString();
                    reservation.reservation_Time = rows["reservation_Time"].ToString();
                    reservation.reservation_Origin = rows["reservation_Origin"].ToString();
                    reservation.reservation_Destination = rows["reservation_Destination"].ToString();
                    reservation.aeroplane_ID = int.Parse(rows["aeroplane_ID"].ToString());
                    reservation.airline_Name = rows["airline_Name"].ToString();
                    reservation.Seat_Number = int.Parse(rows["Seat_Number"].ToString());
                    reservation.Fare = Double.Parse(rows["Fare"].ToString());
                    reservation.Ticket_No = int.Parse(rows["Ticket_No"].ToString());
                    reservation.reservation_Status = rows["reservation_Status"].ToString();
                    reservations.Add(reservation);
                }
            }
            catch (Exception ex)
            {

                return reservations;
            }

            return reservations;

        }

        public Reservation Search_Reservation(int Ticket_No)
        {
            Reservation reservation = new Reservation();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Reservation Where Ticket_No =" + Ticket_No + "'", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {

                    reservation.reservation_ID = int.Parse(rows["reservation_ID"].ToString());
                    reservation.Passenger_Name = rows["Passenger_Name"].ToString();
                    reservation.reservation_Class = rows["reservation_Class"].ToString();
                    reservation.reservation_Date = rows["reservation_Date"].ToString();
                    reservation.reservation_Time = rows["reservation_Time"].ToString();
                    reservation.reservation_Origin = rows["reservation_Origin"].ToString();
                    reservation.reservation_Destination = rows["reservation_Destination"].ToString();
                    reservation.aeroplane_ID = int.Parse(rows["aeroplane_ID"].ToString());
                    reservation.airline_Name = rows["airline_Name"].ToString();
                    reservation.Seat_Number = int.Parse(rows["Seat_Number"].ToString());
                    reservation.Fare = Double.Parse(rows["Fare"].ToString());
                    reservation.Ticket_No = int.Parse(rows["Ticket_No"].ToString());
                    reservation.reservation_Status = rows["reservation_Status"].ToString();


                }
            }
            catch (Exception ex)
            {

                return reservation;
            }

            return reservation;

        }

    }
}
