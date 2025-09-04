using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Font = iTextSharp.text.Font;
using Color = iTextSharp.text.BaseColor;

namespace marketotomasyonu
{
    public partial class SatisTamamla : Form
    {
        private double toplamTutar = 0;
        private string connectionString = "Server=localhost;Database=marketotomasyon;Uid=root;Pwd=240304Aa95;";

        public SatisTamamla(DataGridView sourceGridView)
        {
            InitializeComponent();

            
            foreach (DataGridViewColumn col in sourceGridView.Columns)
            {
                satisview.Columns.Add((DataGridViewColumn)col.Clone());
            }

            
            foreach (DataGridViewRow row in sourceGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        newRow.Cells[i].Value = row.Cells[i].Value;
                    }
                    satisview.Rows.Add(newRow);
                }
            }
        }

        private void SatisTamamla_Load(object sender, EventArgs e)
        {
            ToplamTutariHesapla();
            radioButton1.Checked = true; 
        }

        private void ToplamTutariHesapla()
        {
            toplamTutar = 0;
            foreach (DataGridViewRow row in satisview.Rows)
            {
                if (row.Cells["Fiyat"].Value != null && row.Cells["Adet"].Value != null)
                {
                    try
                    {
                        double fiyat = Convert.ToDouble(row.Cells["Fiyat"].Value);
                        int adet = Convert.ToInt32(row.Cells["Adet"].Value);
                        toplamTutar += fiyat * adet;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            tutarlbl.Text = $"Toplam Tutar : {toplamTutar.ToString("N2")} TL";
        }

        private void SatisiTamamla(bool yazdir)
        {
            if (toplamTutar <= 0)
            {
                MessageBox.Show("Sepette ürün bulunmamaktadır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            string odemeTipi;
            if (radioButton1.Checked)
            {
                odemeTipi = "Nakit";
            }
            else if (radioButton2.Checked)
            {
                odemeTipi = "Kart";
            }
            else
            {
                odemeTipi = "Nakit"; // Varsayılan olarak Nakit
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                foreach (DataGridViewRow row in satisview.Rows)
                {
                    if (row.Cells["Barkod"].Value == null ||
                        row.Cells["UrunAdi"].Value == null ||
                        row.Cells["Marka"].Value == null ||
                        row.Cells["Fiyat"].Value == null ||
                        row.Cells["Adet"].Value == null)
                    {
                        continue;
                    }

                    string barkod = row.Cells["Barkod"].Value.ToString();
                    string urunAdi = row.Cells["UrunAdi"].Value.ToString();
                    string marka = row.Cells["Marka"].Value.ToString();
                    decimal satisFiyati = Convert.ToDecimal(row.Cells["Fiyat"].Value);
                    int adet = Convert.ToInt32(row.Cells["Adet"].Value);

                    string satisQuery = @"INSERT INTO Satislar (Barkod, UrunAdi, Marka, SatisFiyati, SatisTarihi, Adet) 
                                        VALUES (@Barkod, @UrunAdi, @Marka, @SatisFiyati, @SatisTarihi, @Adet)";

                    using (MySqlCommand cmd = new MySqlCommand(satisQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Barkod", barkod);
                        cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                        cmd.Parameters.AddWithValue("@Marka", marka);
                        cmd.Parameters.AddWithValue("@SatisFiyati", satisFiyati);
                        cmd.Parameters.AddWithValue("@SatisTarihi", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Adet", adet);
                        cmd.ExecuteNonQuery();
                    }

                    string stokQuery = "UPDATE Urunler SET Stok = Stok - @Adet WHERE Barkod = @Barkod";
                    using (MySqlCommand cmd = new MySqlCommand(stokQuery, connection, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Adet", adet);
                        cmd.Parameters.AddWithValue("@Barkod", barkod);
                        cmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();

                if (yazdir)
                {
                    FisGoster();
                }

                MessageBox.Show($"Satış {odemeTipi} ile tamamlandı!\nToplam Tutar: {toplamTutar.ToString("N2")} TL",
                              "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FisGoster()
        {
            panel1.Controls.Clear();

            // Başlık
            Label lblBaslik = new Label();
            lblBaslik.Text = "MYB MARKET";
            lblBaslik.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
            lblBaslik.AutoSize = true;
            lblBaslik.Location = new Point(50, 20);
            panel1.Controls.Add(lblBaslik);

            // Tarih
            Label lblTarih = new Label();
            lblTarih.Text = $"Tarih: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}";
            lblTarih.Font = new System.Drawing.Font("Arial", 12);
            lblTarih.AutoSize = true;
            lblTarih.Location = new Point(50, 50);
            panel1.Controls.Add(lblTarih);

            // Ayraç
            Label lblAyrac1 = new Label();
            lblAyrac1.Text = "----------------------------------------";
            lblAyrac1.Font = new System.Drawing.Font("Arial", 12);
            lblAyrac1.AutoSize = true;
            lblAyrac1.Location = new Point(50, 80);
            panel1.Controls.Add(lblAyrac1);

            int y = 110;
            // Ürünler
            foreach (DataGridViewRow row in satisview.Rows)
            {
                if (row.Cells["UrunAdi"].Value != null && 
                    row.Cells["Adet"].Value != null && 
                    row.Cells["Fiyat"].Value != null)
                {
                    try
                    {
                        string urunAdi = row.Cells["UrunAdi"].Value.ToString();
                        string adet = row.Cells["Adet"].Value.ToString();
                        string fiyat = Convert.ToDouble(row.Cells["Fiyat"].Value).ToString("N2");
                        string toplam = (Convert.ToDouble(row.Cells["Fiyat"].Value) * Convert.ToInt32(adet)).ToString("N2");

                        Label lblUrun = new Label();
                        lblUrun.Text = urunAdi;
                        lblUrun.Font = new System.Drawing.Font("Arial", 12);
                        lblUrun.AutoSize = true;
                        lblUrun.Location = new Point(50, y);
                        panel1.Controls.Add(lblUrun);
                        y += 25;

                        Label lblDetay = new Label();
                        lblDetay.Text = $"{adet} x {fiyat} TL = {toplam} TL";
                        lblDetay.Font = new System.Drawing.Font("Arial", 12);
                        lblDetay.AutoSize = true;
                        lblDetay.Location = new Point(70, y);
                        panel1.Controls.Add(lblDetay);
                        y += 25;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            
            Label lblAyrac2 = new Label();
            lblAyrac2.Text = "----------------------------------------";
            lblAyrac2.Font = new System.Drawing.Font("Arial", 12);
            lblAyrac2.AutoSize = true;
            lblAyrac2.Location = new Point(50, y);
            panel1.Controls.Add(lblAyrac2);
            y += 30;

            
            Label lblToplam = new Label();
            lblToplam.Text = $"Toplam Tutar: {toplamTutar.ToString("N2")} TL";
            lblToplam.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            lblToplam.AutoSize = true;
            lblToplam.Location = new Point(50, y);
            panel1.Controls.Add(lblToplam);
            y += 30;

            
            Label lblOdeme = new Label();
            lblOdeme.Text = $"Ödeme Tipi: {(radioButton1.Checked ? "Nakit" : "Kart")}";
            lblOdeme.Font = new System.Drawing.Font("Arial", 12);
            lblOdeme.AutoSize = true;
            lblOdeme.Location = new Point(50, y);
            panel1.Controls.Add(lblOdeme);
            y += 30;

            // Teşekkür
            Label lblTesekkur = new Label();
            lblTesekkur.Text = "Bizi tercih ettiğiniz için teşekkür ederiz!";
            lblTesekkur.Font = new System.Drawing.Font("Arial", 12);
            lblTesekkur.AutoSize = true;
            lblTesekkur.Location = new Point(50, y);
            panel1.Controls.Add(lblTesekkur);
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                SatisiTamamla(true);
                radioButton4.Checked = false; 
            }
        }

        private void PDFCikar()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.Title = "PDF Kaydet";
                saveFileDialog.FileName = $"Fis_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document();
                        PdfWriter.GetInstance(document, fs);
                        document.Open();

                    
                        Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                        Paragraph title = new Paragraph("MYB MARKET", titleFont);
                        document.Add(title);

                      
                        Font normalFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                        document.Add(new Paragraph($"Tarih: {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}", normalFont));
                        document.Add(new Paragraph("----------------------------------------", normalFont));

                      
                        foreach (DataGridViewRow row in satisview.Rows)
                        {
                            if (row.Cells["UrunAdi"].Value != null && 
                                row.Cells["Adet"].Value != null && 
                                row.Cells["Fiyat"].Value != null)
                            {
                                try
                                {
                                    string urunAdi = row.Cells["UrunAdi"].Value.ToString();
                                    string adet = row.Cells["Adet"].Value.ToString();
                                    string fiyat = Convert.ToDouble(row.Cells["Fiyat"].Value).ToString("N2");
                                    string toplam = (Convert.ToDouble(row.Cells["Fiyat"].Value) * Convert.ToInt32(adet)).ToString("N2");

                                    document.Add(new Paragraph(urunAdi, normalFont));
                                    document.Add(new Paragraph($"{adet} x {fiyat} TL = {toplam} TL", normalFont));
                                }
                                catch
                                {
                                    continue;
                                }
                            }
                        }

                        document.Add(new Paragraph("----------------------------------------", normalFont));

                    
                        Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                        document.Add(new Paragraph($"Toplam Tutar: {toplamTutar.ToString("N2")} TL", boldFont));
                        document.Add(new Paragraph($"Ödeme Tipi: {(radioButton1.Checked ? "Nakit" : "Kart")}", normalFont));
                        document.Add(new Paragraph("Bizi tercih ettiğiniz için teşekkür ederiz!", normalFont));

                        document.Close();
                    }

                    MessageBox.Show("PDF başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF oluşturulurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pdfcikart_CheckedChanged(object sender, EventArgs e)
        {
            if (pdfcikart.Checked)
            {
                PDFCikar();
                pdfcikart.Checked = false;
            }
        }
    }
}
