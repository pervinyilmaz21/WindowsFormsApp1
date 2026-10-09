using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
namespace WindowsFormsApp1
{
    public partial class OdenenOdenmeyenForm : Form
    {
        string baglantiCumlesi = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True";
        public OdenenOdenmeyenForm()
        {
            InitializeComponent();
            SqlConnection baglanti;
        }

        private void OdenenOdenmeyenForm_Load(object sender, EventArgs e)
        {

             SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            {
                string sorgu = "SELECT id AS Sakinid, SakinAd + ' ' + SakinSoyad AS AdSoyad FROM TblSakinler";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbSakinler.DataSource = dt;

                cmbSakinler.DisplayMember = "AdSoyad"; 
                cmbSakinler.ValueMember = "Sakinid";
               
            }
            lblToplamBorc2.Text = "1000";
        }
            void Listele()
            {
            dataGridView1.Refresh();
               
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    string sorgu = "SELECT * FROM TblAidatlar";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu,baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

            }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                {
                    
                    String sorgu = "INSERT INTO  TblAidatlar  ( DaireNo, ToplamTutar, OdenenTutar, KalanBorc, Durum, Tutar, Tarih,Sakinid) VALUES(@daireno,@toplamtutar,@odenentutar,@kalanborc,@durum,@tutar,@tarih, @Sakinid)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@daireno", nudDaireNo.Value);
                    int toplamBorc = int.TryParse(lblToplamBorc2.Text, out int tb) ? tb : 0;
                    int odenenTutar = int.TryParse(lblOdenenTutar2.Text, out int ot) ? ot : 0;
                    int kalanBorc = toplamBorc- odenenTutar;
                    komut.Parameters.AddWithValue("@toplamtutar", 1000);
                    komut.Parameters.AddWithValue("@odenentutar", nudTutar.Value);
                    komut.Parameters.AddWithValue("@kalanborc", 1000 - nudTutar.Value);
                    
                    komut.Parameters.AddWithValue("@durum", txtAçıklama.Text); 
                    komut.Parameters.AddWithValue("@tutar", nudTutar.Value);
                    komut.Parameters.AddWithValue("@tarih", dateTimePickerTarih.Value);
                    komut.Parameters.AddWithValue("@Sakinid", cmbSakinler.SelectedValue);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Başarıyla Kaydedildi!");
                    MessageBox.Show("Ödemeyi Yaptığınız İçin Teşekkür Ederiz! Sağlıklı ve Huzurlu Günler Dileriz!");
                    Listele();
                }
            }
                catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
                if (dataGridView1.CurrentRow != null)
            {
                DialogResult onay = MessageBox.Show("Seçili Ödeme Kaydını Silmek İstediğinizden Emin Misiniz?", "SilmeOnayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                        try
                        {
                            int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Aidatid"].Value);
                            if (baglanti.State == ConnectionState.Closed)
                                baglanti.Open();
                            string sorgu = " DELETE FROM TblAidatlar WHERE Aidatid =@id";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);
                            komut.Parameters.AddWithValue("@id", seciliid);
                            komut.ExecuteNonQuery();

                            MessageBox.Show("Kayıt Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Listele();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu:" + ex.Message);
                        }
                        finally
                        {
                            baglanti.Close();
                        }
                }
            }
            else
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Satırı Tablodan Seçiniz.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void cmbSakinler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudTutar_ValueChanged(object sender, EventArgs e)
        {
            int toplamBorc = 1000;
            int odenenTutar = Convert.ToInt32(nudTutar.Value);
            int kalanBorc = toplamBorc - odenenTutar;

            lblOdenenTutar2.Text = odenenTutar.ToString();
            lblToplamBorc2.Text = toplamBorc.ToString();
            lblKalanBorc2.Text = kalanBorc.ToString();
        }
    }
    
}
