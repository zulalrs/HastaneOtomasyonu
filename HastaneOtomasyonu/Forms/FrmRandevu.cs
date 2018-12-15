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
        FrmHasta frmHasta = new FrmHasta();
        FrmDoktor frmDoktor = new FrmDoktor();
        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;


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
            cmbPoliklinikler.Items.Clear();
            cmbPoliklinikler.Items.AddRange(Enum.GetNames(typeof(Poliklinikler)));
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
    }
}
