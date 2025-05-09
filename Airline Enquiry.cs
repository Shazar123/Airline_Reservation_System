using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System
{
    class Airline_Enquiry
    {
        int airline_enquiry_ID { get; set; }
        string airline_enquiry_Description { get; set; }
        string airline_enquiry_date { get; set; }
        int Passenger_ID { get; set; }

        public string AddAirline_Enquiry()
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Enquiry Added Successfully.";

        }

        public string UpdateAirline_Enquiry(int airline_enquiry_ID, string airline_enquiry_Description, string airline_enquiry_date, int Passenger_ID)
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Enquiry Updated Successfully.";

        }


        public string DeleteAirline_Enquiry(int airline_enquiry_ID)
        {
            try
            {

            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Airline Enquiry Deleted Successfully.";

        }

        public List<Airline_Enquiry> Select_All_Airline_Enquiry()
        {
            List< Airline_Enquiry> Airline_Enquirys = new List<Airline_Enquiry>();
            try
            {

            }
            catch (Exception ex)
            {

                return Airline_Enquirys;
            }

            return Airline_Enquirys;

        }

        public  Airline_Enquiry Search_Airline_Enquiry(int airline_enquiry_ID)
        {
            Airline_Enquiry Airline_Enquirys = new Airline_Enquiry();
            try
            {

            }
            catch (Exception ex)
            {

                return Airline_Enquirys;
            }

            return Airline_Enquirys;

        }


    }
}


    