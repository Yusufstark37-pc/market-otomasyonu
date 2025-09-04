using MySql.Data.MySqlClient;


namespace marketotomasyonu
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;");
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            try
            {
               conn.Open();
                string sorgu = "SELECT COUNT(*) FROM admin WHERE kullanici_ad = @ad AND sifre = @sifre";
                MySqlCommand komut = new MySqlCommand(sorgu, conn);
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@sifre", txtsifre.Text);

                int sonuc = Convert.ToInt32(komut.ExecuteScalar());

                if (sonuc > 0)
                {
                    Anasayfa ana = new Anasayfa();
                    ana.Show();
                    this.Hide();
                   
                    
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!", "Hata");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }
            finally
            {
               conn.Close();
            }
        }
    }
}
