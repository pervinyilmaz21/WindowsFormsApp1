using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL kütüphanesini eklemeyi unutmayın

namespace WindowsFormsApp1
{
    public partial class SakinlerForm : Form
    {
        public SakinlerForm()
        {
            InitializeComponent();
        }

        // Bağlantı dizesi (Görseldeki bilgilere göre)
        string connectionString = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO TblSakinler (SakinAd, SakinSoyad, DaireNo, TelefonNo, BorcAlacakTutar) " +
                                   "VALUES (@p1, @p2, @p3, @p4, @p5)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri tablo yapısına (image_92185c.png) uygun sırayla ekliyoruz
                        command.Parameters.AddWithValue("@p1", txtAd.Text);
                        command.Parameters.AddWithValue("@p2", txtSoyad.Text);

                        // DaireNo veritabanında 3. sırada ve tinyint tipinde
                        command.Parameters.AddWithValue("@p3", numericUpDownDaireNo.Value);

                        // TelefonNo veritabanında 4. sırada ve varchar tipinde
                        command.Parameters.AddWithValue("@p4", txtTelNo.Text);

                        command.Parameters.AddWithValue("@p5", 0);

                        connection.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Sakin başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Temizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Formu temizleme yardımcı metodu
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            numericUpDownDaireNo.Value = 0;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            // Ana menüye veya bir önceki forma dönmek için
            this.Close();
        }

        private void SakinlerForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında yapılacak işlemler (Opsiyonel)
        }
    }
}