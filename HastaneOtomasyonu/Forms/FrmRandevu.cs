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

        private void FrmRandevu_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            int x = 40, y = 20, sayac = 0;
            DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
            do
            {
                if (sayac % 4 == 0)
                {
                    x = 40;
                    y += 30;
                }
                if (baslangic.Hour == 12)
                {
                    y -= 30;
                    baslangic = baslangic.AddHours(1);
                    continue;
                }
                Button button = new Button();
                Point btnPoint = new Point(x, y);
                button.Location = btnPoint;
                button.Name = baslangic.ToShortTimeString();
                button.Text = baslangic.ToShortTimeString();
                button.Width = 50;
                button.Height = 25;
                button.Click += Button_Click;
                panel1.Controls.Add(button);
                x += 60;
                sayac++;
                baslangic = baslangic.AddMinutes(15);

            } while (!(baslangic.Hour == 15));

            lstRHastalar.Items.AddRange(FrmHasta.hastalar.ToArray());
            panel1.Visible = false;
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
            foreach (Doktor hekimler in FrmDoktor.doktorlar)
            {
                if (cmbPoliklinikler.Text == hekimler.Branslar)
                {
                    cmbDoktorlar.Items.Add(hekimler);
                }
            }
        }

        private void cmbDoktorlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
