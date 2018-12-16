namespace HastaneOtomasyonu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hemşireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.randevuListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 63);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.doktorToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.byndoktor;
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(86, 59);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hemşireToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.hemsire2;
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(93, 59);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            this.hemşireToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hemşireToolStripMenuItem.Click += new System.EventHandler(this.hemşireToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.personel;
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(95, 59);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hastaToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.hasta;
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(78, 59);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.randevuToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.takvimsaat;
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(96, 59);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // randevuListesiToolStripMenuItem
            // 
            this.randevuListesiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuListesiToolStripMenuItem.Image = global::HastaneOtomasyonu.Properties.Resources.defter;
            this.randevuListesiToolStripMenuItem.Name = "randevuListesiToolStripMenuItem";
            this.randevuListesiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(15);
            this.randevuListesiToolStripMenuItem.Size = new System.Drawing.Size(131, 59);
            this.randevuListesiToolStripMenuItem.Text = "Randevu Listesi";
            this.randevuListesiToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.randevuListesiToolStripMenuItem.Click += new System.EventHandler(this.randevuListesiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Otomasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuListesiToolStripMenuItem;
    }
}

