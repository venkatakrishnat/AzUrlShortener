using System;
using System.Data.SqlClient;

public class SqlInjectionExample
{
    public void ExecuteQuery(string userInput)
    {
        string connectionString = "your_connection_string_here";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM Users WHERE Username = '" + userInput + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["Username"].ToString());
            }
        }
    }
}
