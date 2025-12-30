using MySql.Data.MySqlClient;
using System.Data;

namespace libraryControlSystem2.DAL
{
    public class DbConnection
    {
        private MySqlConnection connection;

        public DbConnection()
        {
            connection = new MySqlConnection(
                "Server=172.21.54.253;Database=26_132430006;Uid=26_132430006;Pwd=İnif123.;"
            );
        }

        public MySqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
