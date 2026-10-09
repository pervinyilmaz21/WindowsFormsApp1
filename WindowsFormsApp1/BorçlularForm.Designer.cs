namespace WindowsFormsApp1
{
    partial class BorçlularForm
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
            this.dataGridViewBüyükListeTablosu = new System.Windows.Forms.DataGridView();
            this.lblAraBaslık = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblToplamBorcBaslık = new System.Windows.Forms.Label();
            this.lblToplamBorcdeger = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lblBaslık = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTumunuGOSTER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBüyükListeTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBüyükListeTablosu
            // 
            this.dataGridViewBüyükListeTablosu.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewBüyükListeTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBüyükListeTablosu.Location = new System.Drawing.Point(2, 112);
            this.dataGridViewBüyükListeTablosu.Name = "dataGridViewBüyükListeTablosu";
            this.dataGridViewBüyükListeTablosu.RowHeadersWidth = 51;
            this.dataGridViewBüyükListeTablosu.RowTemplate.Height = 24;
            this.dataGridViewBüyükListeTablosu.Size = new System.Drawing.Size(611, 638);
            this.dataGridViewBüyükListeTablosu.TabIndex = 0;
            // 
            // lblAraBaslık
            // 
            this.lblAraBaslık.AutoSize = true;
            this.lblAraBaslık.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAraBaslık.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAraBaslık.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAraBaslık.Location = new System.Drawing.Point(755, 120);
            this.lblAraBaslık.Name = "lblAraBaslık";
            this.lblAraBaslık.Size = new System.Drawing.Size(160, 27);
            this.lblAraBaslık.TabIndex = 1;
            this.lblAraBaslık.Text = "Daire No/İsim:";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(933, 112);
            this.txtArama.Multiline = true;
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(208, 35);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblToplamBorcBaslık
            // 
            this.lblToplamBorcBaslık.AutoSize = true;
            this.lblToplamBorcBaslık.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblToplamBorcBaslık.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorcBaslık.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblToplamBorcBaslık.Location = new System.Drawing.Point(755, 205);
            this.lblToplamBorcBaslık.Name = "lblToplamBorcBaslık";
            this.lblToplamBorcBaslık.Size = new System.Drawing.Size(146, 27);
            this.lblToplamBorcBaslık.TabIndex = 3;
            this.lblToplamBorcBaslık.Text = "Toplam Borç:";
            // 
            // lblToplamBorcdeger
            // 
            this.lblToplamBorcdeger.AutoSize = true;
            this.lblToplamBorcdeger.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBorcdeger.Location = new System.Drawing.Point(928, 205);
            this.lblToplamBorcdeger.Name = "lblToplamBorcdeger";
            this.lblToplamBorcdeger.Size = new System.Drawing.Size(0, 27);
            this.lblToplamBorcdeger.TabIndex = 4;
            this.lblToplamBorcdeger.Click += new System.EventHandler(this.lblToplamBorcdeger_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListele.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(773, 496);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(155, 100);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "LİSTELE";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(986, 640);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(155, 100);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lblBaslık
            // 
            this.lblBaslık.AutoSize = true;
            this.lblBaslık.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblBaslık.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslık.Location = new System.Drawing.Point(431, 0);
            this.lblBaslık.Name = "lblBaslık";
            this.lblBaslık.Size = new System.Drawing.Size(404, 37);
            this.lblBaslık.TabIndex = 7;
            this.lblBaslık.Text = "BORÇ HESAPLAMA EKRANI";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSil.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(986, 496);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 100);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTumunuGOSTER
            // 
            this.btnTumunuGOSTER.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTumunuGOSTER.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumunuGOSTER.Location = new System.Drawing.Point(773, 640);
            this.btnTumunuGOSTER.Name = "btnTumunuGOSTER";
            this.btnTumunuGOSTER.Size = new System.Drawing.Size(155, 100);
            this.btnTumunuGOSTER.TabIndex = 9;
            this.btnTumunuGOSTER.Text = "TÜMÜNÜ GÖSTER";
            this.btnTumunuGOSTER.UseVisualStyleBackColor = false;
            this.btnTumunuGOSTER.Click += new System.EventHandler(this.btnTumunuGOSTER_Click);
            // 
            // BorçlularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._595c72d8_79c2_4af0_8c39_3bc53afcd8e5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1292, 789);
            this.Controls.Add(this.btnTumunuGOSTER);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblBaslık);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblToplamBorcdeger);
            this.Controls.Add(this.lblToplamBorcBaslık);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.lblAraBaslık);
            this.Controls.Add(this.dataGridViewBüyükListeTablosu);
            this.Name = "BorçlularForm";
            this.Text = "BorçlularForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBüyükListeTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBüyükListeTablosu;
        private System.Windows.Forms.Label lblAraBaslık;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblToplamBorcBaslık;
        private System.Windows.Forms.Label lblToplamBorcdeger;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label lblBaslık;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTumunuGOSTER;
    }
}