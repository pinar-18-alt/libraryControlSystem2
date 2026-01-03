using System;
using System.Data;
using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class BorrowBLL
    {
        // KİTAP ÖDÜNÇ ALMA
        public void BorrowBook(int bookId, int memberId, DateTime dueDate)
        {
            if (bookId <= 0)
                throw new Exception("Kitap seçilmedi.");

            if (memberId <= 0)
                throw new Exception("Üye seçilmedi.");

            if (dueDate <= DateTime.Now)
                throw new Exception("İade tarihi bugünden sonra olmalıdır.");

            BorrowDAL borrowDal = new BorrowDAL();
            borrowDal.BorrowBook(bookId, memberId, dueDate);
        }
        public void ReturnBook(int borrowId)
        {
            if (borrowId <= 0)
                throw new Exception("Geçersiz ödünç kaydı.");

            BorrowDAL dal = new BorrowDAL();
            dal.ReturnBook(borrowId);
        }


        // İADESİ YAKLAŞAN KİTAPLAR (RAPORLAMA)
        public DataTable GetDueSoonBorrows()
        {
            BorrowDAL borrowDal = new BorrowDAL();
            return borrowDal.GetDueSoonBorrows();
        }
        public DataTable GetActiveBorrows()
        {
            BorrowDAL dal = new BorrowDAL();
            return dal.GetActiveBorrows();
        }
        // GECİKEN KİTAPLAR RAPORU
        public DataTable GetLateBorrows()
        {
            BorrowDAL dal = new BorrowDAL();
            return dal.GetLateBorrows();
        }
        // EN ÇOK ÖDÜNÇ ALINAN KİTAPLAR
        public DataTable GetMostBorrowedBooks()
        {
            BorrowDAL dal = new BorrowDAL();
            return dal.GetMostBorrowedBooks();
        }
        // AKTİF ÜYELER RAPORU
        public DataTable GetActiveMembers()
        {
            BorrowDAL dal = new BorrowDAL();
            return dal.GetActiveMembers();
        }

    }
}
