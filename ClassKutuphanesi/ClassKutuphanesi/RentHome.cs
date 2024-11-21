using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassKutuphanesi
{
    public class RentHome : Home
    {
        
        private double depozito;
        private double kira;

       
        public double Depozito
        {
            get { return depozito; }
            set { depozito = value; }
        }

        public double Kira
        {
            get { return kira; }
            set { kira = value; }
        }

        // Kurucu 
        public RentHome(int odaSayisi, int katNumarasi, Semti semt, double alani, DateTime yapimTarihi, EvTur turu, bool aktif, int emlakNumarasi, double depozito, double kira)
            : base(odaSayisi, katNumarasi, semt, alani, yapimTarihi, turu, aktif, emlakNumarasi)
        {
            
            Depozito = depozito;
            Kira = kira;
        }

    
        public override string EvBilgileri()
        {
            return string.Format("Ev Bilgileri:\n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}",
          OdaSayisi, KatNumarasi, Semt, Alani, YapimTarihi, Turu, Aktif);
        }

    }
   

}
