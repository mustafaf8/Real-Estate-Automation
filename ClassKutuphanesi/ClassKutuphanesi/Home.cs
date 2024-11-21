using System;
using System.IO;


namespace ClassKutuphanesi

{
    using System.IO;
    public class Home
    {
         public enum EvTur
         {
             Daire,
             Bahceli,
             Dubleks,
             Mustakil,
             Dükkan
             
         }
         public enum Semti
         {
             Adalar,
             Arnavutköy,
             Ataşehir,
             Avcılar,
             Bağcılar,
             Bahçelievler,
             Bakırköy,
             Başakşehir,
             Bayrampaşa,
             Beşiktaş,
             Beykoz,
             Beylikdüzü,
             Beyoğlu,
             Büyükçekmece,
             Çatalca,
             Çekmeköy,
             Esenler,
             Esenyurt,
             Eyüpsultan,
             Fatih,
             Gaziosmanpaşa,
             Güngören,
             Kadıköy,
             Kağıthane,
             Kartal,
             Küçükçekmece,
             Maltepe,
             Pendik,
             Sancaktepe,
             Sarıyer,
             Silivri,
             Sultanbeyli,
             Sultangazi,
             Şile,
             Şişli,
             Tuzla,
             Ümraniye,
             Üsküdar,
             Zeytinburnu,
             Selçuklu,
             Meram,
             Karatay,
         }

         protected int odaSayisi;
         protected int katNumarasi;
         protected Semti semt;
         protected double alani;
         protected DateTime yapimTarihi;
         protected EvTur turu;
         protected bool aktif;
         protected int emlakNumarasi;
       
         public int OdaSayisi
         {
             get { return odaSayisi; }
             set
             {
                 if (value < 0)
                 {
                     odaSayisi = 0;
                    
                 }
                 else
                 {
                     odaSayisi = value;
                     LogYaz($"Oda Sayisi değeri atandı: {odaSayisi}");
                 }
             }
         }

         public int KatNumarasi
         {
             get { return katNumarasi; }
             set
             {
                 katNumarasi = value;
                 LogYaz($"Kat Numarasi değeri atandı: {katNumarasi}");
             }
         }


         public Semti Semt
         {
             get { return semt; }
             set
             {
                 semt = value;
                 LogYaz($"Semt değeri atandı: {semt}");
             }
         }


         public double Alani
         {
             get { return alani; }
             set
             {
                 if (value > 0)
                 {
                     alani = value;
                     LogYaz($"Alan değeri atandı: {alani}");
                 }
             }
         }


         public DateTime YapimTarihi
         {
             get { return yapimTarihi; }
             set
             {
                 yapimTarihi = value;
                 LogYaz($"Yapım Tarihi değeri atandı: {yapimTarihi}");
             }
         }

         public EvTur Turu
         {
             get { return turu; }
             set
             {
                 turu = value;
                 LogYaz($"Türü değeri atandı: {turu}");
             }
         }

         public bool Aktif
         {
             get { return aktif; }
             set
             {
                 aktif = value;
                 LogYaz($"Aktif durumu değeri atandı: {aktif}");
             }
         }

         public int EmlakNumarasi
         {
             get { return emlakNumarasi; }
             set
             {
                 emlakNumarasi = value;
                 LogYaz($"Emlak Numarası değeri atandı: {emlakNumarasi}");
             }
         }

        private void LogYaz(string mesaj)
        {
            try
            {
               
                string logKlasoru = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                if (!Directory.Exists(logKlasoru))
                {
                    Directory.CreateDirectory(logKlasoru);
                }
                
                string logDosyaYolu = Path.Combine(logKlasoru, "log.txt");


                using (StreamWriter writer = new StreamWriter(logDosyaYolu, true))
                {
                    writer.WriteLine($"{DateTime.Now}: {mesaj}");
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Log yazma sırasında bir hata oluştu: {ex.Message}");
            }
        }




        public virtual string EvBilgileri()
        {
      
             return string.Format("Ev Bilgileri:\nOda Sayısı: {0}\nKat Numarası: {1}\nSemt: {2}\nAlanı: {3}\nYapım Tarihi: {4}\nTürü: {5}\nAktif: {6}\nEmlak Numarası: {7}\n",
                                      OdaSayisi, KatNumarasi, Semt, Alani, YapimTarihi, Turu, Aktif, EmlakNumarasi);
        }
         
         public double FiyatHesapla()
         {
             double katsayi;

             try
             {
                 string dosyaYolu = "room_cost.txt";
                 if (File.Exists(dosyaYolu))
                 {
                     string katsayiStr = File.ReadAllText(dosyaYolu);
                     if (double.TryParse(katsayiStr, out katsayi))
                     {

                         return OdaSayisi * katsayi;
                     }
                     else
                     {
                    
                         return -1; 
                     }
                 }
                 else
                 {
                
                     katsayi = 200;
                     return OdaSayisi * katsayi;
                 }
             }
             catch (Exception ex)
             {
             
                 return -1; 
             }
         }
         
         public Home(int odaSayisi, int katNumarasi, Semti semt, double alani, DateTime yapimTarihi, EvTur turu, bool aktif, int emlakNumarasi)
         {

            OdaSayisi = odaSayisi;
            KatNumarasi = katNumarasi;
            Semt = semt;
            Alani = alani;
            YapimTarihi = yapimTarihi;
            Turu = turu;
            Aktif = aktif;
            EmlakNumarasi = emlakNumarasi;
         }

    }

}

