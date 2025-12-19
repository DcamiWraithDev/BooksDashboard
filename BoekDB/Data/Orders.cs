using BoekDB.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;


namespace BoekDB.Data
{
    public class Orders
    {
        public class BookSalesStat
        {
            public string Title { get; set; }
            public decimal Price { get; set; }
            public int Amount { get; set; }
        }


        public BookSalesStat GetMostSoldBook(int? authorId = null)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT 
                b.title,
                b.price,
                SUM(oi.quantity) AS total_amount
            FROM books b
            JOIN order_items oi ON oi.book_id = b.id
        ";

                if (authorId.HasValue)
                    query += " WHERE b.author_id = @AuthorId ";

                query += @"
            GROUP BY b.id, b.title, b.price
            ORDER BY total_amount DESC
            LIMIT 1;
        ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new BookSalesStat
                            {
                                Title = reader.GetString("title"),
                                Price = reader.GetDecimal("price"),
                                Amount = reader.GetInt32("total_amount")
                            };
                        }
                    }
                }
            }

            return null;
        }

        public BookSalesStat GetLeastSoldBook(int? authorId = null)
        {
            using (var conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT 
                b.title,
                b.price,
                SUM(oi.quantity) AS total_amount
            FROM books b
            JOIN order_items oi ON oi.book_id = b.id
        ";

                if (authorId.HasValue)
                    query += " WHERE b.author_id = @AuthorId ";

                query += @"
            GROUP BY b.id, b.title, b.price
            ORDER BY total_amount ASC
            LIMIT 1;
        ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (authorId.HasValue)
                        cmd.Parameters.AddWithValue("@AuthorId", authorId.Value);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new BookSalesStat
                            {
                                Title = reader.GetString("title"),
                                Price = reader.GetDecimal("price"),
                                Amount = reader.GetInt32("total_amount")
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
}
