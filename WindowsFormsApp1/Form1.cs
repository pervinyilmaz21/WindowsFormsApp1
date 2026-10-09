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
    public partial class Form1 : Form

    {

        string connectionString = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }
        


        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
               
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    baglanti.Open();
                    string sorgu = "SELECT COUNT(*) FROM TblKisiler WHERE KullaniciAd=@p1 AND KullaniciSifre=@p2";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1",txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text);

                    int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Giriş Başarılı!");
                        DashboardForm dashboardForm = new DashboardForm();
                        dashboardForm.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Oluştu" + ex.Message);
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitOlForm frmKayit=new KayitOlForm();
            frmKayit.Show();
            
            {
                

            }
        }

        private void lnkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum yeniForm = new SifremiUnuttum();
            yeniForm.Show();
        }
    }
}
