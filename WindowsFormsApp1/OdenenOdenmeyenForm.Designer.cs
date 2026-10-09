namespace WindowsFormsApp1
{
    partial class OdenenOdenmeyenForm
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
            this.cmbSakinler = new System.Windows.Forms.ComboBox();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.lblOdenenTutar = new System.Windows.Forms.Label();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDaireNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamBorc2 = new System.Windows.Forms.Label();
            this.lblOdenenTutar2 = new System.Windows.Forms.Label();
            this.lblKalanBorc2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaireNo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSakinler
            // 
            this.cmbSakinler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmbSakinler.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSakinler.ForeColor = System.Drawing.Color.Black;
            this.cmbSakinler.FormattingEnabled = true;
            this.cmbSakinler.Items.AddRange(new object[] {
            "Gelir",
            "Gider"});
            this.cmbSakinler.Location = new System.Drawing.Point(338, 80);
            this.cmbSakinler.Name = "cmbSakinler";
            this.cmbSakinler.Size = new System.Drawing.Size(190, 30);
            this.cmbSakinler.TabIndex = 0;
            this.cmbSakinler.SelectedIndexChanged += new System.EventHandler(this.cmbSakinler_SelectedIndexChanged);
            // 
            // nudTutar
            // 
            this.nudTutar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nudTutar.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTutar.ForeColor = System.Drawing.Color.Black;
            this.nudTutar.Location = new System.Drawing.Point(678, 84);
            this.nudTutar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(184, 29);
            this.nudTutar.TabIndex = 1;
            this.nudTutar.ValueChanged += new System.EventHandler(this.nudTutar_ValueChanged);
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTarih.Location = new System.Drawing.Point(12, 81);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(276, 29);
            this.dateTimePickerTarih.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Transparent;
            this.btnKaydet.Location = new System.Drawing.Point(903, 696);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 84);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(850, 522);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAçıklama.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAçıklama.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAçıklama.Location = new System.Drawing.Point(903, 500);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(408, 96);
            this.txtAçıklama.TabIndex = 6;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.Location = new System.Drawing.Point(1276, 740);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 84);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "ÖDEME DURUM RAPORU";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Transparent;
            this.btnSil.Location = new System.Drawing.Point(1059, 696);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 84);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblToplamBorc
            // 
            this.lblToplamBorc.AutoSize = true;
            this.lblToplamBorc.BackColor = System.Drawing.Color.SteelBlue;
            this.lblToplamBorc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc.Location = new System.Drawing.Point(987, 81);
            this.lblToplamBorc.Name = "lblToplamBorc";
            this.lblToplamBorc.Size = new System.Drawing.Size(149, 27);
            this.lblToplamBorc.TabIndex = 10;
            this.lblToplamBorc.Text = "Toplam Tutar";
            // 
            // lblOdenenTutar
            // 
            this.lblOdenenTutar.AutoSize = true;
            this.lblOdenenTutar.BackColor = System.Drawing.Color.LightGray;
            this.lblOdenenTutar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenTutar.Location = new System.Drawing.Point(987, 159);
            this.lblOdenenTutar.Name = "lblOdenenTutar";
            this.lblOdenenTutar.Size = new System.Drawing.Size(151, 27);
            this.lblOdenenTutar.TabIndex = 11;
            this.lblOdenenTutar.Text = "Ödenen Tutar";
            // 
            // lblKalanBorc
            // 
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.BackColor = System.Drawing.Color.LightGray;
            this.lblKalanBorc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc.Location = new System.Drawing.Point(987, 224);
            this.lblKalanBorc.Name = "lblKalanBorc";
            this.lblKalanBorc.Size = new System.Drawing.Size(120, 27);
            this.lblKalanBorc.TabIndex = 12;
            this.lblKalanBorc.Text = "Kalan Borç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(544, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "DAİRE NO";
            // 
            // nudDaireNo
            // 
            this.nudDaireNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.nudDaireNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudDaireNo.Location = new System.Drawing.Point(678, 170);
            this.nudDaireNo.Name = "nudDaireNo";
            this.nudDaireNo.Size = new System.Drawing.Size(184, 29);
            this.nudDaireNo.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(581, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "TUTAR";
            // 
            // lblToplamBorc2
            // 
            this.lblToplamBorc2.AutoSize = true;
            this.lblToplamBorc2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorc2.Location = new System.Drawing.Point(1193, 78);
            this.lblToplamBorc2.Name = "lblToplamBorc2";
            this.lblToplamBorc2.Size = new System.Drawing.Size(0, 27);
            this.lblToplamBorc2.TabIndex = 16;
            // 
            // lblOdenenTutar2
            // 
            this.lblOdenenTutar2.AutoSize = true;
            this.lblOdenenTutar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdenenTutar2.Location = new System.Drawing.Point(1193, 159);
            this.lblOdenenTutar2.Name = "lblOdenenTutar2";
            this.lblOdenenTutar2.Size = new System.Drawing.Size(0, 27);
            this.lblOdenenTutar2.TabIndex = 17;
            this.lblOdenenTutar2.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblKalanBorc2
            // 
            this.lblKalanBorc2.AutoSize = true;
            this.lblKalanBorc2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanBorc2.Location = new System.Drawing.Point(1193, 224);
            this.lblKalanBorc2.Name = "lblKalanBorc2";
            this.lblKalanBorc2.Size = new System.Drawing.Size(0, 27);
            this.lblKalanBorc2.TabIndex = 18;
            // 
            // OdenenOdenmeyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._75bfb376_e9bc_4baa_be7a_5241f837dca5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1424, 855);
            this.Controls.Add(this.lblKalanBorc2);
            this.Controls.Add(this.lblOdenenTutar2);
            this.Controls.Add(this.lblToplamBorc2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDaireNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKalanBorc);
            this.Controls.Add(this.lblOdenenTutar);
            this.Controls.Add(this.lblToplamBorc);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtAçıklama);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.nudTutar);
            this.Controls.Add(this.cmbSakinler);
            this.Name = "OdenenOdenmeyenForm";
            this.Text = "ÖdenenÖdenmeyenForm";
            this.Load += new System.EventHandler(this.OdenenOdenmeyenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaireNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSakinler;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblToplamBorc;
        private System.Windows.Forms.Label lblOdenenTutar;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDaireNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamBorc2;
        private System.Windows.Forms.Label lblOdenenTutar2;
        private System.Windows.Forms.Label lblKalanBorc2;
    }
}