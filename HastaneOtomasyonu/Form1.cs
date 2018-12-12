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


        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmDoktor == null || frmDoktor.IsDisposed)
            {
                frmDoktor = new FrmDoktor();
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




    }
}
