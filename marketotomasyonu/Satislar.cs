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

    public partial class Satislar : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Satislar()
        {
            InitializeComponent();
        }
        public void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select * from Satislar", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void Satislar_Load(object sender, EventArgs e)
        {
            verigetir();
        }
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                verigetir(); 
                return;
            }

            conn.Open();
            string searchQuery = "SELECT * FROM Satislar WHERE Barkod LIKE @Barkod";
            cmd = new MySqlCommand(searchQuery, conn);
            cmd.Parameters.AddWithValue("@Barkod", textBox1.Text + "%");

            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string searchQuery = @"SELECT * FROM Satislar 
                                     WHERE DATE(SatisTarihi) = @Tarih";
                
                cmd = new MySqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value.Date);
                
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarih araması yapılırken hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }

}