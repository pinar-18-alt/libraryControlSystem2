using MySql.Data.MySqlClient;
using System;

namespace libraryControlSystem2.DAL
{
    public class DashboardDAL
    {
        public int GetTotalBookCount()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Books";
            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            db.CloseConnection();
            return count;
        }

        public int GetBorrowedBookCount()
        {
            DbConnection db = new DbConnection();
            string query = "SELECT COUNT(*) FROM Borrows WHERE ReturnDate IS NULL";
            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            db.CloseConnection();
            return count;
        }

        public int GetDueSoonCount()
        {
            DbConnection db = new DbConnection();
            string query = @"
                SELECT COUNT(*) FROM Borrows
                WHERE ReturnDate IS NULL
                AND DATEDIFF(DueDate, CURDATE()) <= 3
            ";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            db.CloseConnection();
            return count;
        }
    }
}
