# 📚 Kütüphane Yönetim Sistemi

Kütüphane yönetim süreçlerini dijital ortama taşıyan bir **masaüstü uygulamasıdır**.  
Bu proje, kütüphane çalışanlarının **kitap, üye ve ödünç alma / iade işlemlerini** kolay ve düzenli bir şekilde yönetmesini sağlar.

Sistem; **kullanıcı yetkilendirme**, **kitap stok takibi** ve **raporlama** gibi temel kütüphane ihtiyaçlarını tek bir platformda bir araya getirir.

---

## 📌 Proje Özellikleri

### 🔐 Giriş ve Yetkilendirme Sistemi
- Kullanıcı doğrulama (**Admin / Staff / User** rolleri)
- Role göre sayfa ve işlem yetkileri

---

### 📖 Kitap İşlemleri
- Kitap ekleme, silme ve güncelleme  
- Kitap listeleme  
- Stok bilgisi takibi  
- Stokta azalan kitapların görüntülenmesi  
- Kitap arama özelliği  

---

### 👤 Üye İşlemleri
- Üye ekleme, güncelleme ve silme  
- Üye listeleme  

---

### 🔄 Ödünç / İade İşlemleri
- Kitap ödünç verme  
- Kitap iade alma  
- Aktif ödünç kayıtlarını görüntüleme  

---

### 📊 Raporlama
- Ödünç alma raporları (**Admin yetkisiyle**)  
- Kütüphane kullanım verilerinin izlenmesi  

---

### 🖥️ Kullanıcı Dostu Arayüz
- **Windows Forms** ile geliştirilmiş sade ve anlaşılır tasarım  
- Hover efektli butonlar  
- Merkezi konumlandırılmış formlar  
- Görsel destekli login ve dashboard ekranları  

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
