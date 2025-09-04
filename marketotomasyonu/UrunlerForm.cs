using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace marketotomasyonu
{
    public partial class UrunlerForm : Form
    {
        
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public UrunlerForm()
        {
            InitializeComponent();
            
        }
        public void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select * from Urunler", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private string BarkodOlustur()
        {
            Random rand = new Random();
            string barkod = rand.Next(10000000, 99999999).ToString();
            return barkod;
        }
        private void Ürün_Yöneticisi_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yeniBarkod = BarkodOlustur();
            txtbarkod.Text = yeniBarkod;
            string sql = "INSERT INTO Urunler(Barkod,UrunAdi,Kategori,Marka,AlisFiyati,SatisFiyati,UrunBirim,Stok)"
                       + " VALUES(@barkod,@urunad,@kategori,@marka,@alisfiyat,@satisfiyat,@urunbirim,@stok)";
            cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@barkod", txtbarkod.Text);
            cmd.Parameters.AddWithValue("@urunad", txturunad.Text);
            cmd.Parameters.AddWithValue("@kategori", cmbkategori.Text);
            cmd.Parameters.AddWithValue("@marka", cmbmarka.Text);
            cmd.Parameters.AddWithValue("@alisfiyat", txtalisfiyat.Text);
            cmd.Parameters.AddWithValue("@satisfiyat", txtsatisfiyat.Text);
            cmd.Parameters.AddWithValue("@urunbirim", txtbirim.Text);
            cmd.Parameters.AddWithValue("@stok", txtstok.Text);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();

       
          

            
        }
      
   



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.CurrentCell.RowIndex;


            txturunid.Text = dataGridView1.Rows[secilen].Cells["UrunID"].Value.ToString();
            txtbarkod.Text = dataGridView1.Rows[secilen].Cells["Barkod"].Value.ToString();
            txturunad.Text = dataGridView1.Rows[secilen].Cells["UrunAdi"].Value.ToString();
            cmbkategori.Text = dataGridView1.Rows[secilen].Cells["Kategori"].Value.ToString();
            cmbmarka.Text = dataGridView1.Rows[secilen].Cells["Marka"].Value.ToString();
            txtalisfiyat.Text = dataGridView1.Rows[secilen].Cells["AlisFiyati"].Value.ToString();
            txtsatisfiyat.Text = dataGridView1.Rows[secilen].Cells["SatisFiyati"].Value.ToString();
            txtbirim.Text = dataGridView1.Rows[secilen].Cells["UrunBirim"].Value.ToString();
            txtstok.Text = dataGridView1.Rows[secilen].Cells["Stok"].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "DELETE FROM Urunler WHERE UrunID = @id";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", txturunid.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Urunler SET Barkod = @barkod, UrunAdi = @urunad, Kategori = @kategori, Marka = @marka, AlisFiyati=@alisfiyat,SatisFiyati=@satisfiyat, UrunBirim = @urunbirim, Stok = @stok WHERE UrunID = @id";
            cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@barkod", txtbarkod.Text);
            cmd.Parameters.AddWithValue("@urunad", txturunad.Text);
            cmd.Parameters.AddWithValue("@kategori", cmbkategori.Text);
            cmd.Parameters.AddWithValue("@marka", cmbmarka.Text);
            cmd.Parameters.AddWithValue("@alisfiyat", txtalisfiyat.Text);
            cmd.Parameters.AddWithValue("@satisfiyat", txtsatisfiyat.Text);
            cmd.Parameters.AddWithValue("@urunbirim", txtbirim.Text);
            cmd.Parameters.AddWithValue("@stok", txtstok.Text);
            cmd.Parameters.AddWithValue("@id", txturunid.Text);



            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();

        }

        private void txtmarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbkategori.SelectedIndex == -1 || txtmarka.Text == "")
            {
                MessageBox.Show("Lütfen kategori seçin ve yeni marka adını girin.");
                return;
            }

            string sql = "INSERT INTO Markalar (MarkaAdi, Kategori) VALUES (@markaadi, @kategori)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@markaadi", txtmarka.Text); 
            cmd.Parameters.AddWithValue("@kategori", cmbkategori.SelectedItem.ToString()); 

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Yeni marka başarıyla eklendi.");
            txtmarka.Clear();
            cmbkategori_SelectedIndexChanged(sender, e); 
        }
        

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbmarka.Items.Clear(); 
            string secilenKategori = cmbkategori.SelectedItem.ToString();

            conn.Open();
            string sql = "SELECT MarkaAdi FROM Markalar WHERE Kategori = @kategori";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kategori", secilenKategori);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbmarka.Items.Add(reader["MarkaAdi"].ToString());
            }

            conn.Close();
        }
    }
    }


