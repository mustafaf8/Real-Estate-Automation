using ClassKutuphanesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace EmlakOtomasyon
{
    public partial class HouseRegistrations : Form
    {
        private const string KDosyaAdi = "Kiralık.txt";
        private string kiralik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, KDosyaAdi);
        private const string SDosyaAdi = "Satılık.txt";
        private string satilik = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SDosyaAdi);
        SaleRegFunctions saleRegFunctions = new SaleRegFunctions();
        List<RentHome> kiraliklarL = new List<RentHome>();
        List<SaleHome> satiliklarL = new List<SaleHome>();


        public HouseRegistrations()
        {
            InitializeComponent();
        }

        private void EvKayıtları_Load(object sender, EventArgs e)
        {
            kiraliklarL = saleRegFunctions.KiralikKayitlariDosyadanOku();
            satiliklarL = saleRegFunctions.SatilikKayitlariDosyadanOku();
            SatilikElemanlariAta();
            KiarlikElemanlariAta();
        }

        public void SatilikElemanlariAta()
        {
            for (int i = 0; i < satiliklarL.Count; i++)
            {
                listView1.Items.Add(saleRegFunctions.SatilikElemanAta(satiliklarL[i]));
            }

        }
        public void KiarlikElemanlariAta()
        {
            for (int i = 0; i < kiraliklarL.Count; i++)
            {
                listView2.Items.Add(saleRegFunctions.kiralikElemanAta(kiraliklarL[i]));
            }
        }

        private void SatilikRD_CheckedChanged(object sender, EventArgs e)
        {
            TurKontrol();
            listView1.SelectedItems.Clear();
            listView2.SelectedItems.Clear();
        }
        public void TurKontrol()
        {
            if (KiralikRD.Checked)
            {
                listView1.Visible = false;
                listView2.Visible = true;
            }
            if (SatilikRD.Checked)
            {
                listView1.Visible = true;
                listView2.Visible = false;
            }
        }

        public void SatilikKaydiSil(string yol, string number)
        {
            try
            {
                string[] satirlar = File.ReadAllLines(yol);
                bool thereIsReg = false;
                int rowNumber = 0;
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string[] split = satirlar[i].Split(',');

                    if (split.Length >= 8 && split[7] == number)
                    {
                        thereIsReg = true;
                        rowNumber = i;
                        break;
                    }

                }
                List<string> yeni = new List<string>();
                if (thereIsReg)
                {
                    for (int i = 0; i < satirlar.Length; i++)
                    {
                        if (rowNumber != i)
                        {
                            yeni.Add(satirlar[i]);
                        }
                    }
                    File.WriteAllLines(yol, yeni);
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else MessageBox.Show("Kayıt silinirken bir sorun ile karşılşıldı (kayıt bulunamadı)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }
        public void KiralikkKaydiSil(string yol, string number)
        {
            try
            {
                string[] satirlar = File.ReadAllLines(yol);
                bool thereIsReg = false;
                int rowNumber = 0;
                for (int i = 0; i < satirlar.Length; i++)
                {
                    string[] split = satirlar[i].Split(',');

                    if (split.Length >= 8 && split[7] == number)
                    {
                        thereIsReg = true;
                        rowNumber = i;
                        break;
                    }

                }
                List<string> yeni = new List<string>();
                if (thereIsReg)
                {
                    for (int i = 0; i < satirlar.Length; i++)
                    {
                        if (rowNumber != i)
                        {
                            yeni.Add(satirlar[i]);
                        }
                    }
                    File.WriteAllLines(yol, yeni);
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else MessageBox.Show("Kayıt silinirken bir sorun ile karşılşıldı (kayıt bulunamadı)");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için seçili bir kayıt seçin");
                return;
            }

            DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (SatilikRD.Checked && listView1.SelectedItems.Count > 0)
                {
                    SatilikKaydiSil(satilik, listView1.SelectedItems[0].SubItems[8].Text);
                }
                else if (KiralikRD.Checked && listView2.SelectedItems.Count > 0)
                {
                    KiralikkKaydiSil(kiralik, listView2.SelectedItems[0].SubItems[8].Text);
                }
            }
        }
        private void Düzenle_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0 && listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen duzenlemek için seçili bir kayıt seçin");
                return;
            }

            bool tur = false;
            if (listView1.SelectedItems.Count != 0) tur = true;

            if (listView1.SelectedItems.Count != 0)
            {
                EditRegistrationsForm edfOne = new EditRegistrationsForm(listView1.SelectedItems[0], tur);
                edfOne.ShowDialog();
            }
            else
            {
                EditRegistrationsForm edfTow = new EditRegistrationsForm(listView2.SelectedItems[0], tur);
                edfTow.ShowDialog();
            }
        }
        private void findRegister_Click(object sender, EventArgs e)
        {
            FindRegisterForm findRegisterForm = new FindRegisterForm();
            findRegisterForm.Show();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
