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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hemşireToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.randevuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hemşireToolStripMenuItem
            // 
            this.hemşireToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hemşireToolStripMenuItem.Name = "hemşireToolStripMenuItem";
            this.hemşireToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.hemşireToolStripMenuItem.Text = "Hemşire";
            this.hemşireToolStripMenuItem.Click += new System.EventHandler(this.hemşireToolStripMenuItem_Click);
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.personelToolStripMenuItem.Text = "Personel";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(56, 23);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hastane Otomasyonu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hemşireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
    }
}

