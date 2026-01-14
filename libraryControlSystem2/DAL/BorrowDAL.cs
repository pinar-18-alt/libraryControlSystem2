using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace libraryControlSystem2.DAL
{
    public class BorrowDAL
    {
        
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
        public DataTable GetActiveBorrows()
        {
            DbConnection db = new DbConnection();

            string query = @"
        SELECT 
            br.BorrowID,
            b.Title AS Kitap,
            CONCAT(m.FirstName, ' ', m.LastName) AS Uye,
            br.BorrowDate,
            br.DueDate
        FROM Borrows br
        JOIN Books b ON br.BookID = b.BookID
        JOIN Members m ON br.MemberID = m.MemberID
        WHERE br.ReturnDate IS NULL
        ORDER BY br.BorrowDate DESC
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            db.CloseConnection();
            return dt;
        }
        
        public DataTable GetLateBorrows()
        {
            DbConnection db = new DbConnection();

            string query = @"
        SELECT 
            b.Title AS Kitap,
            CONCAT(m.FirstName, ' ', m.LastName) AS Uye,
            br.DueDate AS IadeTarihi,
            DATEDIFF(CURDATE(), br.DueDate) AS GecikmeGun
        FROM Borrows br
        JOIN Books b ON br.BookID = b.BookID
        JOIN Members m ON br.MemberID = m.MemberID
        WHERE br.ReturnDate IS NULL
        AND br.DueDate < CURDATE()
        ORDER BY br.DueDate ASC
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
        
        public DataTable GetMostBorrowedBooks()
        {
            DbConnection db = new DbConnection();

            string query = @"
        SELECT 
            b.Title AS Kitap,
            COUNT(*) AS OduncSayisi
        FROM Borrows br
        JOIN Books b ON br.BookID = b.BookID
        GROUP BY b.BookID
        ORDER BY OduncSayisi DESC
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
        
        public DataTable GetActiveMembers()
        {
            DbConnection db = new DbConnection();

            string query = @"
        SELECT 
            CONCAT(m.FirstName, ' ', m.LastName) AS Uye,
            COUNT(*) AS AktifOdunc
        FROM Borrows br
        JOIN Members m ON br.MemberID = m.MemberID
        WHERE br.ReturnDate IS NULL
        GROUP BY m.MemberID
        ORDER BY AktifOdunc DESC
    ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }



    }
}

