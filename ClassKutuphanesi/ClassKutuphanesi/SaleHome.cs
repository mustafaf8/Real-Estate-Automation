using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKutuphanesi
{
    public class SaleHome : Home
    {

        private double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }

        // Kurucu
        public SaleHome(int odaSayisi, int katNumarasi, Semti semt,double alani, DateTime yapimTarihi, EvTur turu, bool aktif,int emlakNumarasi, double fiyat) 
            : base(odaSayisi, katNumarasi,semt, alani, yapimTarihi, turu, aktif, emlakNumarasi)
        {
            Fiyat = fiyat;
        }


        public override string EvBilgileri()
        {
            return string.Format("Ev Bilgileri:\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}",
          OdaSayisi, KatNumarasi, Semt, Alani, YapimTarihi, Turu, Aktif);
        }
    }
}
