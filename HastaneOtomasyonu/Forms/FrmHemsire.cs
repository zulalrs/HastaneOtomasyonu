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
        List<Hemsire> kisiler = new List<Hemsire>();
        List<Hemsire> aramalar = new List<Hemsire>();

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

                kisiler.Add(yenikisi);
                FormuTemizle();
                lstKisiler.Items.AddRange(kisiler.ToArray());
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
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            Doktor seciliKisi = (Doktor)lstKisiler.SelectedItem;   
            try
            {
                seciliKisi.Ad = txtAd.Text; 
                seciliKisi.Soyad = txtSoyad.Text;
                seciliKisi.Telefon = mtxtTelefon.Text;
                seciliKisi.Email = txtEmail.Text;
                seciliKisi.TCKN = txtTckn.Text;
                seciliKisi.Branslar = cmbBranslar.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            FormuTemizle();
            lstKisiler.Items.AddRange(kisiler.ToArray());
        }

        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            Hemsire seciliKisi = (Hemsire)lstKisiler.SelectedItem;
            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            mtxtTelefon.Text = seciliKisi.Telefon;
            txtEmail.Text = seciliKisi.Email;
            txtTckn.Text = seciliKisi.TCKN;
            cmbBranslar.Text = seciliKisi.Branslar;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < kisiler.Count; i++)
            {
                if (lstKisiler.SelectedIndex == i)
                {
                    kisiler.RemoveAt(i);
                    lstKisiler.Items.RemoveAt(i);
                    FormuTemizle();
                }
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string ara = txtAra.Text.ToLower();
            aramalar = new List<Hemsire>();

            kisiler.Where(kisi => kisi.Ad.ToLower().Contains(ara) || kisi.Soyad.ToLower().Contains(ara) || kisi.TCKN.StartsWith(ara)).ToList().ForEach(kisi => aramalar.Add(kisi));

            FormuTemizle();
            lstKisiler.Items.AddRange(aramalar.ToArray());
        }
    }
}
