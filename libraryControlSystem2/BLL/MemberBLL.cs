using System;
using System.Data;
using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class MemberBLL
    {
        // ÜYE EKLE
        public void AddMember(
            string firstName,
            string lastName,
            string phone,
            string email)
        {
            if (string.IsNullOrWhiteSpace(firstName))
                throw new Exception("Üye adı boş olamaz.");

            if (string.IsNullOrWhiteSpace(lastName))
                throw new Exception("Üye soyadı boş olamaz.");

            MemberDAL memberDal = new MemberDAL();
            memberDal.AddMember(firstName, lastName, phone, email);
        }

        // ÜYELERİ LİSTELE
        public DataTable GetAllMembers()
        {
            MemberDAL memberDal = new MemberDAL();
            return memberDal.GetAllMembers();
        }
    }
}
