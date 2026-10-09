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

namespace WindowsFormsApp1
{
    public partial class KayitOlForm : Form
    {
        string connectionString = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True;";
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void KayitOlForm_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection baglanti = new SqlConnection(connectionString);
                string sorgu = "INSERT INTO TblKisiler (KullaniciAd,KullaniciSifre,Rol) VALUES (@KullaniciAd,@KullaniciSifre,@Rol)";

                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    
                    komut.Parameters.AddWithValue("@KullaniciAd", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@KullaniciSifre", txtSifre.Text);
                    komut.Parameters.AddWithValue("@Rol", comboBox1.SelectedItem);

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Kayıt Başarıyla Eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata  oluştu!:" + hata.Message);

            }
        }
    }
}
