using MySql.Data.MySqlClient;
using System;

namespace libraryControlSystem2.DAL
{
    public class DashboardDAL
    {
        public int GetTotalBooks()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Books";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            db.CloseConnection();
            return result;
        }

        public int GetTotalMembers()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Members";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            db.CloseConnection();
            return result;
        }

        public int GetActiveBorrows()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Borrows WHERE ReturnDate IS NULL";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            db.CloseConnection();
            return result;
        }

        public int GetLateBorrows()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Borrows WHERE ReturnDate IS NULL AND DueDate < CURDATE()";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());

            db.CloseConnection();
            return result;
        }
    }
}
