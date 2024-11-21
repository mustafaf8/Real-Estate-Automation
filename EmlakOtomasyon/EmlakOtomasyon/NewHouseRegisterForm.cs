using ClassKutuphanesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakOtomasyon
{
    using ClassKutuphanesi;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

    public partial class NewHouseRegisterForm : Form
    {

        SaleRegFunctions saleRegFunctions = new SaleRegFunctions();
        private const string KDosyaAdi = "Kiralık.txt";
        private string kiralik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, KDosyaAdi);
        private const string SDosyaAdi = "Satılık.txt";
        private string satilik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SDosyaAdi);

        public NewHouseRegisterForm()
        {
            InitializeComponent();
        }

        private void SatilikEvK()
        {
            if (string.IsNullOrWhiteSpace(Oda.Text) || string.IsNullOrWhiteSpace(Kat.Text) ||
                comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(Alanı.Text) ||
                string.IsNullOrWhiteSpace(yt.Text) || comboBox2.SelectedItem == null ||
                string.IsNullOrWhiteSpace(Fiyat.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            if (!int.TryParse(Oda.Text, out int odaSayisi))
            {
                MessageBox.Show("Oda Sayısı için geçerli bir tam sayı değeri girin.");
                return;
            }

            if (!int.TryParse(Kat.Text, out int katNumarasi))
            {
                MessageBox.Show("Kat Numarası için geçerli bir tam sayı değeri girin.");
                return;
            }

            if (!double.TryParse(Alanı.Text, out double alani))
            {
                MessageBox.Show("Alan için geçerli bir sayı değeri girin.");
                return;
            }

            if (!DateTime.TryParse(yt.Text, out DateTime yapimTarihi))
            {
                MessageBox.Show("Yapım Tarihi için geçerli bir tarih değeri girin.");
                return;
            }

            if (!double.TryParse(Fiyat.Text, out double fiyat))
            {
                MessageBox.Show("Fiyat için geçerli bir sayı değeri girin.");
                return;
            }

            if (!int.TryParse(Fiyat.Text, out int emlakNumarasi))
            {
                MessageBox.Show("Emlak Numarası için geçerli bir tam sayı değeri girin.");
                return;
            }

            try
            {
                if (SatilikRD.Checked)
                {
                    bool radio = isActive.Checked ? true : false;

                    SaleHome ev = new SaleHome(
                        int.Parse(Oda.Text),
                        int.Parse(Kat.Text),
                        (Home.Semti)Enum.Parse(typeof(Home.Semti), comboBox1.SelectedItem.ToString()),
                        double.Parse(Alanı.Text),
                        DateTime.Parse(yt.Text),
                        (Home.EvTur)Enum.Parse(typeof(Home.EvTur), comboBox2.SelectedItem.ToString()),
                        radio,
                        EmlakNumarasiOlusturucu(),
                        double.Parse(Fiyat.Text));

                    SatilikEvKaydiniTamamla(ev);


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı formatı girin.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Girilen değer çok büyük veya çok küçük.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void KiralikEvK()
        {
            if (string.IsNullOrWhiteSpace(Oda.Text) || string.IsNullOrWhiteSpace(Kat.Text) ||
               comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(Alanı.Text) ||
               string.IsNullOrWhiteSpace(yt.Text) || comboBox2.SelectedItem == null ||
               string.IsNullOrWhiteSpace(Depozito.Text) || string.IsNullOrWhiteSpace(Kira.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            if (!int.TryParse(Oda.Text, out int odaSayisi))
            {
                MessageBox.Show("Oda Sayısı için geçerli bir tam sayı değeri girin.");
                return;
            }

            if (!int.TryParse(Kat.Text, out int katNumarasi))
            {
                MessageBox.Show("Kat Numarası için geçerli bir tam sayı değeri girin.");
                return;
            }

            if (!double.TryParse(Alanı.Text, out double alani))
            {
                MessageBox.Show("Alan için geçerli bir sayı değeri girin.");
                return;
            }

            if (!DateTime.TryParse(yt.Text, out DateTime yapimTarihi))
            {
                MessageBox.Show("Yapım Tarihi için geçerli bir tarih değeri girin.");
                return;
            }

            if (!double.TryParse(Depozito.Text, out double depozito))
            {
                MessageBox.Show("Depozito için geçerli bir sayı değeri girin.");
                return;
            }
            if (!double.TryParse(Kira.Text, out double kira))
            {
                MessageBox.Show("Kira için geçerli bir sayı değeri girin.");
                return;
            }



            try
            {
                if (KiraRD.Checked)
                {
                    bool radio = isActive.Checked ? true : false;

                    RentHome ev = new RentHome(
                        int.Parse(Oda.Text),
                        int.Parse(Kat.Text),
                        (Home.Semti)Enum.Parse(typeof(Home.Semti), comboBox1.SelectedItem.ToString()),
                        double.Parse(Alanı.Text),
                        DateTime.Parse(yt.Text),
                        (Home.EvTur)Enum.Parse(typeof(Home.EvTur), comboBox2.SelectedItem.ToString()),
                        radio,
                        EmlakNumarasiOlusturucu(),
                        double.Parse(Depozito.Text),
                        double.Parse(Kira.Text));

                    KiralikEvKaydiniTamamla(ev);

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen geçerli bir sayı formatı girin.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Girilen değer çok büyük veya çok küçük.");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (SatilikRD.Checked)
            {
                SatilikEvK();

            }
            else if (KiraRD.Checked)
            {
                KiralikEvK();

            }
            else MessageBox.Show("lutfen kayıt turunu sec !"); return;

        }

        public void Temizle()
        {

            Oda.Text = "";
            Kat.Text = "";
            Alanı.Text = "";
            yt.Text = "";
            Fiyat.Text = "";
            Depozito.Text = "";
            Kira.Text = "";


            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            SatilikRD.Checked = false;
            KiraRD.Checked = false;


            isActive.Checked = false;
        }

        public void SatilikEvKaydiniTamamla(SaleHome salehome)
        {
            saleRegFunctions.DosyaVarMi(satilik);
            try
            {
                // SatılıkEv nesnesinin özelliklerini dosyaya yazar
                string satir = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                    salehome.OdaSayisi, salehome.KatNumarasi, salehome.Semt, salehome.Alani,
                    salehome.YapimTarihi, salehome.Turu, salehome.Aktif, salehome.EmlakNumarasi, salehome.Fiyat);

                // Dosyaya satırı ekleyin
                using (StreamWriter writer = new StreamWriter(satilik, true))
                {
                    writer.WriteLine(satir);
                    writer.Close();
                }

                MessageBox.Show("Kayıt başarılı şekilde gerçekleşti");
                Temizle();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        public void KiralikEvKaydiniTamamla(RentHome renthome)
        {
            saleRegFunctions.DosyaVarMi(kiralik);
            try
            {

                string satir = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                    renthome.OdaSayisi, renthome.KatNumarasi, renthome.Semt, renthome.Alani,
                    renthome.YapimTarihi, renthome.Turu, renthome.Aktif, renthome.EmlakNumarasi, renthome.Depozito, renthome.Kira);


                using (StreamWriter writer = new StreamWriter(kiralik, true))
                {
                    writer.WriteLine(satir);
                    writer.Close();
                }

                MessageBox.Show("Kayıt bşarılı şekilde gerçekleşti");
                Temizle();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }
        }

        private void EnumlariComboBoxaEkle()
        {
            foreach (var tur in Enum.GetValues(typeof(Home.Semti)))
            {
                comboBox1.Items.Add(tur);
            }
            foreach (var tur in Enum.GetValues(typeof(Home.EvTur)))
            {
                comboBox2.Items.Add(tur);
            }
        }


        public int EmlakNumarasiOlusturucu()
        {
            Random random = new Random();
            int en = random.Next(100000000, 999999999);
            return en;
        }
        private void addRegister_Load(object sender, EventArgs e)
        {
            EnumlariComboBoxaEkle();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


