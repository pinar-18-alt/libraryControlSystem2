<img width="1209" height="573" alt="image" src="https://github.com/user-attachments/assets/b15c3240-a4b8-4443-be69-8f9bff9cb150" />

 usecase diyagramı
 
 
 
 # 📚 Kütüphane Yönetim Sistemi

Kütüphane yönetim süreçlerini dijital ortama taşıyan bir **masaüstü uygulamasıdır**.  
Bu proje, kütüphane çalışanlarının **kitap, üye ve ödünç alma / iade işlemlerini** kolay ve düzenli bir şekilde yönetmesini sağlar.

Sistem; **kullanıcı yetkilendirme**, **kitap stok takibi** ve **raporlama** gibi temel kütüphane ihtiyaçlarını tek bir platformda bir araya getirir.

---

## 📌 Proje Özellikleri

### 🔐 Giriş ve Yetkilendirme Sistemi
- Kullanıcı doğrulama (**Admin / Staff / User** rolleri)
- Role göre sayfa ve işlem yetkileri

<img width="405" height="474" alt="image" src="https://github.com/user-attachments/assets/a83bd524-391c-47ba-a91c-b8a6d8ce8a9e" />

---

### 📖 Kitap İşlemleri
- Kitap ekleme, silme ve güncelleme  
- Kitap listeleme  
- Stok bilgisi takibi  
- Stokta azalan kitapların görüntülenmesi  
- Kitap arama özelliği

  <img width="1681" height="787" alt="image" src="https://github.com/user-attachments/assets/3a5fa4ec-4369-47db-9e12-f0800dfcfd41" />


---

### 👤 Üye İşlemleri
- Üye ekleme, güncelleme ve silme  
- Üye listeleme  

<img width="1677" height="797" alt="image" src="https://github.com/user-attachments/assets/b7ab700c-5cf1-40d1-b3e7-8426158fca2f" />


---

### 🔄 Ödünç / İade İşlemleri
- Kitap ödünç verme  
- Kitap iade alma  
- Aktif ödünç kayıtlarını görüntüleme  

<img width="1679" height="797" alt="image" src="https://github.com/user-attachments/assets/7258c1af-54e6-4d45-a1f6-887c857e3bbf" />

---

### 📊 Raporlama
- Ödünç alma raporları (**Admin yetkisiyle**)  
- Kütüphane kullanım verilerinin izlenmesi  

<img width="1677" height="794" alt="image" src="https://github.com/user-attachments/assets/90dde87a-22a5-470b-ba60-15c60ed3a9c4" />


---

## 📂 Kullanılan Teknolojiler
- **C# (.NET Framework)**  
- **Windows Forms**  
- **MySQL** (Veritabanı)  
- **Katmanlı Mimari**
  - DAL (Data Access Layer)
  - BLL (Business Logic Layer)
  - UI (User Interface)
- **Nesne Tabanlı Programlama (OOP)**  

---

## 🧩 Mimari Yapı

Proje, sürdürülebilir ve okunabilir bir yapı sağlamak amacıyla **katmanlı mimari** kullanılarak geliştirilmiştir.

- **UI (User Interface):** Kullanıcı arayüzleri  
- **BLL (Business Logic Layer):** İş kuralları ve kontrol mekanizmaları  
- **DAL (Data Access Layer):** Veritabanı işlemleri  
- **Database:** MySQL  

---
