using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BorçlularForm : Form
    {


        string baglantiCumlesi = @"Data Source=LAPTOP-6CJSKKBD\SQLEXPRESS;Initial Catalog=DBApartmanYonetim;Integrated Security=True";
        public BorçlularForm()
        {
            InitializeComponent();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblToplamBorcdeger_Click(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(baglantiCumlesi))
            {
                con.Open();
                string query = "SELECT DaireNo, Sakinid ,KalanBorc, Durum FROM TblAidatlar WHERE 1=1";
                if (!string.IsNullOrEmpty(txtArama.Text))
                {
                    query += "AND DaireNo='" + txtArama.Text + "'";
                }
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBüyükListeTablosu.DataSource = dt;

                string sumQuery = "SELECT SUM (KalanBorc) FROM TblAidatlar WHERE 1= 1 ";
                if (!string.IsNullOrEmpty(txtArama.Text))
                {
                    sumQuery += "AND DaireNo='" + txtArama.Text + "'";
                }
                SqlCommand cmb = new SqlCommand(sumQuery, con);
                object result = cmb.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    lblToplamBorcdeger.Text = " " + result.ToString() + "TL";
                }
                else
                {
                    lblToplamBorcdeger.Text = " 0 TL ";
                }
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewBüyükListeTablosu.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Seçili Kaydı Silmek İStediğinizden Emin Misiniz?", "Silme Onayı",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(dataGridViewBüyükListeTablosu.SelectedRows[0].Cells["Sakinid"].Value);
                        using (SqlConnection con = new SqlConnection(baglantiCumlesi))
                        {
                            string query = "DELETE FROM TblAidatlar WHERE Sakinid = @id";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@id", id);
                            con.Open();
                            cmd.ExecuteNonQuery();

                        }
                        btnListele_Click(null, null);
                        MessageBox.Show("Kayıt Başarıyla Silindi.");



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme işlemi esnasında hata oluştu: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İçin Bir Satır Seçin.");
            }
        }

        private void btnTumunuGOSTER_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(baglantiCumlesi))
            {
                if (con.State == ConnectionState.Closed)
                { con.Open(); }

                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string sorgu = "SELECT Sakinid,DaireNo, KalanBorc, Durum FROM TblAidatlar";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewBüyükListeTablosu.DataSource = dt;
                    txtArama.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler listelenirken bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
                


                
            }
        }
    }
}
