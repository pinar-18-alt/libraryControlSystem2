using System.Data;
using MySql.Data.MySqlClient;

namespace libraryControlSystem2.DAL
{
    public class MemberDAL
    {
      
        public DataTable GetAllMembers()
        {
            DbConnection db = new DbConnection();

            string query = "SELECT * FROM Members";
            MySqlDataAdapter da =
                new MySqlDataAdapter(query, db.OpenConnection());

            DataTable dt = new DataTable();
            da.Fill(dt);

            db.CloseConnection();
            return dt;
        }

       
        public void AddMember(
            string firstName,
            string lastName,
            string phone,
            string email)
        {
            DbConnection db = new DbConnection();

            string query = @"INSERT INTO Members 
                            (FirstName, LastName, Phone, Email, RegisterDate)
                            VALUES
                            (@FirstName, @LastName, @Phone, @Email, NOW())";

            MySqlCommand cmd =
                new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        
        public void UpdateMember(
            int memberId,
            string firstName,
            string lastName,
            string phone,
            string email)
        {
            DbConnection db = new DbConnection();

            string query = @"UPDATE Members SET
                            FirstName = @FirstName,
                            LastName = @LastName,
                            Phone = @Phone,
                            Email = @Email
                            WHERE MemberID = @MemberID";

            MySqlCommand cmd =
                new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@MemberID", memberId);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }

        
        public void DeleteMember(int memberId)
        {
            DbConnection db = new DbConnection();

            string query = "DELETE FROM Members WHERE MemberID = @MemberID";
            MySqlCommand cmd =
                new MySqlCommand(query, db.OpenConnection());

            cmd.Parameters.AddWithValue("@MemberID", memberId);

            cmd.ExecuteNonQuery();
            db.CloseConnection();
        }
    }
}
