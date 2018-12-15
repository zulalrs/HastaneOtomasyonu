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
    public partial class FrmDoktor : Form
    {
        public FrmDoktor()
        {
            InitializeComponent();
        }
        public static List<Doktor> Doktorlar = new List<Doktor>();
        List<Doktor> aramalar = new List<Doktor>();
        Doktor seciliKisi;
        private void FrmDoktor_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            cmbBranslar.Items.AddRange(Enum.GetNames(typeof(Poliklinikler)));
            cmbUnvan.Items.AddRange(Enum.GetNames(typeof(Unvanlar)));
            lstDoktorlar.Items.AddRange(Doktorlar.ToArray());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Doktor yenikisi = new Doktor();
            try
            {
                yenikisi.Ad = txtAd.Text;
                yenikisi.Soyad = txtSoyad.Text;
                yenikisi.Telefon = mtxtTelefon.Text;
                yenikisi.Email = txtEmail.Text;
                yenikisi.TCKN = txtTckn.Text;
                yenikisi.Branslar = cmbBranslar.SelectedItem.ToString();
                yenikisi.Unvan = cmbUnvan.SelectedItem.ToString();
                yenikisi.Maas = Convert.ToDecimal(nudDoktorMaas.Text);

                Doktorlar.Add(yenikisi);
                FormuTemizle();
                lstDoktorlar.Items.AddRange(Doktorlar.ToArray());
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
            if (lstDoktorlar.SelectedItem == null) return;
            seciliKisi = (Doktor)lstDoktorlar.SelectedItem;
            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Branslar = cmbBranslar.Text;
                seciliKisi.Unvan = cmbUnvan.Text;
                seciliKisi.Maas = Convert.ToDecimal(nudDoktorMaas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstDoktorlar.Items.AddRange(Doktorlar.ToArray());
        }

        private void lstDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            seciliKisi = (Doktor)lstDoktorlar.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
            cmbBranslar.Text = seciliKisi.Branslar;
            cmbUnvan.Text = seciliKisi.Unvan;
            nudDoktorMaas.Text = seciliKisi.Maas.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstDoktorlar.SelectedItem == null) return;

            seciliKisi = (Doktor)lstDoktorlar.SelectedItem;
            Doktorlar.Remove(seciliKisi);

            FormuTemizle();
            lstDoktorlar.Items.AddRange(Doktorlar.ToArray());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Doktor>();

            Doktorlar.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstDoktorlar.Items.AddRange(aramalar.ToArray());
        }

        private void nudDoktorMaas_ValueChanged(object sender, EventArgs e)
        {
            //nudDoktorMaas.DecimalPlaces = 2;//decimal
            nudDoktorMaas.ThousandsSeparator = true;
            nudDoktorMaas.Increment = 100;//artıs
            nudDoktorMaas.Minimum = 1000; //en küçük değeri 10
            nudDoktorMaas.Maximum = 30000; //en büyük değeri 30
        }
    }
}
