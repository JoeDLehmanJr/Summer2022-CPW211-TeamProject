using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Carshop
{
    static class ModifyPayment
    {
        public static void Create(PaymentType p)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();

            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            insertCmd.CommandText = "INSERT INTO PaymentType(cardType, cardNumber, " +
                "dateOfExpiration, cvs, authorizationNumber)"
                + " VALUES(@cardType, @cardNumber, @dateOfExpiration, @cvs, @authorizationNumber)";

            insertCmd.Parameters.AddWithValue("@cardType", p.CardType);
            insertCmd.Parameters.AddWithValue("@cardNumber", p.CardNumber);
            insertCmd.Parameters.AddWithValue("@dateOfExpiration", p.DateOfExpiration);
            insertCmd.Parameters.AddWithValue("@cvs", p.Cvs);
            insertCmd.Parameters.AddWithValue("@authorizationNumber", p.AuthorizationNumber);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();

        }


        //Read All entries
        //return all entries from table

        public static List<PaymentType> GetAllPaymentTypes()
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();
            insertCmd.Connection = con;

            con.Open();

            SqlDataReader reader = insertCmd.ExecuteReader();


            List<PaymentType> paymentTypes = new List<PaymentType>();
            while (reader.Read())
            {
                string cardType = reader["cardType"].ToString();
                string cardNumber = reader["cardNumber"].ToString();
                string dateOfExpiration = reader["dateOfExpiration"].ToString();
                string cvs = reader["cvs"].ToString();
                string authorizationNumber = reader["authorizationNumber"].ToString();

                PaymentType tempPaymentType = new PaymentType(cardType, cardNumber, 
                    dateOfExpiration, cvs, authorizationNumber);
                paymentTypes.Add(tempPaymentType);
            }

            con.Close();


            return paymentTypes;
        }

        //Read individually selected entries
        //return selected entry from table as list<String>

        public static List<String> GetSelectedPaymentType(string cardType, string cardNumber,
            string dateOfExpiration, string Cvs, string authorizationNumber)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            string cType = cardType;
            string cNumber = cardNumber;
            string doe = dateOfExpiration;
            string cvs = Cvs;
            string aNumber = authorizationNumber;

            insertCmd.CommandText = "SELECT * FROM PaymentType WHERE " +
                "cardType = @cardType, cardNumber = @cardNumber, dateOfExpiration = " +
                "@dateOfExpiration, cvs = @cvs, authorizationNumber = @authorizationNumber";

            insertCmd.Parameters.AddWithValue("@cardType", cType);
            insertCmd.Parameters.AddWithValue("@cardNumber", cNumber);
            insertCmd.Parameters.AddWithValue("@dateOfExpiration", doe);
            insertCmd.Parameters.AddWithValue("@cvs", cvs);
            insertCmd.Parameters.AddWithValue("@authorizationNumber", aNumber);


            SqlDataReader reader = insertCmd.ExecuteReader();
            con.Open();
            List<String> selectPaymentType = new List<String>();
            while (reader.Read())
            {
                selectPaymentType.Add(reader[0].ToString());
            }

            return selectPaymentType;

            con.Close();


        }


        //update current entry
        //If paymentType already exists, overwrite old data.

        public static void update(PaymentType p)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "UPDATE PaymentType SET cardType = @cardType " +
                "cardNumber = @cardNumber, dateOfExpiration = @dateOfExpiration, " +
                "cvs = @cvs, authorizationNumber = @authorizationNumber" +
                " WHERE paymentId = @paymentId";

            insertCmd.Parameters.AddWithValue("@paymentId", p.PaymentTypeId);
            insertCmd.Parameters.AddWithValue("@cardType", p.CardType);
            insertCmd.Parameters.AddWithValue("@cardNumber", p.CardNumber);
            insertCmd.Parameters.AddWithValue("@dateOfExpiration", p.DateOfExpiration);
            insertCmd.Parameters.AddWithValue("@cvs", p.Cvs);
            insertCmd.Parameters.AddWithValue("@authorizationNumber", p.AuthorizationNumber);

            //Open con, execute query, close con
            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }

        //delete entry
        //If paymentType exists, delete entry from table

        public static void delete(PaymentType p)
        {
            SqlConnection con = CarshopDB.GetDatabaseConnection();
            SqlCommand insertCmd = new SqlCommand();

            insertCmd.Connection = con;

            insertCmd.CommandText = "DELETE FROM PaymentType WHERE cardType = @cardType, " +
                "cardNumber = @cardNumber, dateOfExpiration = @dateOfExpiration, cvs = @cvs, " +
                "authorizationNumber = @authorizationNumber";

            insertCmd.Parameters.AddWithValue("@cardType", p.CardType);
            insertCmd.Parameters.AddWithValue("@cardNumber", p.CardNumber);
            insertCmd.Parameters.AddWithValue("@dateOfExpiration", p.DateOfExpiration);
            insertCmd.Parameters.AddWithValue("@cvs", p.Cvs);
            insertCmd.Parameters.AddWithValue("@authorizationNumber", p.AuthorizationNumber);

            con.Open();
            insertCmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
