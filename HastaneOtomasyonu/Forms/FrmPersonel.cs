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
        public static List<Personel> Personeller= new List<Personel>();        
        List<Personel> aramalar = new List<Personel>();
        private void FrmPersonel_Load(object sender, EventArgs e)
        { 
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
            cmbGorev.Items.AddRange(Enum.GetNames(typeof(personelGorev)));
            lstPersoneller.Items.AddRange(Personeller.ToArray());
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
                yenikisi.Gorev = cmbGorev.SelectedItem.ToString();
                yenikisi.Maas = Convert.ToDecimal(nudPersonelMaas.Text);

                Personeller.Add(yenikisi);
                FormuTemizle();
                lstPersoneller.Items.AddRange(Personeller.ToArray());
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
            if (lstPersoneller.SelectedItem == null) return;
            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;
            try
            {
                seciliKisi.Ad = txtAd.Text;
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Gorev = cmbGorev.Text;
                seciliKisi.Maas = Convert.ToDecimal(nudPersonelMaas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstPersoneller.Items.AddRange(Personeller.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItem == null) return;

            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
            cmbGorev.Text = seciliKisi.Gorev;
            nudPersonelMaas.Text = seciliKisi.Maas.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItem == null) return;
            Personel seciliKisi = (Personel)lstPersoneller.SelectedItem;
            Personeller.Remove(seciliKisi);

            FormuTemizle();
            lstPersoneller.Items.AddRange(Personeller.ToArray());
        }

        private void nudPersonelMaas_ValueChanged(object sender, EventArgs e)
        {
            //nudPersonelMaas.DecimalPlaces = 2;//decimal
            nudPersonelMaas.ThousandsSeparator = true;
            nudPersonelMaas.Increment = 100;//artıs
            nudPersonelMaas.Minimum = 1000; //en küçük değeri 10
            nudPersonelMaas.Maximum = 30000; //en büyük değeri 30 
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Personel>();

            Personeller.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstPersoneller.Items.AddRange(aramalar.ToArray());
        }
    }
}
