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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDrRandevu
            // 
            this.cmbDrRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDrRandevu.FormattingEnabled = true;
            this.cmbDrRandevu.Location = new System.Drawing.Point(69, 91);
            this.cmbDrRandevu.Name = "cmbDrRandevu";
            this.cmbDrRandevu.Size = new System.Drawing.Size(229, 24);
            this.cmbDrRandevu.Sorted = true;
            this.cmbDrRandevu.TabIndex = 0;
            this.cmbDrRandevu.SelectedIndexChanged += new System.EventHandler(this.cmbDrRandevu_SelectedIndexChanged);
            // 
            // lstVRandevuEkrani
            // 
            this.lstVRandevuEkrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstVRandevuEkrani.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVRandevuEkrani.Location = new System.Drawing.Point(69, 171);
            this.lstVRandevuEkrani.Name = "lstVRandevuEkrani";
            this.lstVRandevuEkrani.Size = new System.Drawing.Size(863, 312);
            this.lstVRandevuEkrani.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstVRandevuEkrani.TabIndex = 1;
            this.lstVRandevuEkrani.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doktorlar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Randevular";
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDrRandevu);
            this.Controls.Add(this.lstVRandevuEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRandevuListesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrRandevu;
        private System.Windows.Forms.ListView lstVRandevuEkrani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}