using HastaneOtomasyonu.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu.Forms
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }

        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;

            cmbDrRandevu.Items.AddRange(FrmDoktor.Doktorlar.ToArray());

            lstVRandevuEkrani.View = View.Details;
            lstVRandevuEkrani.FullRowSelect = true;

            lstVRandevuEkrani.Columns.Add("TC", lstVRandevuEkrani.Width / 4);
            lstVRandevuEkrani.Columns.Add("AD", lstVRandevuEkrani.Width / 4);
            lstVRandevuEkrani.Columns.Add("SOYAD", lstVRandevuEkrani.Width / 4);
            lstVRandevuEkrani.Columns.Add("RANDEVU SAATİ", lstVRandevuEkrani.Width / 4);
        }
        string[] randevuekrani;    
        
        private void cmbDrRandevu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lstVRandevuEkrani.Items.Clear();
            foreach (Randevu randevu in FrmRandevu.Randevular)
            {
                if (randevu.Doktor.ToString() == cmbDrRandevu.Text)
                {
                    randevuekrani = new string[] { randevu.Hasta.TCKN, randevu.Hasta.Ad, randevu.Hasta.Soyad, randevu.Saat };
                    lstVRandevuEkrani.ListViewItemSorter = new ListViewItemComparer(3, lstVRandevuEkrani.Sorting);
                    lstVRandevuEkrani.Items.Add(new ListViewItem(randevuekrani));

                }
            }
        }

        public class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public ListViewItemComparer(int v, SortOrder sorting)
            {
                col = 3;
                order = SortOrder.Ascending;
            }
            public int Compare(object x, object y)
            {
                int retunVal = -1;
                retunVal = string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                return retunVal;
            }
        }


    }
}
