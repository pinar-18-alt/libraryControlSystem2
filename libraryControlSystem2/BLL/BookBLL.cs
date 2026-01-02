using System;
using System.Data;
using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class BookBLL
    {
        // KİTAPLARI LİSTELE (RAPORLAMA)
        public DataTable GetAllBooks()
        {
            BookDAL bookDal = new BookDAL();
            return bookDal.GetAllBooks();
        }

        // KİTAP EKLE
        public void AddBook(
            string isbn,
            string title,
            string author,
            string publisher,
            string publishYearText,
            string stockText)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                throw new Exception("ISBN boş olamaz.");

            if (string.IsNullOrWhiteSpace(title))
                throw new Exception("Kitap adı boş olamaz.");

            if (!int.TryParse(publishYearText, out int publishYear))
                throw new Exception("Basım yılı sayı olmalıdır.");

            if (publishYear < 1500 || publishYear > DateTime.Now.Year)
                throw new Exception("Geçersiz basım yılı.");

            if (!int.TryParse(stockText, out int stock))
                throw new Exception("Stok sayı olmalıdır.");

            if (stock < 0)
                throw new Exception("Stok 0'dan küçük olamaz.");

            BookDAL bookDal = new BookDAL();
            bookDal.AddBook(
                isbn,
                title,
                author,
                publisher,
                publishYear,
                stock
            );
        }

        // KİTAP SİL
        public void DeleteBook(int id)
        {
            if (id <= 0)
                throw new Exception("Geçersiz kitap ID.");

            BookDAL bookDal = new BookDAL();
            bookDal.DeleteBook(id);
        }
        public void UpdateBook(
    int id,
    string isbn,
    string title,
    string author,
    string publisher,
    string publishYearText,
    string stockText)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                throw new Exception("ISBN boş olamaz.");

            if (string.IsNullOrWhiteSpace(title))
                throw new Exception("Kitap adı boş olamaz.");

            if (!int.TryParse(publishYearText, out int publishYear))
                throw new Exception("Basım yılı sayı olmalıdır.");

            if (publishYear < 1500 || publishYear > DateTime.Now.Year)
                throw new Exception("Geçersiz basım yılı.");

            if (!int.TryParse(stockText, out int stock))
                throw new Exception("Stok sayı olmalıdır.");

            if (stock < 0)
                throw new Exception("Stok 0'dan küçük olamaz.");

            BookDAL bookDal = new BookDAL();
            bookDal.UpdateBook(
                id,
                isbn,
                title,
                author,
                publisher,
                publishYear,
                stock
            );
        }
        public DataTable GetLowStockBooks()
        {
            BookDAL bookDal = new BookDAL();
            return bookDal.GetLowStockBooks();
        }
        public DataTable SearchBooks(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                throw new Exception("Arama alanı boş olamaz.");

            BookDAL bookDal = new BookDAL();
            return bookDal.SearchBooks(keyword);
        }


    }
}
