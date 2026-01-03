using System.Data;
using MySql.Data.MySqlClient;

namespace libraryControlSystem2.DAL
{
    public class UserDAL
    {
        public DataTable Login(string username, string password)
        {
            MySqlConnection conn = new MySqlConnection(DbConnection.ConnectionString);

            string query = @"SELECT * FROM Users 
                             WHERE Username=@u AND Password=@p";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@u", username);
            da.SelectCommand.Parameters.AddWithValue("@p", password);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
