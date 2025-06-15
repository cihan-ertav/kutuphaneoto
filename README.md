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
