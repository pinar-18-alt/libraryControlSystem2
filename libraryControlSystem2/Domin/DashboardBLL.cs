using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class DashboardBLL
    {
        DashboardDAL dal = new DashboardDAL();

        public int TotalBooks() => dal.GetTotalBooks();
        public int TotalMembers() => dal.GetTotalMembers();
        public int ActiveBorrows() => dal.GetActiveBorrows();
        public int LateBorrows() => dal.GetLateBorrows();
    }
}
