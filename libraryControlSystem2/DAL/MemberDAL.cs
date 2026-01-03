using MySql.Data.MySqlClient;
using System.Data;

namespace libraryControlSystem2.DAL
{
    public class MemberDAL
    {
        // ÜYE EKLE
        public void AddMember(string firstName, string lastName, string phone, string email)
        {
            DbConnection db = new DbConnection();

            string query = @"INSERT INTO Members 
                            (FirstName, LastName, Phone, Email, RegisterDate)
                            VALUES
                            (@firstName, @lastName, @phone, @email, NOW())";

            MySqlCommand cmd = new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        // ÜYELERİ LİSTELE
        public DataTable GetAllMembers()
        {
            DbConnection db = new DbConnection();

            string query = "SELECT * FROM Members";

            MySqlDataAdapter da = new MySqlDataAdapter(query, db.OpenConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }
    }
}
