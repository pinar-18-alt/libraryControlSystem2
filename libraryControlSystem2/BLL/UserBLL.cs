using libraryControlSystem2.DAL;
using System.Data;

namespace libraryControlSystem2.BLL
{
    public class UserBLL
    {
        public DataTable Login(string username, string password)
        {
            UserDAL dal = new UserDAL();
            return dal.Login(username, password);
        }
    }
}
