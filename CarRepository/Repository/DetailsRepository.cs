using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DetailsRepository : IDetailsRepository
    {
        public IEnumerable<Detail> GetDetails()
        {
            string connectionString = @"Data Source=.\;Initial Catalog=AutoDB;Integrated Security=True";
            var query = "SELECT * FROM Details";
            var result = new List<Detail>();
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Detail
                        {
                            Id = (int)reader["Id"],
                            Cars_Id = (int)reader["Cars_Id"],
                            Name = (string)reader["Name"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }
    }
}
