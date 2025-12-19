using MySql.Data.MySqlClient;

namespace BoekDB
{
    public static class DatabaseConnection
    {
        private static readonly string _connectionString =
            "server=localhost;database=bolcom;user=root;password=;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}
