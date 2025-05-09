using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System
{
    class Ticket_Booking
    {
         int ticket_booking_ID { get; set; }
         string ticket_booking_Type { get; set; }
         string ticket_booking_Description { get; set; }
         string ticket_booking_date { get; set; }
         string airline_Name { get; set; }
         int aeroplane_ID { get; set; }
         string seat_no { get; set; }


        public Ticket_Booking()
        {

        }

        public Ticket_Booking(string ticket_booking_Type, string ticket_booking_description, string ticket_booking_date)
        {

        }

        public Ticket_Booking(int ticket_booking_ID, string ticket_booking_Type, string ticket_booking_description, string ticket_booking_date)
        {

        }

        public string AddTicket_booking()
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Ticket Generated Successfully.";

        }

        public string UpdateTicket_booking()
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Ticket Booking Updated Successfully.";

        }


        public string DeleteTicket_booking(int ticket_booking_ID)
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Ticket Booking Deleted Successfully.";

        }

      
        public Ticket_Booking Search_ticket_booking(int ticket_booking_ID)
        {
            Ticket_Booking ticket_booking_name = new Ticket_Booking();
            try
            {

            }
            catch (Exception ex)
            {

                return ticket_booking_name;
            }

            return ticket_booking_name;

        }



    }
}
    
   
