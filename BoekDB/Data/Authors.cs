using BoekDB.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BoekDB.Data
{
    public class Authors
    {
        // Haal alle auteurs op
        public List<Author> GetAuthors()
        {
            var result = new List<Author>();

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                                SELECT id, name
                                FROM authors
                                ORDER BY name;";

                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Author
                        {
                            Id = reader.GetInt32("id"),
                            Name = reader.GetString("name")
                        });
                    }
                }
            }

            return result;
        }
    }
}
