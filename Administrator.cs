using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;

namespace Airline_Reservation_System
{
    abstract class Administrator 
    {

        int adminID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }

        public abstract string AddAirLine();


        //Constructor for Insering Data
        public Administrator(string Name, string Email, string Password)
        {
            this.Name = Name;
            this.Email = Email;

            this.Password = Password;
         
        }
        
        public  string RegisterAdmin()
        {
            try
            {
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                string query = @"Insert into Administrator([Name], Email, [Password])Values('" + Name + "','" + Email + "','" + Password + "')";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Registeration Successfull.";

        }

        public string AdminLogin(string email,string password)
        {
            string message = "";
            try
            {
                Connection c1 = new Connection();
                OleDbConnection conn = c1.GetConnection();
                string query = @"select Email,Password from Administrator where Email='" + email + "'and Password='" + password + "'";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    message = "Login";


                }
                else
                {
                     message  = "Invalid Login please check username and password";
                }
                c1.CloseConnection(conn);
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return message;

        }

    }
}
