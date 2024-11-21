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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EmlakOtomasyon
{
    public partial class FindRegisterForm : Form
    {
        private const string KDosyaAdi = "Kiralık.txt";
        private string kiralik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, KDosyaAdi);
        private const string SDosyaAdi = "Satılık.txt";
        private string satilik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SDosyaAdi);
        SaleRegFunctions saleRegFunctions = new SaleRegFunctions();
        List<RentHome> kiralikKayit = new List<RentHome>();
        List<SaleHome> satilikKayit = new List<SaleHome>();


        public FindRegisterForm()
        {
            InitializeComponent();
            EnumlariComboBoxaEkle();
        }

        private void FindRegisterForm_Load(object sender, EventArgs e)
        {
            kiralikKayit = saleRegFunctions.KiralikKayitlariDosyadanOku();
            satilikKayit = saleRegFunctions.SatilikKayitlariDosyadanOku();

            // ListView başlıklarını ekleyelim
            listView1.View = View.Details;
            listView1.Columns.Add("Kat Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Oda Sayısı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Alan (m²)", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Semt", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ev Türü", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Durum", 100, HorizontalAlignment.Left); 
            listView1.Columns.Add("Emlak Numarası", 100, HorizontalAlignment.Left); 
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
        private void AraButton_Click(object sender, EventArgs e)
        {
            AramaYap();
        }
        private void AramaYap()
        {

            listView1.Items.Clear();


            var seciliListe = satilikRD.Checked ? satilikKayit.Cast<Home>() : kiralikRD.Checked ? kiralikKayit.Cast<Home>() : new List<Home>();


            var sonuclar = seciliListe.Where(ev =>
                (!isActive.Checked || ev.Aktif) &&
                (string.IsNullOrEmpty(odaSayisiTextBox.Text) || ev.OdaSayisi == int.Parse(odaSayisiTextBox.Text)) &&
                (string.IsNullOrEmpty(katNumarasiTextBox.Text) || ev.KatNumarasi == int.Parse(katNumarasiTextBox.Text)) &&
                (string.IsNullOrEmpty(alanTextBox.Text) || ev.Alani == int.Parse(alanTextBox.Text)) &&
                (comboBox1.SelectedItem == null || ev.Semt == (Home.Semti)comboBox1.SelectedItem) &&
                (comboBox2.SelectedItem == null || ev.Turu == (Home.EvTur)comboBox2.SelectedItem)
            ).ToList();

       
            foreach (var ev in sonuclar)
            {
                ListViewItem item = new ListViewItem(ev.KatNumarasi.ToString());
                item.SubItems.Add(ev.OdaSayisi.ToString());
                item.SubItems.Add(ev.KatNumarasi.ToString());
                item.SubItems.Add(ev.Alani.ToString());
                item.SubItems.Add(ev.Semt.ToString());
                item.SubItems.Add(ev.Turu.ToString());
                item.SubItems.Add(ev.EmlakNumarasi.ToString()); 



                if (ev is RentHome kiralikEv)
                {
                    item.SubItems.Add(kiralikEv.Depozito.ToString());  
                    item.SubItems.Add(kiralikEv.Kira.ToString());  
                }
                else if (ev is SaleHome satilikEv)
                {
                    item.SubItems.Add(satilikEv.Fiyat.ToString()); 
                }

                listView1.Items.Add(item);
            }

            if (sonuclar.Count == 0)
            {
                MessageBox.Show("Aradığınız kriterlere uygun ev bulunamadı.");
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
