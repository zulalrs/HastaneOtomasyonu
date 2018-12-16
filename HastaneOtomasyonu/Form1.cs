using HastaneOtomasyonu.Classes;
using HastaneOtomasyonu.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HastaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        FrmDoktor frmDoktor;
        FrmHasta frmHasta;
        FrmHemsire frmHemsire;
        FrmPersonel frmPersonel;
        FrmRandevu frmRandevu;
        FrmRandevuListesi frmRandevuListesi;

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktor == null || frmDoktor.IsDisposed)
            {
                frmDoktor = new FrmDoktor();
                FrmDoktor.Doktorlar = İceAktar(FrmDoktor.Doktorlar);
                frmDoktor.MdiParent = this;
                frmDoktor.Show();
            }
            else frmDoktor.Activate();
        }

        private void hemşireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (frmHemsire == null || frmHemsire.IsDisposed)
            {
                frmHemsire = new FrmHemsire();
                FrmHemsire.Hemsireler = İceAktar(FrmHemsire.Hemsireler);
                frmHemsire.MdiParent = this;
                frmHemsire.Show();
            }
            else frmHemsire.Activate();
        }
        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPersonel == null || frmPersonel.IsDisposed)
            {
                frmPersonel = new FrmPersonel();
                FrmPersonel.Personeller = İceAktar(FrmPersonel.Personeller);
                frmPersonel.MdiParent = this;
                frmPersonel.Show();
            }
            else frmPersonel.Activate();
        }
        private void hastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmHasta == null || frmHasta.IsDisposed)
            {
                frmHasta = new FrmHasta();
                FrmHasta.Hastalar = İceAktar(FrmHasta.Hastalar);
                frmHasta.MdiParent = this;
                frmHasta.Show();
            }
            else frmHasta.Activate();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevu == null || frmRandevu.IsDisposed)
            {
                frmRandevu = new FrmRandevu();
                frmRandevu.MdiParent = this;
                frmRandevu.Show();
            }
            else frmRandevu.Activate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DısaAktar(FrmDoktor.Doktorlar);
            this.DısaAktar(FrmHemsire.Hemsireler);
            this.DısaAktar(FrmPersonel.Personeller);
            this.DısaAktar(FrmHasta.Hastalar);
        }

        public void DısaAktar<T>(T kisiler)
        {
            try
            {
                if (kisiler == null) return;
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                TextWriter textWriter = new StreamWriter($@"..\..\Xml\{kisiler.ToString().Substring(33)}.xml");
                serializer.Serialize(textWriter, kisiler);
                textWriter.Close();
                textWriter.Dispose();
            }
            catch (Exception ex) { throw ex; }
        }

        public T İceAktar<T>(T kisiler)
        {           
            try
            {
                XmlSerializer xmlserializer = new XmlSerializer(typeof(T));
                XmlReader reader =new XmlTextReader($@"..\..\Xml\{kisiler.ToString().Substring(33)}.xml");
                if (xmlserializer.CanDeserialize(reader))
                {
                    kisiler = (T)xmlserializer.Deserialize(reader);
                    reader.Close();
                    reader.Dispose();
                }
                else
                {
                    MessageBox.Show("Lutfen dogru bir xml dosyasını seciniz");
                }
            }
            catch (FileNotFoundException) { return kisiler; }
            catch (Exception ex) { throw ex; }

            return kisiler;
        }

        private void randevuListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmRandevuListesi == null || frmRandevuListesi.IsDisposed)
            {
                frmRandevuListesi = new FrmRandevuListesi();
                frmRandevuListesi.MdiParent = this;
                frmRandevuListesi.Show();
            }
            else frmRandevuListesi.Activate();
        }
    }
}
