namespace HastaneOtomasyonu
{
    partial class FrmRandevu
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
            this.cmbDoktorlar = new System.Windows.Forms.ComboBox();
            this.cmbPoliklinikler = new System.Windows.Forms.ComboBox();
            this.lstRHastalar = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRandevuAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDoktorlar
            // 
            this.cmbDoktorlar.FormattingEnabled = true;
            this.cmbDoktorlar.Location = new System.Drawing.Point(253, 238);
            this.cmbDoktorlar.Name = "cmbDoktorlar";
            this.cmbDoktorlar.Size = new System.Drawing.Size(213, 21);
            this.cmbDoktorlar.TabIndex = 5;
            this.cmbDoktorlar.SelectedIndexChanged += new System.EventHandler(this.cmbDoktorlar_SelectedIndexChanged);
            // 
            // cmbPoliklinikler
            // 
            this.cmbPoliklinikler.FormattingEnabled = true;
            this.cmbPoliklinikler.Location = new System.Drawing.Point(253, 171);
            this.cmbPoliklinikler.Name = "cmbPoliklinikler";
            this.cmbPoliklinikler.Size = new System.Drawing.Size(213, 21);
            this.cmbPoliklinikler.TabIndex = 6;
            this.cmbPoliklinikler.SelectedIndexChanged += new System.EventHandler(this.cmbPoliklinikler_SelectedIndexChanged);
            // 
            // lstRHastalar
            // 
            this.lstRHastalar.FormattingEnabled = true;
            this.lstRHastalar.Location = new System.Drawing.Point(19, 48);
            this.lstRHastalar.Name = "lstRHastalar";
            this.lstRHastalar.Size = new System.Drawing.Size(215, 355);
            this.lstRHastalar.TabIndex = 4;
            this.lstRHastalar.SelectedIndexChanged += new System.EventHandler(this.lstRHastalar_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(472, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(287, 213);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.Location = new System.Drawing.Point(318, 379);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuAl.TabIndex = 8;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.UseVisualStyleBackColor = true;
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // FrmRandevu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandevuAl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmbDoktorlar);
            this.Controls.Add(this.cmbPoliklinikler);
            this.Controls.Add(this.lstRHastalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRandevu";
            this.Text = "FrmRandevu";
            this.Load += new System.EventHandler(this.FrmRandevu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDoktorlar;
        private System.Windows.Forms.ComboBox cmbPoliklinikler;
        private System.Windows.Forms.ListBox lstRHastalar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRandevuAl;
    }
}