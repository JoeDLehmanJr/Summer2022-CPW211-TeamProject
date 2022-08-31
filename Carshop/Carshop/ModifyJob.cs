using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Carshop
{
    static class ModifyJob
    {
        public static void Create(Job j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO Job(jobCategory)"
                + " VALUES(@jobCategory)";

            insertCmd.Parameters.AddWithValue("@jobCategory", j.JobCategory);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();

        }


        //Read All entries
        //return all entries from table

        public static List<Job> GetAllJobs()
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            con.Open();

            SqlDataReader reader = insertCmd.ExecuteReader();


            List<Job> jobs = new List<Job>();
            while (reader.Read())
            {
                string jobCategory = reader["jobCategory"].ToString();

                Job tempJob = new Job(jobCategory);
                jobs.Add(tempJob);
            }

            con.Close();


            return jobs;
        }

        //Read individually selected entries
        //return selected entry from table as list<String>

        public static List<String> GetSelectedJob(string jobCategory)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            string jCategory = jobCategory;

            insertCmd.CommandText = "SELECT * FROM Job WHERE jobCategory = @jobCategory";

            insertCmd.Parameters.AddWithValue("@jobCategory", jCategory);




            SqlDataReader reader = insertCmd.ExecuteReader();
            con.Open();
            List<String> selectJob = new List<String>();
            while (reader.Read())
            {
                selectJob.Add(reader[0].ToString());
            }

            return selectJob;

            con.Close();


        }


        //update current entry
        //If job already exists, overwrite old data.

        public static void update(Job j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "UPDATE Job SET jobCategory = @jobCategory " +
                "WHERE jobId = @jobId";

            insertCmd.Parameters.AddWithValue("@jobId", j.JobId);
            insertCmd.Parameters.AddWithValue("@jobCategory", j.JobCategory);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        //delete entry
        //If job exists, delete entry from table

        public static void delete(Job j)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "DELETE FROM Job WHERE jobCategory = @jobCategory";

            insertCmd.Parameters.AddWithValue("@jobCategory", j.JobCategory);

            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
