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
    public partial class Anasayfa : Form
    {
        public static Anasayfa Instance;
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Anasayfa()
        {
            InitializeComponent();
            Instance = this;

        }

        private void SayfaGetir(Form sayfa)
        {
            panelSayfa.Controls.Clear();
            sayfa.TopLevel = false;
            sayfa.FormBorderStyle = FormBorderStyle.None;
            sayfa.Dock = DockStyle.Fill;
            panelSayfa.Controls.Add(sayfa);
            sayfa.Show();
        }
        private void GeriDon()
        {

            panelSayfa.Controls.Clear();
            panelSayfa.Controls.Add(pictureBox2);
            panelSayfa.Controls.Add(urunsayisibtn);
            panelSayfa.Controls.Add(kategoribtn);
            panelSayfa.Controls.Add(markabtn);

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            conn.Open();
            string urunsql = "SELECT COUNT(*) FROM Urunler"; 
            MySqlCommand cmdurun = new MySqlCommand(urunsql, conn);
            int toplamurun = Convert.ToInt32(cmdurun.ExecuteScalar()); 
            urunsayisibtn.Text = $"Toplam Ürün Sayısı: {toplamurun}";
           
            string markasql = "SELECT COUNT(*) FROM Marka";
            MySqlCommand cmdmarka = new MySqlCommand(urunsql, conn);
            int toplammarka = Convert.ToInt32(cmdurun.ExecuteScalar());
            markabtn.Text = $"Toplam Marka Sayısı: {toplammarka}";
            
            string kategorisql = "SELECT COUNT(DISTINCT Kategori) FROM Urunler";
            MySqlCommand cmd = new MySqlCommand(kategorisql, conn);
            int toplamkategori = Convert.ToInt32(cmd.ExecuteScalar());
            kategoribtn.Text = $"Toplam Kategori Sayısı: {toplamkategori}";
            conn.Close();
           
        }

       
        

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayfaGetir(new UrunlerForm());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GeriDon();
        }






        private void panelSayfa_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void satışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayfaGetir(new SatisForm());
        }

        private void satislarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SayfaGetir(new Satislar());
        }
    }
}
