using System;
using System.Data;
using libraryControlSystem2.DAL;

namespace libraryControlSystem2.BLL
{
    public class MemberBLL
    {
        // EKLE
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

            MemberDAL dal = new MemberDAL();
            dal.AddMember(firstName, lastName, phone, email);
        }

        // LİSTELE
        public DataTable GetAllMembers()
        {
            MemberDAL dal = new MemberDAL();
            return dal.GetAllMembers();
        }

        // GÜNCELLE
        public void UpdateMember(
            int memberId,
            string firstName,
            string lastName,
            string phone,
            string email)
        {
            if (memberId <= 0)
                throw new Exception("Geçersiz üye.");

            MemberDAL dal = new MemberDAL();
            dal.UpdateMember(memberId, firstName, lastName, phone, email);
        }

        //  SİL
        public void DeleteMember(int memberId)
        {
            if (memberId <= 0)
                throw new Exception("Geçersiz üye.");

            MemberDAL dal = new MemberDAL();
            dal.DeleteMember(memberId);
        }
    }
}
