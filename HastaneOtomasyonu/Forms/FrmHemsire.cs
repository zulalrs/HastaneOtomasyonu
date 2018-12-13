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
    public partial class FrmHemsire : Form
    {
        public FrmHemsire()
        {
            InitializeComponent();
        }

        private void FrmHemsire_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(Poliklinikler)));
        }
        List<Hemsire> hemsireler = new List<Hemsire>();
        List<Hemsire> aramalar = new List<Hemsire>();
        Hemsire seciliKisi;

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hemsire yenikisi = new Hemsire();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = mtxtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;
                yenikisi.Branslar = cmbBranslar.SelectedItem.ToString();
                yenikisi.Maas = Convert.ToDecimal(nudHemsireMaas.Text);

                hemsireler.Add(yenikisi);
                FormuTemizle();
                lstHemsireler.Items.AddRange(hemsireler.ToArray());
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
                else if (control is MaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
                else if (control is ComboBox comboBox)
                    comboBox.Text = string.Empty;
                else if (control is NumericUpDown)
                    control.Text = string.Empty;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstHemsireler.SelectedItem == null) return;
          seciliKisi = (Hemsire)lstHemsireler.SelectedItem;   
            try
            {
                seciliKisi.Ad = txtAd.Text; 
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Branslar = cmbBranslar.Text;
                seciliKisi.Maas = Convert.ToDecimal(nudHemsireMaas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstHemsireler.Items.AddRange(hemsireler.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHemsireler.SelectedItem == null) return;

           seciliKisi = (Hemsire)lstHemsireler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
            cmbBranslar.Text = seciliKisi.Branslar;
            nudHemsireMaas.Text = seciliKisi.Maas.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstHemsireler.SelectedItem == null) return;

            seciliKisi = (Hemsire)lstHemsireler.SelectedItem;
            hemsireler.Remove(seciliKisi);

            FormuTemizle();
            lstHemsireler.Items.AddRange(hemsireler.ToArray());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hemsire>();

            hemsireler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstHemsireler.Items.AddRange(aramalar.ToArray());
        }

        private void nudHemsireMaas_ValueChanged(object sender, EventArgs e)
        {
            //nudHemsireMaas.DecimalPlaces = 2;//decimal
            nudHemsireMaas.ThousandsSeparator = true;
            nudHemsireMaas.Increment = 100;//artıs
            nudHemsireMaas.Minimum = 1000; //en küçük değeri 10
            nudHemsireMaas.Maximum = 30000; //en büyük değeri 30
        }
    }
}
