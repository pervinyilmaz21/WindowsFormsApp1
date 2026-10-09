namespace WindowsFormsApp1
{
    partial class SakinlerForm
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.numericUpDownDaireNo = new System.Windows.Forms.NumericUpDown();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblSakinAd = new System.Windows.Forms.Label();
            this.lblSakinSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblDaireNo = new System.Windows.Forms.Label();
            this.dgvSakinler = new System.Windows.Forms.DataGridView();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaireNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakinler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location = new System.Drawing.Point(689, 504);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(187, 94);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // numericUpDownDaireNo
            // 
            this.numericUpDownDaireNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.numericUpDownDaireNo.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownDaireNo.ForeColor = System.Drawing.Color.Black;
            this.numericUpDownDaireNo.Location = new System.Drawing.Point(894, 115);
            this.numericUpDownDaireNo.Name = "numericUpDownDaireNo";
            this.numericUpDownDaireNo.Size = new System.Drawing.Size(187, 38);
            this.numericUpDownDaireNo.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtAd.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.txtAd.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(894, 194);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(187, 39);
            this.txtAd.TabIndex = 2;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(934, 504);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(147, 94);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "GERİ DÖN";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblSakinAd
            // 
            this.lblSakinAd.AutoSize = true;
            this.lblSakinAd.BackColor = System.Drawing.Color.Black;
            this.lblSakinAd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSakinAd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSakinAd.Location = new System.Drawing.Point(758, 206);
            this.lblSakinAd.Name = "lblSakinAd";
            this.lblSakinAd.Size = new System.Drawing.Size(43, 27);
            this.lblSakinAd.TabIndex = 4;
            this.lblSakinAd.Text = "AD";
            // 
            // lblSakinSoyad
            // 
            this.lblSakinSoyad.AutoSize = true;
            this.lblSakinSoyad.BackColor = System.Drawing.Color.Black;
            this.lblSakinSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSakinSoyad.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSakinSoyad.Location = new System.Drawing.Point(758, 283);
            this.lblSakinSoyad.Name = "lblSakinSoyad";
            this.lblSakinSoyad.Size = new System.Drawing.Size(84, 27);
            this.lblSakinSoyad.TabIndex = 5;
            this.lblSakinSoyad.Text = "SOYAD";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSoyad.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.txtSoyad.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(894, 271);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(187, 39);
            this.txtSoyad.TabIndex = 6;
            // 
            // lblDaireNo
            // 
            this.lblDaireNo.AutoSize = true;
            this.lblDaireNo.BackColor = System.Drawing.Color.Black;
            this.lblDaireNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDaireNo.Location = new System.Drawing.Point(758, 126);
            this.lblDaireNo.Name = "lblDaireNo";
            this.lblDaireNo.Size = new System.Drawing.Size(114, 27);
            this.lblDaireNo.TabIndex = 7;
            this.lblDaireNo.Text = "DAİRE NO";
            // 
            // dgvSakinler
            // 
            this.dgvSakinler.AllowUserToAddRows = false;
            this.dgvSakinler.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvSakinler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSakinler.Location = new System.Drawing.Point(-1, 167);
            this.dgvSakinler.Name = "dgvSakinler";
            this.dgvSakinler.RowHeadersWidth = 51;
            this.dgvSakinler.RowTemplate.Height = 24;
            this.dgvSakinler.Size = new System.Drawing.Size(640, 431);
            this.dgvSakinler.TabIndex = 8;
            // 
            // txtTelNo
            // 
            this.txtTelNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtTelNo.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.txtTelNo.Font = new System.Drawing.Font("Segoe Print", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelNo.ForeColor = System.Drawing.Color.Black;
            this.txtTelNo.Location = new System.Drawing.Point(894, 357);
            this.txtTelNo.Multiline = true;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(187, 39);
            this.txtTelNo.TabIndex = 9;
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.BackColor = System.Drawing.Color.Black;
            this.lblTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelNo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelNo.Location = new System.Drawing.Point(758, 371);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(118, 25);
            this.lblTelNo.TabIndex = 10;
            this.lblTelNo.Text = "Telefon No";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaslik.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslik.Location = new System.Drawing.Point(328, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(394, 34);
            this.lblBaslik.TabIndex = 11;
            this.lblBaslik.Text = "SAKİN EKLEME ALANI";
            // 
            // SakinlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._80e071e2_7a75_4866_a4ac_6b4afc9ea27d;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 721);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.dgvSakinler);
            this.Controls.Add(this.lblDaireNo);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSakinSoyad);
            this.Controls.Add(this.lblSakinAd);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.numericUpDownDaireNo);
            this.Controls.Add(this.btnKaydet);
            this.Name = "SakinlerForm";
            this.Text = "SakinlerForm";
            this.Load += new System.EventHandler(this.SakinlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDaireNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSakinler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown numericUpDownDaireNo;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblSakinAd;
        private System.Windows.Forms.Label lblSakinSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblDaireNo;
        private System.Windows.Forms.DataGridView dgvSakinler;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblBaslik;
    }
}