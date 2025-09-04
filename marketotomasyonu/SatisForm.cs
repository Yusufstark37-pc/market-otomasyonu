using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace marketotomasyonu
{
    public partial class SatisForm : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;");
        decimal toplamTutar = 0;
        public SatisForm()
        {
            InitializeComponent();
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {

            datagridView1.Columns.Clear();
            datagridView1.Columns.Add("Barkod", "Barkod");
            datagridView1.Columns.Add("UrunAdi", "Ürün Adı");
            datagridView1.Columns.Add("Marka", "Marka");
            datagridView1.Columns.Add("Fiyat", "Fiyat");
            datagridView1.Columns.Add("Adet", "Adet");

            VeritabanindakiUrunleriButonlaEkle();

            if (!datagridView1.Columns.Contains("Sil"))
            {
                DataGridViewButtonColumn silbtn = new DataGridViewButtonColumn();
                silbtn.Name = "Sil";
                silbtn.HeaderText = "İşlem";
                silbtn.Text = "X";
                silbtn.UseColumnTextForButtonValue = true;
                datagridView1.Columns.Add(silbtn);
                datagridView1.CellPainting += datagridView1_CellPainting;
            }

        }

        private void VeritabanindakiUrunleriButonlaEkle()
        {
            conn.Open();
            string sql = "SELECT UrunAdi, Marka, SatisFiyati, Kategori, Barkod FROM Urunler";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            foreach (TabPage tab in tabControl1.TabPages)
            {
                var urunButonlari = tab.Controls.OfType<Button>().ToList();
                foreach (var btn in urunButonlari)
                {
                    tab.Controls.Remove(btn);
                }

                var adetKontrolleri = tab.Controls.OfType<NumericUpDown>().ToList();
                foreach (var adetInput in adetKontrolleri)
                {
                    tab.Controls.Remove(adetInput);
                }
            }

            while (reader.Read())
            {
                string urunAdi = reader["UrunAdi"].ToString();
                string marka = reader["Marka"].ToString();
                string fiyat = reader["SatisFiyati"].ToString();
                string kategori = reader["Kategori"].ToString();
                string barkod = reader["Barkod"].ToString();

                TabPage hedefTab = null;
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    if (tab.Text == kategori)
                    {
                        hedefTab = tab;
                        break;
                    }
                }

                if (hedefTab == null)
                    continue;

                Button newButton = new Button();
                newButton.Size = new Size(100, 70);
                newButton.Text = $"Ürün: {urunAdi}\nMarka: {marka}\nFiyat: {fiyat}";
                newButton.BackColor = Color.White;

                int butonSayisi = hedefTab.Controls.OfType<Button>().Count();
                int x = 10 + (butonSayisi % 2) * 170;
                int y = 10 + (butonSayisi / 2) * 80;
                newButton.Location = new Point(x, y);
                newButton.Tag = barkod;

                NumericUpDown adetInput = new NumericUpDown();
                adetInput.Minimum = 1;
                adetInput.Maximum = 100;
                adetInput.Value = 1;
                adetInput.Location = new Point(x + 100, y);
                adetInput.Size = new Size(60, 30);

                newButton.Click += (sender, e) =>
                {
                    int adet = (int)adetInput.Value;
                    decimal birimFiyat = Convert.ToDecimal(fiyat);
                    decimal araTutar = birimFiyat * adet;
                    toplamTutar += araTutar;

                    datagridView1.Rows.Add(barkod, urunAdi, marka, fiyat, adet);

                    tutarlbl.Text = $"Toplam Tutar: {toplamTutar:N2} TL";


                };


                hedefTab.Controls.Add(newButton);
                hedefTab.Controls.Add(adetInput);
            }

            conn.Close();
        }

        private void satisyapbtn_Click(object sender, EventArgs e)
        {
            SatisTamamla form = new SatisTamamla(datagridView1);
            form.ShowDialog();

        }

        private void silbtn_Click(object sender, EventArgs e)
        {

        }

        private void datagridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                // Sütun "Sil" ise ve geçerli satırsa
                if (datagridView1.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
                {
                    // Satır silinmeden önce ara toplamı düş
                    int adet = Convert.ToInt32(datagridView1.Rows[e.RowIndex].Cells["Adet"].Value);
                    decimal fiyat = Convert.ToDecimal(datagridView1.Rows[e.RowIndex].Cells["Fiyat"].Value);
                    toplamTutar -= adet * fiyat;

                    datagridView1.Rows.RemoveAt(e.RowIndex);
                    tutarlbl.Text = $"Toplam Tutar: {toplamTutar:N2} TL";
                }

            }
        }

        private void datagridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || datagridView1.Rows[e.RowIndex].IsNewRow)
                return;
            if (e.ColumnIndex >= 0 && datagridView1.Columns[e.ColumnIndex].Name == "Sil" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                using (Brush brush = new SolidBrush(Color.Red))
                {
                    Font font = new Font("Segoe UI", 12, FontStyle.Bold);
                    TextRenderer.DrawText(e.Graphics, "X", font, e.CellBounds, Color.Red,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }

                e.Handled = true;
            }
        }
    }
}


