using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_System
{
    class Employee : Connection
    {
         int Employee_ID { get; set; }
         string Employee_name { get; set; }
         string Employee_mobile { get; set; }
        string Employee_Email { get; set; }
        string Employee_type { get; set; }
        string Employee_Address { get; set; }

        //Default Constructor 
        public Employee()
        {

        }

        //Constructor for Insering Data
        public Employee(string Employee_name, string Employee_mobile, string Employee_Email, string Employee_type, string Employee_Address)
        {
            this.Employee_name = Employee_name;
            this.Employee_mobile = Employee_mobile;
            this.Employee_Email = Employee_Email;
            this.Employee_type = Employee_type;
            this.Employee_Address = Employee_Address;
        }


        //Constructor for Updating Data
         public Employee(int Employee_ID, string Employee_name, string Employee_mobile, string Employee_Email, string Employee_type, string Employee_Address)
        {
            this.Employee_ID = Employee_ID;
            this.Employee_name = Employee_name;
            this.Employee_mobile = Employee_mobile;
            this.Employee_Email = Employee_Email;
            this.Employee_type = Employee_type;
            this.Employee_Address = Employee_Address;
        }

        public string AddEmployee()
        {
            try
            {
                OleDbConnection conn = GetConnection();
                string query = @"INSERT INTO EmployeesEmployee_name, Employee_mobile, Employee_Email, Employee_type, Employee_Address)
           VALUES(" + Employee_name + ",'" + Employee_mobile + "'," + Employee_Email + ",'" + Employee_type + "','"
                          + Employee_Address + "')";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Employee Added Successfully.";

        }

        public string UpdateEmployee()
        {
            try
            {
                 OleDbConnection conn = GetConnection();
                string query = "UPDATE Employees SET Employee_name='" + Employee_name + 
                                "',Employee_mobile='" + Employee_mobile + "'," +
                                "Employee_type='" + Employee_type + "'," +
                                "Employee_Email='"+ Employee_Email + "'," +
                                "Employee_Address='" + Employee_Address + "' " +
                                "WHERE Employee_ID='" + Employee_ID + "'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Employee Updated Successfully.";

        }


        public string DeleteEmployee(int Employee_ID)
        {
            try
            {
                 OleDbConnection conn = GetConnection();
                string query = @"DELETE FROM Employees WHERE Employee_ID = " + Employee_ID +"'";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {

                return "Error";
            }

            return "Employee Deleted Successfully.";

        }


        //Polymorphism Method Overloading 
        public List<Employee> Search_Employees()
        {
            List<Employee> Employees = new List<Employee>();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Employees", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {
                    Employee employee = new Employee();
                    employee.Employee_ID = int.Parse(rows["Employee_ID"].ToString());
                    employee.Employee_name = rows["Employee_name"].ToString();
                    employee.Employee_Email = rows["Employee_Email"].ToString();
                    employee.Employee_mobile = rows["Employee_mobile"].ToString();
                    employee.Employee_type = rows["Employee_type"].ToString();
                    employee.Employee_Address = rows["Employee_Address"].ToString();
                    Employees.Add(employee);
                }
                
            }
            catch (Exception ex)
            {

                return Employees;
            }

            return Employees;

        }

        public Employee Search_Employees(string Employee_ID)
        {
            Employee employee = new Employee();
            try
            {
                DataSet ds = new DataSet();
                OleDbConnection conn = GetConnection();
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from Employees Where Employee_ID =" + Employee_ID + "'", conn);
                da.Fill(ds);
                conn.Close();
                DataTable dt = ds.Tables[0];
                foreach (DataRow rows in dt.Rows)
                {
                   
                    employee.Employee_ID = int.Parse(rows["Employee_ID"].ToString());
                    employee.Employee_name = rows["Employee_name"].ToString();
                    employee.Employee_Email = rows["Employee_Email"].ToString();
                    employee.Employee_mobile = rows["Employee_mobile"].ToString();
                    employee.Employee_type = rows["Employee_type"].ToString();
                    employee.Employee_Address = rows["Employee_Address"].ToString();
                    
                }

            }
            catch (Exception ex)
            {

                return employee;
            }

            return employee;

        }



    }
}
    
