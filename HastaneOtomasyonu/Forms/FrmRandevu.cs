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
    public partial class FrmRandevu : Form
    {
        public FrmRandevu()
        {
            InitializeComponent();
        }
        public static List<Randevu> Randevular = new List<Randevu>();
        Doktor seciliDoktor;
        Hasta seciliHasta;
        Button seciliButon;
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            lstRHastalar.Items.AddRange(FrmHasta.Hastalar.ToArray());
            flowLayoutPanel1.Visible = false;



            DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
            do
            {
                if (baslangic.Hour == 12)
                {
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Button button = new Button();
                button.Name = baslangic.ToShortTimeString();
                button.Text = baslangic.ToShortTimeString();
                button.Width = 50;
                button.Height = 25;
                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);

                baslangic = baslangic.AddMinutes(15);

            } while (!(baslangic.Hour == 15));


            lstRHastalar.Items.AddRange(FrmHasta.Hastalar.ToArray());
            flowLayoutPanel1.Visible = false;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Enabled = false;
        }

        private void lstRHastalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRHastalar.SelectedItem == null) return;
            cmbPoliklinikler.Items.Clear();
            cmbDoktorlar.Items.Clear();
            cmbDoktorlar.Text = string.Empty;
            flowLayoutPanel1.Controls.Clear();
            cmbPoliklinikler.Items.AddRange(Enum.GetNames(typeof(Poliklinikler)));
            seciliHasta = lstRHastalar.SelectedItem as Hasta;
        }

        private void cmbPoliklinikler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.Clear();
            foreach (Doktor hekimler in FrmDoktor.Doktorlar)
            {
                if (cmbPoliklinikler.Text == hekimler.Branslar)
                {
                    cmbDoktorlar.Items.Add(hekimler);
                }
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (seciliButon == null)
                {
                    throw new Exception("Lütfen bir randevu saati seçiniz.");
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("Randevu saatini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo);
                    if (cevap == DialogResult.Yes)
                    {
                        Randevu randevu = new Randevu();
                        randevu.Doktor = cmbDoktorlar.SelectedItem as Doktor;
                        randevu.Hasta = lstRHastalar.SelectedItem as Hasta;
                        randevu.poliklinikler = (Poliklinikler)Enum.Parse(typeof(Poliklinikler), cmbPoliklinikler.SelectedItem.ToString());
                        randevu.Saat = seciliButon.Text;

                        Randevular.Add(randevu);
                        seciliButon.BackColor = Color.LightGray;
                        MessageBox.Show("Randevu | başarıyla kaydedilmiştir.");
                    }
                    else return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            lstRHastalar.SelectedItem = null;
            cmbDoktorlar.Items.Clear();
            cmbPoliklinikler.Items.Clear();
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
