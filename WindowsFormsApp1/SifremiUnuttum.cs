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
    public partial class SifremiUnuttum : Form
    {

        string baglantiYolu = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";
        
            
        public SifremiUnuttum()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);

        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Yeni Şifreler Birbiriyle Uyuşmuyor!");
                return;
            }

            try
            {


                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                string sorgu = "UPDATE TblKisiler SET KullaniciSifre=@p1 WHERE KullaniciAd=@p2";


                using (SqlCommand komut = new SqlCommand(sorgu, baglanti)) 
                {
                    baglanti.Open();
                    komut.Parameters.AddWithValue("@p1", txtYeniSifre.Text);
                    komut.Parameters.AddWithValue("@p2", txtKullaniciAdi.Text);

                    int sonuc = komut.ExecuteNonQuery();


                    if (sonuc > 0)
                    {
                        MessageBox.Show("Şifreniz Başarıyla Güncellendi!");
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Bulunamadı!");
                    }
                    baglanti.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu:" + ex.Message);
            }
            
        }
    }
}
