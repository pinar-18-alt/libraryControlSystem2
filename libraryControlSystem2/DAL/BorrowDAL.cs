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

        // İADESİ YAKLAŞAN / GECİKEN KİTAPLAR (RAPOR)
        public DataTable GetDueSoonBorrows()
        {
            DbConnection db = new DbConnection();

            string query = @"
        SELECT 
            b.Title AS Kitap,
            CONCAT(m.FirstName, ' ', m.LastName) AS Uye,
            br.BorrowDate,
            br.DueDate,
            DATEDIFF(br.DueDate, CURDATE()) AS KalanGun
        FROM Borrows br
        JOIN Books b ON br.BookID = b.BookID
        JOIN Members m ON br.MemberID = m.MemberID
        WHERE br.ReturnDate IS NULL
          AND br.DueDate BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 3 DAY)
        ORDER BY br.DueDate ASC
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
        public void ReturnBook(int borrowId)
        {
            DbConnection db = new DbConnection();

            string query = @"
        UPDATE Borrows
        SET ReturnDate = CURDATE()
        WHERE BorrowID = @id;

        UPDATE Books
        SET Stock = Stock + 1
        WHERE BookID = (
            SELECT BookID FROM Borrows WHERE BorrowID = @id
        );
    ";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            cmd.Parameters.AddWithValue("@id", borrowId);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

    }
}

