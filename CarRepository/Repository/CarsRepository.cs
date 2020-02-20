using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class CarsRepository : ICarsRepository
    {
        public IEnumerable<Car> GetCars()
        {
            string connectionString = @"Data Source=.\;Initial Catalog=AutoDB;Integrated Security=True";
            var query = "SELECT * FROM Cars";
            var result = new List<Car>();
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
                        //Console.WriteLine("{0}{1}",reader.GetString(1), reader.GetInt32(0));
                        result.Add(new Car
                        {
                            Id = (int)reader["Id"],
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
