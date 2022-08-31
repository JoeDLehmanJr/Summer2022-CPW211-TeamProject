using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Carshop
{
    static class ModifyCustomers
    {
        //Create new entry
        //Get current data from form and pass as new entry into table
        //Add element to check if customer already exists before implementing
        //new customer

        public static void Create(Customers c)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Customers(firstName, lastName, payment)"
                + " VALUES(@fName, @lName, @payment)";

            insertCmd.Parameters.AddWithValue("@fName", c.FirstName);
            insertCmd.Parameters.AddWithValue("@lName", c.LastName);
            insertCmd.Parameters.AddWithValue("@payment", c.Payment);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();

        }


        //Read All entries
        //return all entries from table

        public static List<Customers> GetAllCustomers()
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            con.Open();

            SqlDataReader reader = insertCmd.ExecuteReader();


            List<Customers> customers = new List<Customers>();
            while (reader.Read())
            {
                string firstName = reader["firstName"].ToString();
                string lastName = reader["lastName"].ToString();
                string payment = reader["payment"].ToString();

                Customers tempCustomer = new Customers(firstName, lastName, payment);
                customers.Add(tempCustomer);
            }

            con.Close();


            return customers;
        }

        //Read individually selected entries
        //return selected entry from table as list<String>

        public static List<String> GetSelectedCustomer(string firstName, string lastName, string payment)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            
            string fName = firstName;
            string lName = lastName;
            string pay = payment;

            insertCmd.CommandText = "SELECT * FROM Customers WHERE firstName = @fName, " +
                "lastName = @lName, payment = @payment";    

            insertCmd.Parameters.AddWithValue("@fName", fName);
            insertCmd.Parameters.AddWithValue("@lName", lName);
            insertCmd.Parameters.AddWithValue("@payment", pay);

            


            SqlDataReader reader = insertCmd.ExecuteReader();
            con.Open();
            List<String> selectCustomers = new List<String>();
            while (reader.Read())
            {
                selectCustomers.Add(reader[0].ToString());
            }

            return selectCustomers;

            con.Close();


        }


        //update current entry
        //If customer already exists, overwrite old data.

        public static void update(Customers c)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "UPDATE Customers SET firstName = @fName, lastName = @lName, " +
                "payment = @payment WHERE customersId = @customersId";
            
            insertCmd.Parameters.AddWithValue("@customersId", c.CustomersId);
            insertCmd.Parameters.AddWithValue("@fName", c.FirstName);
            insertCmd.Parameters.AddWithValue("@lName", c.LastName);
            insertCmd.Parameters.AddWithValue("@payment", c.Payment);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        //delete entry
        //If customer exists, delete entry from table

        public static void delete(Customers c)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "DELETE FROM Customers WHERE firstName = @fName, "
                + "lastName = @lName, payment = @payment";
            
            insertCmd.Parameters.AddWithValue("@fName", c.FirstName);
            insertCmd.Parameters.AddWithValue("@lName", c.LastName);
            insertCmd.Parameters.AddWithValue("@payment", c.Payment);

             con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
