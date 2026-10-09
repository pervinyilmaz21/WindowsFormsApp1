namespace WindowsFormsApp1
{
    partial class AidatForm
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
            this.txtAidatTutar = new System.Windows.Forms.TextBox();
            this.cmbDaire = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.lblDaireNoAidatFormu = new System.Windows.Forms.Label();
            this.lblTutarAidatFormu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAidatTutar
            // 
            this.txtAidatTutar.BackColor = System.Drawing.SystemColors.Control;
            this.txtAidatTutar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAidatTutar.ForeColor = System.Drawing.Color.White;
            this.txtAidatTutar.Location = new System.Drawing.Point(655, 288);
            this.txtAidatTutar.Multiline = true;
            this.txtAidatTutar.Name = "txtAidatTutar";
            this.txtAidatTutar.Size = new System.Drawing.Size(200, 35);
            this.txtAidatTutar.TabIndex = 0;
            // 
            // cmbDaire
            // 
            this.cmbDaire.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDaire.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDaire.ForeColor = System.Drawing.Color.Black;
            this.cmbDaire.FormattingEnabled = true;
            this.cmbDaire.Location = new System.Drawing.Point(655, 138);
            this.cmbDaire.Name = "cmbDaire";
            this.cmbDaire.Size = new System.Drawing.Size(200, 31);
            this.cmbDaire.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 28);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Sienna;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(327, 637);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(247, 96);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Sienna;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Location = new System.Drawing.Point(646, 638);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(247, 96);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblBaslık.Font = new System.Drawing.Font("ROG Fonts", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaslık.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBaslık.Location = new System.Drawing.Point(264, 9);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(474, 28);
            this.lblBaslık.TabIndex = 5;
            this.lblBaslık.Text = "AİDAT TAKİP VE ÖDEME SİSTEMİ";
            this.lblBaslık.Click += new System.EventHandler(this.lblBaslık_Click);
            // 
            // lblDaireNoAidatFormu
            // 
            this.lblDaireNoAidatFormu.AutoSize = true;
            this.lblDaireNoAidatFormu.BackColor = System.Drawing.Color.Black;
            this.lblDaireNoAidatFormu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaireNoAidatFormu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDaireNoAidatFormu.Location = new System.Drawing.Point(517, 143);
            this.lblDaireNoAidatFormu.Name = "lblDaireNoAidatFormu";
            this.lblDaireNoAidatFormu.Size = new System.Drawing.Size(102, 27);
            this.lblDaireNoAidatFormu.TabIndex = 6;
            this.lblDaireNoAidatFormu.Text = "Daire No";
            // 
            // lblTutarAidatFormu
            // 
            this.lblTutarAidatFormu.AutoSize = true;
            this.lblTutarAidatFormu.BackColor = System.Drawing.Color.Black;
            this.lblTutarAidatFormu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutarAidatFormu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTutarAidatFormu.Location = new System.Drawing.Point(517, 296);
            this.lblTutarAidatFormu.Name = "lblTutarAidatFormu";
            this.lblTutarAidatFormu.Size = new System.Drawing.Size(66, 27);
            this.lblTutarAidatFormu.TabIndex = 7;
            this.lblTutarAidatFormu.Text = "Tutar";
            // 
            // AidatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._75bfb376_e9bc_4baa_be7a_5241f837dca5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 772);
            this.Controls.Add(this.lblTutarAidatFormu);
            this.Controls.Add(this.lblDaireNoAidatFormu);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbDaire);
            this.Controls.Add(this.txtAidatTutar);
            this.Name = "AidatForm";
            this.Text = "AidatForm";
            this.Load += new System.EventHandler(this.AidatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAidatTutar;
        private System.Windows.Forms.ComboBox cmbDaire;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Label lblDaireNoAidatFormu;
        private System.Windows.Forms.Label lblTutarAidatFormu;
    }
}