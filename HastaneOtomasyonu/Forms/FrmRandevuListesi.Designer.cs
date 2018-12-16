namespace HastaneOtomasyonu.Forms
{
    partial class FrmRandevuListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbDrRandevu = new System.Windows.Forms.ComboBox();
            this.lstVRandevuEkrani = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbDrRandevu
            // 
            this.cmbDrRandevu.FormattingEnabled = true;
            this.cmbDrRandevu.Location = new System.Drawing.Point(48, 47);
            this.cmbDrRandevu.Name = "cmbDrRandevu";
            this.cmbDrRandevu.Size = new System.Drawing.Size(229, 21);
            this.cmbDrRandevu.TabIndex = 3;
            this.cmbDrRandevu.SelectedIndexChanged += new System.EventHandler(this.cmbDrRandevu_SelectedIndexChanged);
            // 
            // lstVRandevuEkrani
            // 
            this.lstVRandevuEkrani.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVRandevuEkrani.Location = new System.Drawing.Point(48, 96);
            this.lstVRandevuEkrani.Name = "lstVRandevuEkrani";
            this.lstVRandevuEkrani.Size = new System.Drawing.Size(704, 307);
            this.lstVRandevuEkrani.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVRandevuEkrani.TabIndex = 2;
            this.lstVRandevuEkrani.UseCompatibleStateImageBehavior = false;
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDrRandevu);
            this.Controls.Add(this.lstVRandevuEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRandevuListesi";
            this.Text = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrRandevu;
        private System.Windows.Forms.ListView lstVRandevuEkrani;
    }
}