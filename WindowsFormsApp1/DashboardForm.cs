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
    public partial class DashboardForm : Form
    {
        string connectionString = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";
        private void Verilerigetir()
        {
            using (SqlConnection bağlanti = new SqlConnection(connectionString))
            {
                try
                {
                    bağlanti.Open();
                    // KRİTİK DÜZELTME: Sorguya 'id' sütununu ekledik.
                    string sorgu = "SELECT id, SakinAd, SakinSoyad, DaireNo, BorcAlacakTutar, TelefonNo FROM TblSakinler";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, bağlanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    // Eğer ID sütununun tabloda görünmesini istemiyorsan şu satırı ekleyebilirsin:
                    // dataGridView1.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
            }
        }

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void sakinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SakinlerForm frm = new SakinlerForm();
            frm.Show();
            
        }

        private void AidatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AidatForm frm = new AidatForm();
            frm.Show();
            
        }

        private void BorçlularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BorçlularForm frm = new BorçlularForm();
            frm.Show();
            
        }

        private void GelirGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdenenOdenmeyenForm frm = new OdenenOdenmeyenForm();
            frm.Show();
            

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            Verilerigetir();
            
        }

        private void lblBorcTutarı_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    string sorgu = "INSERT INTO TblSakinler (SakinAd ,SakinSoyad, DaireNo  ,BorcAlacakTutar, telefonNo) VALUES (@Sakinad,@sakinsoyad, @Daireno, @Borcalacaktutar, @Telno)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    string temizTelefon = maskedTextBox1.Text.Replace("(", " ").Replace(")", " ").Replace("-", "").Replace(" ", "");


                    komut.Parameters.AddWithValue("@Sakinad", txtAd.Text.Trim());
                    komut.Parameters.AddWithValue("@sakinsoyad", txtSoyad.Text.Trim());
                    komut.Parameters.AddWithValue("@Daireno", Convert.ToInt32(txtDaireNo.Text));
                    komut.Parameters.AddWithValue("@Borcalacaktutar",Convert.ToInt32(txtBorcAlacak.Text));
                    komut.Parameters.AddWithValue("Telno", Convert.ToInt64(temizTelefon));

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kayıt başarıyla Eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtAd.Clear();
                    txtDaireNo.Clear();
                    txtBorcAlacak.Clear();
                    maskedTextBox1.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // CurrentRow kullanımı sadece hücre seçilse bile satırı bulur
            if (dataGridView1.CurrentRow != null)
            {
                using (SqlConnection bağlanti = new SqlConnection(connectionString))
                {
                    try
                    {
                        // DataGridView'deki ID sütun isminin "id" olduğundan emin olun
                        int seciliId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

                        bağlanti.Open();
                        string sorgu = "UPDATE TblSakinler SET SakinAd=@ad, SakinSoyad=@Soyad, DaireNo=@daire, BorcAlacakTutar=@borc, TelefonNo=@tel WHERE id=@id";

                        using (SqlCommand komut = new SqlCommand(sorgu, bağlanti))
                        {
                            komut.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                            komut.Parameters.AddWithValue("@daire", Convert.ToInt32(txtDaireNo.Text));
                            komut.Parameters.AddWithValue("@borc", Convert.ToInt32(txtBorcAlacak.Text));
                            komut.Parameters.AddWithValue("@tel", maskedTextBox1.Text);
                            komut.Parameters.AddWithValue("@id", seciliId);

                            int sonuc = komut.ExecuteNonQuery();

                            if (sonuc > 0)
                            {
                                MessageBox.Show("Sakin bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Verilerigetir(); // Listeyi yenile
                                Temizle(); // Kutuları boşalt
                            }
                            else
                            {
                                MessageBox.Show("Güncellenecek kayıt bulunamadı (ID eşleşmedi).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata detayı: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtDaireNo.Clear();
            txtBorcAlacak.Clear();
            maskedTextBox1.Clear();
        }


        private void btnSil_Click(object sender, EventArgs e)
        
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int seciliId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                

                DialogResult onay = MessageBox.Show($" isimli sakini ve tüm borç/alacak kayıtlarını silmek istediğinize emin misiniz?",
                                                      "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    using (SqlConnection baglanti = new SqlConnection(connectionString))
                    {
                        try
                        {
                            baglanti.Open();

                            string sorgu = "DELETE FROM TblSakinler WHERE id=@id";

                            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                            {
                                komut.Parameters.AddWithValue("@id", seciliId);

                                int sonuc = komut.ExecuteNonQuery();

                                if (sonuc > 0)
                                {
                                    MessageBox.Show("Kayıt veritabanından başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                                    Verilerigetir();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        

        private void btnAra_Click(object sender, EventArgs e)
        
        {
            string arananIsim = txtİsimGir.Text.Trim();

            if (string.IsNullOrEmpty(arananIsim))
            {
                Verilerigetir();
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT id, SakinAd, SakinSoyad, DaireNo, BorcAlacakTutar, TelefonNo FROM TblSakinler WHERE SakinAd LIKE @aranan OR SakinSoyad LIKE @aranan";

                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@aranan", "%" + arananIsim + "%");

                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Aradığınız kriterlere uygun kayıt bulunamadı.", "Arama Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("UYGULAMADAN ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?","ÇIKIŞ ONAYI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satırın geçerli olduğundan emin olalım (başlık satırı değilse)
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Tablo sırasına göre (id, ad, soyad, daire, borc, tel) indeksleri ayarlıyoruz:
                    // Eğer id sütunu en baştaysa 0 numaralı indekstir.

                    txtAd.Text = row.Cells[1].Value.ToString();           // 1. Sütun: SakinAd
                    txtSoyad.Text = row.Cells[2].Value.ToString();        // 2. Sütun: SakinSoyad
                    txtDaireNo.Text = row.Cells[3].Value.ToString();      // 3. Sütun: DaireNo
                    txtBorcAlacak.Text = row.Cells[4].Value.ToString();   // 4. Sütun: BorcAlacakTutar

                    // Telefon numarası genellikle 5. sütundadır
                    if (row.Cells[5].Value != null)
                        maskedTextBox1.Text = row.Cells[5].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hücre okuma hatası: " + ex.Message);
                }
            }
        }

        private void gELİRGİDEREKLEMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGiderEklemeForm frm=new GelirGiderEklemeForm();
            frm.Show();
        }
    }
}
