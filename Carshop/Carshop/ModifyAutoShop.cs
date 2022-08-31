using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Carshop
{
    static class ModifyAutoShop
    {
        //Create new entry
        //Get current data from form and pass as new entry into table
        //Add element to check if customer already exists before implementing
        //new AutoShop

        public static void Create(AutoShop a)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO AutoShop(Make, Model, releaseYear, userStatus)"
                + " VALUES(@make, @model, @releaseYear, @userStatus)";

            insertCmd.Parameters.AddWithValue("@make", a.Make);
            insertCmd.Parameters.AddWithValue("@model", a.Model);
            insertCmd.Parameters.AddWithValue("@releaseYear", a.releaseYear);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();

        }


        //Read All entries
        //return all entries from table

        public static List<AutoShop> GetAllAutoShops()
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            con.Open();

            SqlDataReader reader = insertCmd.ExecuteReader();


            List<AutoShop> autoshops = new List<AutoShop>();
            while (reader.Read())
            {
                string make = reader["Make"].ToString();
                string model = reader["Model"].ToString();
                string releaseYear = reader["releaseYear"].ToString();
                string userStatus = reader["userStatus"].ToString();

                AutoShop tempAutoShop = new AutoShop(make, model, releaseYear, userStatus);
                autoshops.Add(tempAutoShop);
            }

            con.Close();


            return autoshops;
        }

        //Read individually selected entries
        //return selected entry from table as list<String>

        public static List<String> GetSelectedAutoShop(string Make, string Model, string ReleaseYear, string UserStatus)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            string make = Make;
            string model = Model;
            string releaseYear = ReleaseYear;
            string userStatus = UserStatus;

            insertCmd.CommandText = "SELECT * FROM AutoShop WHERE Make = @make, Model = @model, " +
                "releaseYear = @releaseYear, userStatus = @userStatus";

            insertCmd.Parameters.AddWithValue("@make", make);
            insertCmd.Parameters.AddWithValue("model", model);
            insertCmd.Parameters.AddWithValue("releaseYear", releaseYear);
            insertCmd.Parameters.AddWithValue("userStatus", userStatus);




            SqlDataReader reader = insertCmd.ExecuteReader();
            con.Open();
            List<String> selectAutoShops = new List<String>();
            while (reader.Read())
            {
                selectAutoShops.Add(reader[0].ToString());
            }

            return selectAutoShops;

            con.Close();


        }


        //update current entry
        //If AutoShop already exists, overwrite old data.

        public static void update(AutoShop a)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "UPDATE AutoShop SET Make = @make, Model = @model, " +
                "releaseYear = @releaseYear, userStatus = @userStatus " +
                " WHERE autoShopId = @autoShopId";

            insertCmd.Parameters.AddWithValue("@autoShopId", a.autoShopId);
            insertCmd.Parameters.AddWithValue("@make", a.Make);
            insertCmd.Parameters.AddWithValue("@model", a.Model);
            insertCmd.Parameters.AddWithValue("@releaseYear", a.releaseYear);
            insertCmd.Parameters.AddWithValue("@userStatus", a.userStatus);


            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        //delete entry
        //If AutoShop exists, delete entry from table

        public static void delete(AutoShop a)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "DELETE FROM AutoShop WHERE Make = @make, "
                + "Model = @model, releaseYear = @releaseYear, userStatus = @userStatus";

            insertCmd.Parameters.AddWithValue("@make", a.Make);
            insertCmd.Parameters.AddWithValue("@model", a.Model);
            insertCmd.Parameters.AddWithValue("@releaseYear", a.releaseYear);
            insertCmd.Parameters.AddWithValue("@userStatus", a.userStatus);

            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
