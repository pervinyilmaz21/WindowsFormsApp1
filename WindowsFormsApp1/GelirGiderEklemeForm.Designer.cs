namespace WindowsFormsApp1
{
    partial class GelirGiderEklemeForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGelirEkle = new System.Windows.Forms.Button();
            this.txtGelirTutar1 = new System.Windows.Forms.TextBox();
            this.dtpGelirTarih1 = new System.Windows.Forms.DateTimePicker();
            this.cmbSakin1 = new System.Windows.Forms.ComboBox();
            this.cmbDaireNo1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGiderEkle = new System.Windows.Forms.Button();
            this.dtpGiderTarih1 = new System.Windows.Forms.DateTimePicker();
            this.txtGiderAciklama1 = new System.Windows.Forms.TextBox();
            this.txtGiderTutar1 = new System.Windows.Forms.TextBox();
            this.cmbPersonel = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._75bfb376_e9bc_4baa_be7a_5241f837dca5;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGelirEkle);
            this.groupBox1.Controls.Add(this.txtGelirTutar1);
            this.groupBox1.Controls.Add(this.dtpGelirTarih1);
            this.groupBox1.Controls.Add(this.cmbSakin1);
            this.groupBox1.Controls.Add(this.cmbDaireNo1);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 632);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(19, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "GELİR TUTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(19, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "SAKİN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "DAİRE NO";
            // 
            // btnGelirEkle
            // 
            this.btnGelirEkle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGelirEkle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirEkle.Location = new System.Drawing.Point(145, 444);
            this.btnGelirEkle.Name = "btnGelirEkle";
            this.btnGelirEkle.Size = new System.Drawing.Size(188, 91);
            this.btnGelirEkle.TabIndex = 6;
            this.btnGelirEkle.Text = "GELİR EKLE";
            this.btnGelirEkle.UseVisualStyleBackColor = false;
            this.btnGelirEkle.Click += new System.EventHandler(this.btnGelirEkle_Click);
            // 
            // txtGelirTutar1
            // 
            this.txtGelirTutar1.Location = new System.Drawing.Point(183, 311);
            this.txtGelirTutar1.Multiline = true;
            this.txtGelirTutar1.Name = "txtGelirTutar1";
            this.txtGelirTutar1.Size = new System.Drawing.Size(121, 32);
            this.txtGelirTutar1.TabIndex = 4;
            // 
            // dtpGelirTarih1
            // 
            this.dtpGelirTarih1.Location = new System.Drawing.Point(154, 47);
            this.dtpGelirTarih1.Name = "dtpGelirTarih1";
            this.dtpGelirTarih1.Size = new System.Drawing.Size(245, 22);
            this.dtpGelirTarih1.TabIndex = 5;
            // 
            // cmbSakin1
            // 
            this.cmbSakin1.FormattingEnabled = true;
            this.cmbSakin1.Location = new System.Drawing.Point(183, 205);
            this.cmbSakin1.Name = "cmbSakin1";
            this.cmbSakin1.Size = new System.Drawing.Size(121, 24);
            this.cmbSakin1.TabIndex = 3;
            // 
            // cmbDaireNo1
            // 
            this.cmbDaireNo1.FormattingEnabled = true;
            this.cmbDaireNo1.Location = new System.Drawing.Point(183, 115);
            this.cmbDaireNo1.Name = "cmbDaireNo1";
            this.cmbDaireNo1.Size = new System.Drawing.Size(121, 24);
            this.cmbDaireNo1.TabIndex = 2;
            this.cmbDaireNo1.SelectedIndexChanged += new System.EventHandler(this.cmbDaireNo1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._75bfb376_e9bc_4baa_be7a_5241f837dca5;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnGiderEkle);
            this.groupBox2.Controls.Add(this.dtpGiderTarih1);
            this.groupBox2.Controls.Add(this.txtGiderAciklama1);
            this.groupBox2.Controls.Add(this.txtGiderTutar1);
            this.groupBox2.Controls.Add(this.cmbPersonel);
            this.groupBox2.Location = new System.Drawing.Point(449, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 632);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(27, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "GİDER AÇIKLAMA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(27, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "GİDER TUTAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "PERSONEL";
            // 
            // btnGiderEkle
            // 
            this.btnGiderEkle.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnGiderEkle.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderEkle.Location = new System.Drawing.Point(169, 444);
            this.btnGiderEkle.Name = "btnGiderEkle";
            this.btnGiderEkle.Size = new System.Drawing.Size(188, 91);
            this.btnGiderEkle.TabIndex = 4;
            this.btnGiderEkle.Text = "GİDER EKLE";
            this.btnGiderEkle.UseVisualStyleBackColor = false;
            this.btnGiderEkle.Click += new System.EventHandler(this.btnGiderEkle_Click);
            // 
            // dtpGiderTarih1
            // 
            this.dtpGiderTarih1.Location = new System.Drawing.Point(195, 47);
            this.dtpGiderTarih1.Name = "dtpGiderTarih1";
            this.dtpGiderTarih1.Size = new System.Drawing.Size(221, 22);
            this.dtpGiderTarih1.TabIndex = 3;
            // 
            // txtGiderAciklama1
            // 
            this.txtGiderAciklama1.Location = new System.Drawing.Point(236, 318);
            this.txtGiderAciklama1.Name = "txtGiderAciklama1";
            this.txtGiderAciklama1.Size = new System.Drawing.Size(121, 22);
            this.txtGiderAciklama1.TabIndex = 2;
            // 
            // txtGiderTutar1
            // 
            this.txtGiderTutar1.Location = new System.Drawing.Point(236, 205);
            this.txtGiderTutar1.Name = "txtGiderTutar1";
            this.txtGiderTutar1.Size = new System.Drawing.Size(121, 22);
            this.txtGiderTutar1.TabIndex = 1;
            // 
            // cmbPersonel
            // 
            this.cmbPersonel.FormattingEnabled = true;
            this.cmbPersonel.Location = new System.Drawing.Point(236, 113);
            this.cmbPersonel.Name = "cmbPersonel";
            this.cmbPersonel.Size = new System.Drawing.Size(121, 24);
            this.cmbPersonel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(905, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 632);
            this.dataGridView1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Highlight;
            this.label7.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(507, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "GELİR GİDER EKLEME ALANI";
            // 
            // GelirGiderEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._75bfb376_e9bc_4baa_be7a_5241f837dca5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1545, 830);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GelirGiderEklemeForm";
            this.Text = "GelirGiderEklemeForm";
            this.Load += new System.EventHandler(this.GelirGiderEklemeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbDaireNo1;
        private System.Windows.Forms.ComboBox cmbSakin1;
        private System.Windows.Forms.Button btnGelirEkle;
        private System.Windows.Forms.TextBox txtGelirTutar1;
        private System.Windows.Forms.DateTimePicker dtpGelirTarih1;
        private System.Windows.Forms.Button btnGiderEkle;
        private System.Windows.Forms.DateTimePicker dtpGiderTarih1;
        private System.Windows.Forms.TextBox txtGiderAciklama1;
        private System.Windows.Forms.TextBox txtGiderTutar1;
        private System.Windows.Forms.ComboBox cmbPersonel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}