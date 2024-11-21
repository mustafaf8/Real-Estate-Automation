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
using static ClassKutuphanesi.Home;

namespace EmlakOtomasyon
{
    public partial class EditRegistrationsForm : Form
    {
        ListViewItem kayit = new ListViewItem();
        public bool tur;
        SaleRegFunctions saleRegFunctions = new SaleRegFunctions();
        private const string KDosyaAdi = "Kiralık.txt";
        private string kiralik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, KDosyaAdi);
        private const string SDosyaAdi = "Satılık.txt";
        private string satilik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SDosyaAdi);
        public EditRegistrationsForm(ListViewItem kayitb, bool turb)
        {
            InitializeComponent();
            kayit = kayitb;
            tur = turb;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tur) SatilikKaydiDuzenle(satilik, kayit.SubItems[8].Text);
            else KiralikKaydiDuzenle(kiralik, kayit.SubItems[8].Text);
        }

        private void editRegister_Load(object sender, EventArgs e)
        {
            EnumlariComboBoxaEkle();
            if (tur) Satiliksa();
            else Kiraliksa();
        }
        public void Kiraliksa()
        {
            BilgileriGetirKiraliksa();
            Fiyat.Visible = false;
            SatilikRD.Visible = false;
            KiraRD.Visible = false;
            Fiyat.Visible = false;
        }
        public void Satiliksa()
        {
            BilgileriGetirSatilik();
            KiraRD.Visible = false;
            Depozito.Visible = false;
            Kira.Visible = false;
            SatilikRD.Visible = false;
            Depozito.Visible = false;
            KiraL.Visible = false;
        }

        private void BilgileriGetirSatilik()
        {
            Oda.Text = kayit.SubItems[1].Text;
            Kat.Text = kayit.SubItems[2].Text;
            comboBox1.SelectedItem = Enum.TryParse<Semti>(kayit.SubItems[3].Text, out var semt) ? semt : (object)null;
            Alanı.Text = kayit.SubItems[4].Text;
            DateTime yapimTarihi;
            DateTime.TryParse(kayit.SubItems[5].Text, out yapimTarihi);
            yt.Value = yapimTarihi;
            comboBox2.SelectedItem = Enum.TryParse<EvTur>(kayit.SubItems[6].Text, out var evTur) ? evTur : (object)null;
            ak.Checked = kayit.SubItems[7].Text.ToLower() == "true";
            Fiyat.Text = kayit.SubItems[9].Text;
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
        private void BilgileriGetirKiraliksa()
        {
            Oda.Text = kayit.SubItems[1].Text;
            Kat.Text = kayit.SubItems[2].Text;
            comboBox1.SelectedItem = Enum.TryParse<Semti>(kayit.SubItems[3].Text, out var semt) ? semt : (object)null;
            Alanı.Text = kayit.SubItems[4].Text;
            DateTime yapimTarihi;
            DateTime.TryParse(kayit.SubItems[5].Text, out yapimTarihi);
            yt.Value = yapimTarihi;
            comboBox2.SelectedItem = Enum.TryParse<EvTur>(kayit.SubItems[6].Text, out var evTur) ? evTur : (object)null;
            ak.Checked = kayit.SubItems[7].Text.ToLower() == "true";
            Depozito.Text = kayit.SubItems[9].Text;
            Kira.Text = kayit.SubItems[10].Text;
        }


        public void SatilikKaydiDuzenle(string yol, string numara)
        {
            try
            {
                string[] satirlar = File.ReadAllLines(yol);
                bool c = false;
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string[] split = satirlar[i].Split(',');

                    if (split.Length >= 8 && split[7] == numara)
                    {
                        satirlar[i] = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                             Oda.Text, Kat.Text, comboBox1.SelectedItem.ToString(), Alanı.Text,
                             yt.Value.ToString("dd.MM.yyyy"), comboBox2.SelectedItem.ToString(),
                             ak.Checked.ToString(), numara, Fiyat.Text);
                        c = true;
                        break;
                    }

                }
                // Dosyayı güncelle
                File.WriteAllLines(yol, satirlar);

                if (c) MessageBox.Show("Kayıt başarıyla düzenlendi.");
                else MessageBox.Show("Kayıt düzenlenirken bir sorun ile karşılşıldı (kayıt bulunamadı)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        public void KiralikKaydiDuzenle(string yol, string numara)
        {
            try
            {
                string[] satirlar = File.ReadAllLines(yol);
                bool c = false;
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string[] split = satirlar[i].Split(',');

                    if (split.Length >= 8 && split[7] == numara)
                    {
                        // Eşleşen satırı güncelleme
                        satirlar[i] = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
                             Oda.Text, Kat.Text, comboBox1.SelectedItem.ToString(), Alanı.Text,
                             yt.Value.ToString("dd.MM.yyyy"), comboBox2.SelectedItem.ToString(),
                             ak.Checked.ToString(), numara, Kira.Text, Depozito.Text);
                        c = true;
                        break;
                    }

                }

                File.WriteAllLines(yol, satirlar);

                if (c) MessageBox.Show("işlem başarılı.");
                else MessageBox.Show("sorun ile karşılşıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
    }
}
