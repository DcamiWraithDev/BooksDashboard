using BoekDB.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BoekDB.Data
{
    public class Books
    {
        // Haal het totaal aantal boeken op, eventueel gefilterd op auteur
        public int GetBookCount(int? authorId = null)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(id) FROM books";
                if (authorId.HasValue)
                {
                    query += " WHERE author_id = @AuthorId";
                }

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Haal de gemiddelde prijs van boeken op, eventueel gefilterd op auteur
        public decimal GetAverageBookPrice(int? authorId = null)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT AVG(price) FROM books";
                if (authorId.HasValue)
                    query += " WHERE author_id = @AuthorId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    var result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
        }

        // Haal het minimum en maximum aantal pagina's van boeken op, eventueel gefilterd op auteur
        public (decimal MinPages, decimal MaxPages) GetMinAndMaxPageCount(int? authorId = null)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT MIN(pages), MAX(pages) FROM books";
                if (authorId.HasValue)
                    query += " WHERE author_id = @AuthorId";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal min = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                            decimal max = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                            return (min, max);
                        }
                        else
                        {
                            return (0, 0);
                        }
                    }
                }
            }
        }

        // Haal het aantal uitgebracht boeken per jaar op, eventueel gefilterd op auteur
        public List<BookChart> GetReleaseBooksPerYears(int? authorId = null)
        {
            var result = new List<BookChart>();

            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                                SELECT YEAR(release_date) AS release_year,
                                       COUNT(*) AS released_book_count
                                FROM books
                                WHERE release_date IS NOT NULL";

                if (authorId.HasValue)
                    query += " AND author_id = @AuthorId";

                query += " GROUP BY release_year ORDER BY release_year";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(new BookChart
                            {
                                Year = reader.GetInt32("release_year"),
                                ReleasedBookCount = reader.GetInt32("released_book_count")
                            });
                        }
                    }
                }
            }

            // Vul ontbrekende jaren in met 0
            if (result.Any())
            {
                int minYear = result.Min(r => r.Year) - 1;
                int maxYear = result.Max(r => r.Year) + 1;

                var fullList = new List<BookChart>();
                for (int year = minYear; year <= maxYear; year++)
                {
                    var item = result.FirstOrDefault(r => r.Year == year);
                    fullList.Add(item ?? new BookChart { Year = year, ReleasedBookCount = 0 });
                }

                result = fullList;
            }

            return result;
        }

    }
}
