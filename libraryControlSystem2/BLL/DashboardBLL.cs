using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class DashboardBLL
    {
        DashboardDAL dal = new DashboardDAL();

        public int TotalBooks()
        {
            return dal.GetTotalBookCount();
        }

        public int BorrowedBooks()
        {
            return dal.GetBorrowedBookCount();
        }

        public int DueSoonBooks()
        {
            return dal.GetDueSoonCount();
        }
    }
}
