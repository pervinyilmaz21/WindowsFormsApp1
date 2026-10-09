using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AidatForm:Form
    {
        public AidatForm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(txtAidatTutar.Text) || cmbDaire.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // Not: Tutar için decimal, DaireNo için nvarchar kullandık (Tablo yapınıza göre)
                    string sorgu = "INSERT INTO TblAidatlar (DaireNo, Tutar, Tarih, Durum) VALUES (@p1, @p2, @p3, @p4)";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@p1", cmbDaire.Text); // Seçili daire no
                        komut.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtAidatTutar.Text)); // Decimal(18,2)
                        komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value); // DateTime
                        komut.Parameters.AddWithValue("@p4", "Ödenmedi"); // Varsayılan durum

                        // Not: Sakinid sütununuz 'null' geçilebilir değilse buraya eklemeniz gerekir.
                        // komut.Parameters.AddWithValue("@p5", 1); // Örnek Sakinid

                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Aidat kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DaireleriGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    // DISTINCT kullanarak her daire numarasının listede sadece 1 kez görünmesini sağlıyoruz
                    string sorgu = "SELECT DISTINCT DaireNo FROM TblSakinler ORDER BY DaireNo ASC";

                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader dr = komut.ExecuteReader();

                    cmbDaire.Items.Clear(); // Listeyi önce temizleyelim

                    while (dr.Read())
                    {
                        // Veritabanındaki DaireNo'yu ComboBox'a ekle
                        cmbDaire.Items.Add(dr["DaireNo"].ToString());
                    }

                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Daire listesi yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }

        private void lblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void AidatForm_Load(object sender, EventArgs e)
        {
            DaireleriGetir(); 
        }
    }

}
