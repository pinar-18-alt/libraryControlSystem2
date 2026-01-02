using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace libraryControlSystem2.DAL
{
    public class BookDAL
    {
        // KİTAP EKLEME
        public void AddBook(
            string isbn,
            string title,
            string author,
            string publisher,
            int publishYear,
            int stock)
        {
            DbConnection db = new DbConnection();

            string query = @"INSERT INTO Books 
                            (ISBN, Title, Author, Publisher, PublishYear, Stock)
                            VALUES
                            (@isbn, @title, @author, @publisher, @year, @stock)";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@year", publishYear);
            cmd.Parameters.AddWithValue("@stock", stock);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }
        public void DeleteBook(int id)
        {
            DbConnection db = new DbConnection();

            string query = "DELETE FROM Books WHERE BookID = @id";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }


        // KİTAPLARI LİSTELEME (RAPORLAMA)
        public DataTable GetAllBooks()
        {
            DbConnection db = new DbConnection();

            string query = "SELECT * FROM Books";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
        public void UpdateBook(
    int id,
    string isbn,
    string title,
    string author,
    string publisher,
    int publishYear,
    int stock)
        {
            DbConnection db = new DbConnection();

            string query = @"UPDATE Books SET
                        ISBN = @isbn,
                        Title = @title,
                        Author = @author,
                        Publisher = @publisher,
                        PublishYear = @year,
                        Stock = @stock
                     WHERE BookID = @id";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@author", author);
            cmd.Parameters.AddWithValue("@publisher", publisher);
            cmd.Parameters.AddWithValue("@year", publishYear);
            cmd.Parameters.AddWithValue("@stock", stock);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }
        public DataTable GetLowStockBooks()
        {
            DbConnection db = new DbConnection();

            string query = "SELECT * FROM Books WHERE Stock <= 3";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
        public DataTable SearchBooks(string keyword)
        {
            DbConnection db = new DbConnection();

            string query = @"SELECT * FROM Books
                     WHERE ISBN LIKE @key
                     OR Title LIKE @key";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());
            cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }



    }
}
