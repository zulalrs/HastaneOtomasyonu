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
    public partial class FrmHasta : Form
    {
        public FrmHasta()
        {
            InitializeComponent();
        }
        public static List<Hasta> Hastalar = new List<Hasta>();
        List<Hasta> aramalar = new List<Hasta>();
        
        private void FrmHasta_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(cinsiyet)));
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            lstHastalar.Items.AddRange(Hastalar.ToArray());
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hasta yenikisi = new Hasta();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = mtxtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;
                yenikisi.Cinsiyet = cmbCinsiyet.Text;
                yenikisi.DogumTarihi = dtpDogumTarihi.Value;

                Hastalar.Add(yenikisi);
                FormuTemizle();
                lstHastalar.Items.AddRange(Hastalar.ToArray());
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
                else if (control is ComboBox comboBox)
                    comboBox.Text = string.Empty;
                else if (control is MaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
                else if (control is DateTimePicker)
                    (control as DateTimePicker).Value = DateTime.Now;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;
            Hasta seciliKisi = (Hasta)lstHastalar.SelectedItem;   
            try
            {
                seciliKisi.Ad = txtAd.Text; 
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Cinsiyet = cmbCinsiyet.Text;
                seciliKisi.DogumTarihi = dtpDogumTarihi.Value;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstHastalar.Items.AddRange(Hastalar.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;

            Hasta seciliKisi = (Hasta)lstHastalar.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
            cmbCinsiyet.Text = seciliKisi.Cinsiyet;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;
            Hasta seciliKisi = (Hasta)lstHastalar.SelectedItem;
            Hastalar.Remove(seciliKisi);

            FormuTemizle();
            lstHastalar.Items.AddRange(Hastalar.ToArray());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hasta>();

            Hastalar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstHastalar.Items.AddRange(aramalar.ToArray());
        }
    }
}
