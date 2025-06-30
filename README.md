# 📚 Kütüphane Otomasyon Sistemi

Windows Forms ile geliştirilen bu masaüstü uygulama, küçük ve orta ölçekli kütüphaneler için temel seviye bir otomasyon sistemidir. Kitap ve üye kayıtlarını takip eder, emanet işlemlerini yönetir ve basit istatistiksel raporlar sunar.

---

## 🚀 Özellikler

- 🔐 Kullanıcı girişi (Form2)
- 📖 Kitap ekleme, silme, güncelleme ve listeleme (Form3, Form6)
- 👤 Üye kayıt işlemleri ve listeleme (Form4, Form5)
- 🔄 Kitap ödünç verme ve iade işlemleri (Form7, Form8, Form9)
- ⏰ Geciken kitapları listeleme (Form12)
- 📊 En çok okunan kitapları raporlama (Form13)
- 💾 Veriler `.csv` dosyalarında saklanır (veritabanı gerektirmez)

---

## 📁 Proje Yapısı

```
kutuphaneoto/
├── kutuphane_otomasyon.sln        → Visual Studio çözüm dosyası
└── kutuphane_otomasyon/           → Windows Forms uygulama klasörü
    ├── Form2.cs                   → Giriş ekranı
    ├── Form3.cs                   → Kitap ekleme
    ├── ...
    └── *.csv                      → Veri dosyaları
```

---

## 🛠 Gereksinimler

- .NET Framework **4.7.1** veya üzeri  
- Visual Studio **2017** veya daha yeni bir sürüm

---

## ⚙️ Kurulum

1. Bu projeyi klonlayın:
   ```bash
   git clone https://github.com/cihan-ertav/kutuphaneoto.git
   ```

2. `kutuphane_otomasyon.sln` dosyasını Visual Studio ile açın.

3. Projeyi derleyin ve çalıştırın (`F5`).

📁 **Not:** CSV dosyaları uygulamanın bulunduğu dizine otomatik olarak oluşturulur. Yol ayarlarını dilerseniz kod içinden özelleştirebilirsiniz.

---

## 🎯 Kullanım Senaryosu

- Kütüphane görevlisi giriş yapar.
- Yeni kitapları ve üyeleri ekler.
- Kitap ödünç/iade işlemleri yapılır.
- Geciken kitaplar ve en çok okunanlar raporlanır.

---

## 👨‍💻 Geliştirici

Cihan Ertav – [GitHub Profili](https://github.com/cihan-ertav)

---

## 🪪 Lisans

MIT Lisansı – Dilediğin gibi kullan, yıldız atmayı unutma. ⭐

## görseller

![image](https://github.com/user-attachments/assets/09112997-7935-4894-8844-23a7a15eaf4a)
![image](https://github.com/user-attachments/assets/2a2a2891-6956-43ef-ba66-8fa0ada21257)
![image](https://github.com/user-attachments/assets/ab780f3e-a9cf-4385-9611-9b222b7b7406)
![image](https://github.com/user-attachments/assets/d9703572-23ed-423a-97be-cb3f484422d3)
![image](https://github.com/user-attachments/assets/e74b92ea-3fb4-4cb9-a49d-9f0a4caa3e66)


