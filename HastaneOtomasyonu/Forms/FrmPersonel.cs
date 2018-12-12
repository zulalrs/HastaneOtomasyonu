using HastaneOtomasyonu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        List<Personel> personel = new List<Personel>();
        List<Personel> aramalar = new List<Personel>();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel yenikisi = new Personel();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = mtxtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;


                personel.Add(yenikisi);
                FormuTemizle();
                lstKisiler.Items.AddRange(personel.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormuTemizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name == "txtAra")
                        continue;
                    control.Text = string.Empty;
                }
                else if (control is ListBox listBox)
                    listBox.Items.Clear();


            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Personel seciliKisi = (Personel)lstKisiler.SelectedItem;    // Adresler esitlendigi icin icindeki tüm degerlerde esitlenecek. Birinde yapılan degisiklik digerini de etkileyecek.
            try
            {
                seciliKisi.Ad = txtAd.Text; // secilikisi nesnesine text teki degeri atadıgımızda adresleri esit oldugu icin  listbox ta secilen nesnenin degeri de degisecek
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstKisiler.Items.AddRange(personel.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Personel seciliKisi = (Personel)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < personel.Count; i++)
            {
                if (lstKisiler.SelectedIndex == i)
                {
                    personel.RemoveAt(i);
                    lstKisiler.Items.RemoveAt(i);
                    //FormuTemizle();
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Personel>();

            personel.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            Personel yenikisi = new Personel();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = mtxtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;


                personel.Add(yenikisi);
                FormuTemizle();
                lstKisiler.Items.AddRange(personel.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
