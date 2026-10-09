namespace WindowsFormsApp1
{
    partial class DashboardForm
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
            this.sakinlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AidatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BorçlularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GelirGiderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gELİRGİDEREKLEMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaireNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorcAlacakTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtİsimGir = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnÇıkış = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtDaireNo = new System.Windows.Forms.TextBox();
            this.txtBorcAlacak = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.lblBorcTutarı = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblİsmeGöreAra = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sakinlerToolStripMenuItem,
            this.AidatToolStripMenuItem,
            this.BorçlularToolStripMenuItem,
            this.GelirGiderToolStripMenuItem,
            this.gELİRGİDEREKLEMEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sakinlerToolStripMenuItem
            // 
            this.sakinlerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sakinlerToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sakinlerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sakinlerToolStripMenuItem.Name = "sakinlerToolStripMenuItem";
            this.sakinlerToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.sakinlerToolStripMenuItem.Text = "Sakinler";
            this.sakinlerToolStripMenuItem.Click += new System.EventHandler(this.sakinlerToolStripMenuItem_Click);
            // 
            // AidatToolStripMenuItem
            // 
            this.AidatToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AidatToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.AidatToolStripMenuItem.Name = "AidatToolStripMenuItem";
            this.AidatToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.AidatToolStripMenuItem.Text = "Aidat ";
            this.AidatToolStripMenuItem.Click += new System.EventHandler(this.AidatToolStripMenuItem_Click);
            // 
            // BorçlularToolStripMenuItem
            // 
            this.BorçlularToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorçlularToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.BorçlularToolStripMenuItem.Name = "BorçlularToolStripMenuItem";
            this.BorçlularToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.BorçlularToolStripMenuItem.Text = "Borçlular";
            this.BorçlularToolStripMenuItem.Click += new System.EventHandler(this.BorçlularToolStripMenuItem_Click);
            // 
            // GelirGiderToolStripMenuItem
            // 
            this.GelirGiderToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GelirGiderToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.GelirGiderToolStripMenuItem.Name = "GelirGiderToolStripMenuItem";
            this.GelirGiderToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.GelirGiderToolStripMenuItem.Text = "Ödenen Ödenmeyen";
            this.GelirGiderToolStripMenuItem.Click += new System.EventHandler(this.GelirGiderToolStripMenuItem_Click);
            // 
            // gELİRGİDEREKLEMEToolStripMenuItem
            // 
            this.gELİRGİDEREKLEMEToolStripMenuItem.Font = new System.Drawing.Font("Stencil", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gELİRGİDEREKLEMEToolStripMenuItem.Name = "gELİRGİDEREKLEMEToolStripMenuItem";
            this.gELİRGİDEREKLEMEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gELİRGİDEREKLEMEToolStripMenuItem.Text = "GELİR GİDER EKLEME";
            this.gELİRGİDEREKLEMEToolStripMenuItem.Click += new System.EventHandler(this.gELİRGİDEREKLEMEToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Soyad,
            this.DaireNo,
            this.BorcAlacakTutar,
            this.TelefonNo});
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 749);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "SakinAd";
            this.Ad.HeaderText = "ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "SakinSoyad";
            this.Soyad.HeaderText = "soyad";
            this.Soyad.MinimumWidth = 6;
            this.Soyad.Name = "Soyad";
            this.Soyad.Width = 125;
            // 
            // DaireNo
            // 
            this.DaireNo.DataPropertyName = "DaireNo";
            this.DaireNo.HeaderText = "Daire No";
            this.DaireNo.MinimumWidth = 6;
            this.DaireNo.Name = "DaireNo";
            this.DaireNo.Width = 125;
            // 
            // BorcAlacakTutar
            // 
            this.BorcAlacakTutar.DataPropertyName = "BorcAlacakTutar";
            this.BorcAlacakTutar.HeaderText = "Borç/Alacak";
            this.BorcAlacakTutar.MinimumWidth = 6;
            this.BorcAlacakTutar.Name = "BorcAlacakTutar";
            this.BorcAlacakTutar.Width = 125;
            // 
            // TelefonNo
            // 
            this.TelefonNo.DataPropertyName = "TelefonNo";
            this.TelefonNo.HeaderText = "Telefon No";
            this.TelefonNo.MinimumWidth = 6;
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Width = 125;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEkle.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(575, 688);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 95);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDuzenle.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Location = new System.Drawing.Point(706, 689);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(150, 95);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSil.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(862, 688);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(159, 95);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtİsimGir
            // 
            this.txtİsimGir.Location = new System.Drawing.Point(1027, 473);
            this.txtİsimGir.Multiline = true;
            this.txtİsimGir.Name = "txtİsimGir";
            this.txtİsimGir.Size = new System.Drawing.Size(196, 45);
            this.txtİsimGir.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAra.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(1027, 571);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(196, 95);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnÇıkış
            // 
            this.btnÇıkış.BackColor = System.Drawing.Color.Black;
            this.btnÇıkış.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnÇıkış.ForeColor = System.Drawing.Color.White;
            this.btnÇıkış.Location = new System.Drawing.Point(1027, 713);
            this.btnÇıkış.Name = "btnÇıkış";
            this.btnÇıkış.Size = new System.Drawing.Size(196, 70);
            this.btnÇıkış.TabIndex = 9;
            this.btnÇıkış.Text = "ÇIKIŞ";
            this.btnÇıkış.UseVisualStyleBackColor = false;
            this.btnÇıkış.Click += new System.EventHandler(this.btnÇıkış_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(1027, 35);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 44);
            this.txtAd.TabIndex = 10;
            // 
            // txtDaireNo
            // 
            this.txtDaireNo.Location = new System.Drawing.Point(1027, 206);
            this.txtDaireNo.Multiline = true;
            this.txtDaireNo.Name = "txtDaireNo";
            this.txtDaireNo.Size = new System.Drawing.Size(153, 42);
            this.txtDaireNo.TabIndex = 11;
            // 
            // txtBorcAlacak
            // 
            this.txtBorcAlacak.Location = new System.Drawing.Point(1027, 307);
            this.txtBorcAlacak.Multiline = true;
            this.txtBorcAlacak.Name = "txtBorcAlacak";
            this.txtBorcAlacak.Size = new System.Drawing.Size(153, 42);
            this.txtBorcAlacak.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(1027, 410);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 22);
            this.maskedTextBox1.TabIndex = 13;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.LightGray;
            this.lblAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdSoyad.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(670, 51);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(56, 28);
            this.lblAdSoyad.TabIndex = 14;
            this.lblAdSoyad.Text = "AD ";
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.BackColor = System.Drawing.Color.LightGray;
            this.lblDaireNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDaireNo.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaireNo.ForeColor = System.Drawing.Color.Black;
            this.lblDaireNo.Location = new System.Drawing.Point(670, 220);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(143, 28);
            this.lblDaireNo.TabIndex = 15;
            this.lblDaireNo.Text = "DAİRE NO";
            // 
            // lblBorcTutarı
            // 
            this.lblBorcTutarı.AutoSize = true;
            this.lblBorcTutarı.BackColor = System.Drawing.Color.LightGray;
            this.lblBorcTutarı.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorcTutarı.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorcTutarı.ForeColor = System.Drawing.Color.Black;
            this.lblBorcTutarı.Location = new System.Drawing.Point(670, 321);
            this.lblBorcTutarı.Name = "lblBorcTutarı";
            this.lblBorcTutarı.Size = new System.Drawing.Size(315, 28);
            this.lblBorcTutarı.TabIndex = 16;
            this.lblBorcTutarı.Text = "BORÇ / ALACAK TUTARI";
            this.lblBorcTutarı.Click += new System.EventHandler(this.lblBorcTutarı_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(670, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "TEL NO";
            // 
            // lblİsmeGöreAra
            // 
            this.lblİsmeGöreAra.AutoSize = true;
            this.lblİsmeGöreAra.BackColor = System.Drawing.Color.LightGray;
            this.lblİsmeGöreAra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblİsmeGöreAra.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblİsmeGöreAra.ForeColor = System.Drawing.Color.Black;
            this.lblİsmeGöreAra.Location = new System.Drawing.Point(670, 494);
            this.lblİsmeGöreAra.Name = "lblİsmeGöreAra";
            this.lblİsmeGöreAra.Size = new System.Drawing.Size(220, 28);
            this.lblİsmeGöreAra.TabIndex = 18;
            this.lblİsmeGöreAra.Text = "İSME GÖRE ARA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(670, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = " SOYAD";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(1027, 112);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(153, 44);
            this.txtSoyad.TabIndex = 20;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._59a53dbf_95d4_44bd_90ea_720252557458;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 795);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblİsmeGöreAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBorcTutarı);
            this.Controls.Add(this.lblDaireNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtBorcAlacak);
            this.Controls.Add(this.txtDaireNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnÇıkış);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtİsimGir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sakinlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AidatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BorçlularToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ToolStripMenuItem GelirGiderToolStripMenuItem;
        private System.Windows.Forms.TextBox txtİsimGir;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnÇıkış;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtDaireNo;
        private System.Windows.Forms.TextBox txtBorcAlacak;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.Label lblBorcTutarı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblİsmeGöreAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaireNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorcAlacakTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNo;
        private System.Windows.Forms.ToolStripMenuItem gELİRGİDEREKLEMEToolStripMenuItem;
    }
}