using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace libraryControlSystem2.DAL
{
    public class BorrowDAL
    {
        // KİTAP ÖDÜNÇ ALMA
        public void BorrowBook(int bookId, int memberId, DateTime dueDate)
        {
            DbConnection db = new DbConnection();

            string query = @"INSERT INTO Borrows 
                            (BookID, MemberID, BorrowDate, DueDate)
                            VALUES
                            (@bookId, @memberId, @borrowDate, @dueDate)";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@bookId", bookId);
            cmd.Parameters.AddWithValue("@memberId", memberId);
            cmd.Parameters.AddWithValue("@borrowDate", DateTime.Now);
            cmd.Parameters.AddWithValue("@dueDate", dueDate);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        // İADESİ YAKLAŞAN KİTAPLAR (RAPOR)
        public DataTable GetDueSoonBorrows()
        {
            DbConnection db = new DbConnection();

            string query = @"SELECT 
                                b.BorrowID,
                                bk.Title,
                                m.Name,
                                b.BorrowDate,
                                b.DueDate
                             FROM Borrows b
                             JOIN Books bk ON b.BookID = bk.BookID
                             JOIN Members m ON b.MemberID = m.MemberID
                             WHERE b.ReturnDate IS NULL
                             AND b.DueDate <= DATE_ADD(CURDATE(), INTERVAL 3 DAY)";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
    }
}
