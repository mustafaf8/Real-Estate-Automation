using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassKutuphanesi.Home;

namespace ClassKutuphanesi
{
    public class SaleRegFunctions
    {
        private const string KDosyaAdi = "Kiralık.txt";
        private string kiralik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, KDosyaAdi);
        private const string SDosyaAdi = "Satılık.txt";
        private string satilik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SDosyaAdi);

        public void DosyaVarMi(string yol)
        {
            if (!File.Exists(yol))
            {
                Console.WriteLine("Dosya bulunamadı. Yeni dosya oluşturuluyor...");
                File.Create(yol).Close();
            }
        }
        public void KiraKayitlariDosyayaYaz(RentHome kayit)
        {
            using (StreamWriter writer = new StreamWriter(kiralik))
            {
                    string line = $"{kayit.OdaSayisi},{kayit.KatNumarasi},{kayit.Semt},{kayit.Alani},{kayit.YapimTarihi},{kayit.Turu},{kayit.Aktif},{kayit.EmlakNumarasi},{kayit.Depozito},{kayit.Kira}";
                    writer.WriteLine(line);
            }
        }

        public void SatilikKayitlariDosyayaYaz(SaleHome kayit)
        {
            using (StreamWriter writer = new StreamWriter(satilik))
            {         
                    string line = $"{kayit.OdaSayisi},{kayit.KatNumarasi},{kayit.Semt},{kayit.Alani},{kayit.YapimTarihi},{kayit.Turu},{kayit.Aktif},{kayit.EmlakNumarasi},{kayit.Fiyat}";
                    writer.WriteLine(line);
            }
        }

        public List<SaleHome> SatilikKayitlariDosyadanOku()
        {
            List<SaleHome> okunanKayitlar = new List<SaleHome>();

            DosyaVarMi(satilik);

            string[] satirlar = File.ReadAllLines(satilik);

            foreach (string satir in satirlar)
            {
                string[] split = satir.Split(',');

                SaleHome ev = new SaleHome(int.Parse(split[0]),int.Parse(split[1]),(Semti)Enum.Parse(typeof(Semti),split[2]),double.Parse(split[3]),DateTime.Parse(split[4]),(EvTur)Enum.Parse(typeof(EvTur),split[5]), bool.Parse(split[6]),int.Parse(split[7]),int.Parse(split[8]));

                okunanKayitlar.Add(ev);
            }

            return okunanKayitlar;
        }
        public List<RentHome> KiralikKayitlariDosyadanOku()
        {
            List<RentHome> okunanKayitlar = new List<RentHome>();

            DosyaVarMi(kiralik);

            string[] satirlar = File.ReadAllLines(kiralik);

            foreach (string satir in satirlar)
            {
                string[] split = satir.Split(',');

                RentHome ev = new RentHome(int.Parse(split[0]), int.Parse(split[1]), (Semti)Enum.Parse(typeof(Semti), split[2]), double.Parse(split[3]), DateTime.Parse(split[4]), (EvTur)Enum.Parse(typeof(EvTur), split[5]), bool.Parse(split[6]), int.Parse(split[7]), int.Parse(split[8]), int.Parse(split[9]));

                okunanKayitlar.Add(ev);
            }

            return okunanKayitlar;
        }


        public ListViewItem SatilikElemanAta(SaleHome ev)
        {

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(ev.OdaSayisi.ToString());
            item.SubItems.Add(ev.KatNumarasi.ToString());
            item.SubItems.Add(ev.Semt.ToString());
            item.SubItems.Add(ev.Alani.ToString());
            item.SubItems.Add(ev.YapimTarihi.ToString("dd.MM.yyyy"));
            item.SubItems.Add(ev.Turu.ToString());
            item.SubItems.Add(ev.Aktif.ToString());
            item.SubItems.Add(ev.EmlakNumarasi.ToString());
            item.SubItems.Add(ev.Fiyat.ToString());

            return item;

        }
        public ListViewItem kiralikElemanAta(RentHome ev)
        {

            ListViewItem item = new ListViewItem();
            item.SubItems.Add(ev.OdaSayisi.ToString()); 
            item.SubItems.Add(ev.KatNumarasi.ToString());
            item.SubItems.Add(ev.Semt.ToString());
            item.SubItems.Add(ev.Alani.ToString());
            item.SubItems.Add(ev.YapimTarihi.ToString("dd.MM.yyyy"));
            item.SubItems.Add(ev.Turu.ToString());
            item.SubItems.Add(ev.Aktif.ToString());
            item.SubItems.Add(ev.EmlakNumarasi.ToString());
            item.SubItems.Add(ev.Kira.ToString());
            item.SubItems.Add(ev.Depozito.ToString());

            return item;

        }

    }

}
