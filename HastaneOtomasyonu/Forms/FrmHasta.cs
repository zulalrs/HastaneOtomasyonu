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
        public static List<Hasta> hastalar = new List<Hasta>();
        List<Hasta> aramalar = new List<Hasta>();
        Hasta seciliKisi;

        private void FrmHasta_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
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


                hastalar.Add(yenikisi);
                FormuTemizle();
                lstHastalar.Items.AddRange(hastalar.ToArray());
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

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;
            seciliKisi = (Hasta)lstHastalar.SelectedItem;
            try
            {
                seciliKisi.Ad = txtAd.Text;
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
            lstHastalar.Items.AddRange(hastalar.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;

            seciliKisi = (Hasta)lstHastalar.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstHastalar.SelectedItem == null) return;
            seciliKisi = (Hasta)lstHastalar.SelectedItem;
            hastalar.Remove(seciliKisi);

            FormuTemizle();
            lstHastalar.Items.AddRange(hastalar.ToArray());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hasta>();

            hastalar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstHastalar.Items.AddRange(aramalar.ToArray());
        }
    }
}
