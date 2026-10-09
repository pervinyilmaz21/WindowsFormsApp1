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
    public partial class GelirGiderEklemeForm : Form
    {
        public GelirGiderEklemeForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection (@"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;");

        private void GelirGiderEklemeForm_Load(object sender, EventArgs e)
        {
            ComboboxlariDoldur();
            VerileriListele();
        }
        private void ComboboxlariDoldur()
        {
            try
            {
                baglanti.Open();
                SqlCommand komutDaire = new SqlCommand("SELECT Daireid,DaireNo FROM TblDaireler", baglanti);
                SqlDataReader drDaire = komutDaire.ExecuteReader();
                while (drDaire.Read())
                {
                    cmbDaireNo1.Items.Add(drDaire["DaireNo"].ToString());
                }
                drDaire.Close();

                SqlCommand komutSakin = new SqlCommand("SELECT İD,SakinAd + ' ' + SakinSoyad AS AdSoyad FROM TblSakinler", baglanti);
                SqlDataReader drSakin = komutSakin.ExecuteReader();
                while (drSakin.Read())
                {
                    cmbSakin1.Items.Add(drSakin["AdSoyad"].ToString());
                }
                drSakin.Close();

                SqlCommand komutpersonel = new SqlCommand("SELECT id, PersonelAd + ' ' + PersonelSoyad + ' ' + Gorev AS AdSoyadGorev FROM TblPersonel", baglanti);

                SqlDataReader drPersonel = komutpersonel.ExecuteReader();
                while (drPersonel.Read())
                {
                    cmbPersonel.Items.Add(drPersonel["AdSoyadGorev"].ToString());
                }
                drPersonel.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu:" + ex.Message);
                 
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void VerileriListele()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Aidatid AS 'İşlem ID',DaireNo AS 'Daire No',Tutar,Tarih,Durum FROM TblAidatlar", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
            finally 
            { 
                baglanti.Close();
            }
        }

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGelirTutar1.Text)|| cmbDaireNo1.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen daire no ve tutar alanlarını doldurun!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                baglanti.Open();
                string sorgu = "INSERT INTO TblAidatlar (DaireNo,Tutar,Tarih,Durum) VALUES (@daire,@tutar,@tarih,@durum)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@daire", cmbDaireNo1.SelectedItem.ToString());
                komut.Parameters.AddWithValue("@tutar", Convert.ToDecimal(txtGelirTutar1.Text));
                komut.Parameters.AddWithValue("@tarih", dtpGelirTarih1.Value);
                komut.Parameters.AddWithValue("@durum", "Ödendi");
                komut.ExecuteNonQuery();

                MessageBox.Show("Gelir(Aidat) kaydı başarıyla veritabanına eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gelir eklenirken hata oluştu:" + ex.Message);
            }
            finally
            {
                baglanti.Close();
                VerileriListele();
            }
        }

        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtGiderTutar1.Text)|| cmbPersonel.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen personel ve gider tutarı alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                baglanti.Open();
                string sorgu = "INSERT INTO TblAidatlar (daireNo,Tutar,Tarih,Durum) VALUES (@daire,@tutar,@tarih,@durum)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@daire","0");
                komut.Parameters.AddWithValue("@tutar", Convert.ToDecimal(txtGiderTutar1.Text) * -1);
                komut.Parameters.AddWithValue("@tarih", dtpGiderTarih1.Value);
                komut.Parameters.AddWithValue("@durum", cmbPersonel.Text + " - " + txtGiderAciklama1.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Gider kaydı(kasa çıkışı) başarıyla işlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Gider eklenirken hata oluştu:" + ex.Message);
            }
            finally
            {
                baglanti.Close();
                VerileriListele();
            }
        }

        private void cmbDaireNo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDaireNo1.SelectedIndex == -1) return;
            try
            {
                cmbSakin1.Items.Clear();
                baglanti.Open();
                string sorgu = "SELECT SakinAd,SakinSoyad FROM TblSakinler WHERE DaireNo =@p1";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", cmbDaireNo1.SelectedItem.ToString());

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    string tamAD = dr["SakinAd"].ToString() + " " + dr["SakinSoyad"].ToString();
                    cmbSakin1.Items.Add(tamAD); 
                    cmbSakin1.SelectedIndex = 0;
                }
                else
                {
                    cmbSakin1.Text = "Daire Boş/Sakin Yok";
                }
                dr.Close();
            }
            catch( Exception ex )
            {
                MessageBox.Show("Sakin bilgisi getirilirken hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
