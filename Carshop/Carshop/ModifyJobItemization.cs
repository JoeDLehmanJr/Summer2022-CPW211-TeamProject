using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Carshop
{
    static class ModifyJobItemization
    {
        public static void Create(JobItemization j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO JobItemization(jobType, itemCost)"
                + " VALUES(@jobType, @itemCost)";

            insertCmd.Parameters.AddWithValue("@jobType", j.JobType);
            insertCmd.Parameters.AddWithValue("@itemCost", j.ItemCost);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();

        }


        //Read All entries
        //return all entries from table

        public static List<JobItemization> GetAllJobItemizations()
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            con.Open();

            SqlDataReader reader = insertCmd.ExecuteReader();


            List<JobItemization> jobItemizations = new List<JobItemization>();
            while (reader.Read())
            {
                string jobType = reader["jobType"].ToString();
                string itemCost = reader["itemCost"].ToString();

                JobItemization tempJobItemization = new JobItemization(jobType, itemCost);
                jobItemizations.Add(tempJobItemization);
            }

            con.Close();


            return jobItemizations;
        }

        //Read individually selected entries
        //return selected entry from table as list<String>

        public static List<String> GetSelectedJobItemization(string jobType, string itemCost)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            string jType = jobType;
            string iCost = itemCost;

            insertCmd.CommandText = "SELECT * FROM JobItemization WHERE " +
                "jobType = @jobType, itemCost = @itemCost";

            insertCmd.Parameters.AddWithValue("@jobType", jType);
            insertCmd.Parameters.AddWithValue("@itemCost", iCost);




            SqlDataReader reader = insertCmd.ExecuteReader();
            con.Open();
            List<String> selectJobItemization = new List<String>();
            while (reader.Read())
            {
                selectJobItemization.Add(reader[0].ToString());
            }

            return selectJobItemization;

            con.Close();


        }


        //update current entry
        //If jobItemization already exists, overwrite old data.

        public static void update(JobItemization j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "UPDATE JobItemization SET jobType = @jobType " +
                "itemCost = @itemCost WHERE jobId = @jobId";

            insertCmd.Parameters.AddWithValue("@jobType", j.JobType);
            insertCmd.Parameters.AddWithValue("@itemCost", j.ItemCost);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        //delete entry
        //If jobItemization exists, delete entry from table

        public static void delete(JobItemization j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "DELETE FROM JobItemization WHERE jobType = @jobType, " +
                "itemCost = @itemCost";

            insertCmd.Parameters.AddWithValue("@jobType", j.JobType);
            insertCmd.Parameters.AddWithValue("@itemCost", j.ItemCost);

            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
