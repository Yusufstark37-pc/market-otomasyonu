namespace marketotomasyonu
{
    partial class UrunlerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txturunid = new TextBox();
            txturunad = new TextBox();
            txtbarkod = new TextBox();
            cmbkategori = new ComboBox();
            cmbmarka = new ComboBox();
            txtalisfiyat = new NumericUpDown();
            txtbirim = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            uruneklebtn = new Button();
            txtstok = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            txtsatisfiyat = new NumericUpDown();
            button3 = new Button();
            txtmarka = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtalisfiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtstok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtsatisfiyat).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(338, 74);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(713, 384);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txturunid
            // 
            txturunid.BackColor = SystemColors.ActiveBorder;
            txturunid.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txturunid.Location = new Point(21, 101);
            txturunid.Margin = new Padding(4, 3, 4, 3);
            txturunid.Name = "txturunid";
            txturunid.ReadOnly = true;
            txturunid.Size = new Size(131, 23);
            txturunid.TabIndex = 4;
            // 
            // txturunad
            // 
            txturunad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txturunad.Location = new Point(21, 157);
            txturunad.Margin = new Padding(4, 3, 4, 3);
            txturunad.Name = "txturunad";
            txturunad.Size = new Size(131, 23);
            txturunad.TabIndex = 5;
            // 
            // txtbarkod
            // 
            txtbarkod.BackColor = SystemColors.ActiveBorder;
            txtbarkod.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtbarkod.Location = new Point(168, 101);
            txtbarkod.Margin = new Padding(4, 3, 4, 3);
            txtbarkod.Name = "txtbarkod";
            txtbarkod.ReadOnly = true;
            txtbarkod.Size = new Size(131, 23);
            txtbarkod.TabIndex = 6;
            txtbarkod.TextChanged += textBox3_TextChanged;
            // 
            // cmbkategori
            // 
            cmbkategori.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbkategori.FormattingEnabled = true;
            cmbkategori.Items.AddRange(new object[] { "Temel Gıda", "İçecek", "Atıştırmalık", "Meyve & Sebze", "Temizlik", "Kozmetik", "Ev Eşyaları", "Kırtasiye" });
            cmbkategori.Location = new Point(21, 211);
            cmbkategori.Margin = new Padding(4, 3, 4, 3);
            cmbkategori.Name = "cmbkategori";
            cmbkategori.Size = new Size(131, 23);
            cmbkategori.TabIndex = 7;
            cmbkategori.SelectedIndexChanged += cmbkategori_SelectedIndexChanged;
            // 
            // cmbmarka
            // 
            cmbmarka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbmarka.FormattingEnabled = true;
            cmbmarka.Location = new Point(21, 265);
            cmbmarka.Margin = new Padding(4, 3, 4, 3);
            cmbmarka.Name = "cmbmarka";
            cmbmarka.Size = new Size(131, 23);
            cmbmarka.TabIndex = 8;
            cmbmarka.SelectedIndexChanged += txtmarka_SelectedIndexChanged;
            // 
            // txtalisfiyat
            // 
            txtalisfiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtalisfiyat.Location = new Point(168, 157);
            txtalisfiyat.Name = "txtalisfiyat";
            txtalisfiyat.Size = new Size(131, 23);
            txtalisfiyat.TabIndex = 9;
            // 
            // txtbirim
            // 
            txtbirim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtbirim.FormattingEnabled = true;
            txtbirim.Items.AddRange(new object[] { "Adet", "Kg", "L" });
            txtbirim.Location = new Point(168, 260);
            txtbirim.Margin = new Padding(4, 3, 4, 3);
            txtbirim.Name = "txtbirim";
            txtbirim.Size = new Size(131, 23);
            txtbirim.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 13;
            label1.Text = "Ürün ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(168, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 14;
            label2.Text = "Barkod No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 15;
            label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(22, 193);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 16;
            label4.Text = "Kategori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(21, 247);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 17;
            label5.Text = "Marka";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(168, 139);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 18;
            label6.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(168, 242);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 20;
            label8.Text = "Ürün Birimi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(168, 296);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 21;
            label9.Text = "Stok";
            // 
            // uruneklebtn
            // 
            uruneklebtn.BackColor = Color.Tomato;
            uruneklebtn.Cursor = Cursors.Hand;
            uruneklebtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            uruneklebtn.Location = new Point(8, 373);
            uruneklebtn.Margin = new Padding(4, 3, 4, 3);
            uruneklebtn.Name = "uruneklebtn";
            uruneklebtn.Size = new Size(97, 44);
            uruneklebtn.TabIndex = 22;
            uruneklebtn.Text = "Ekle";
            uruneklebtn.UseVisualStyleBackColor = false;
            uruneklebtn.Click += button1_Click;
            // 
            // txtstok
            // 
            txtstok.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtstok.Location = new Point(168, 314);
            txtstok.Name = "txtstok";
            txtstok.Size = new Size(131, 23);
            txtstok.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(218, 373);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(97, 44);
            button1.TabIndex = 23;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Tomato;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(113, 373);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(97, 44);
            button2.TabIndex = 24;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(168, 189);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 26;
            label7.Text = "Satış Fiyatı";
            // 
            // txtsatisfiyat
            // 
            txtsatisfiyat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtsatisfiyat.Location = new Point(168, 207);
            txtsatisfiyat.Name = "txtsatisfiyat";
            txtsatisfiyat.Size = new Size(131, 23);
            txtsatisfiyat.TabIndex = 25;
            // 
            // button3
            // 
            button3.BackColor = Color.Tomato;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(94, 294);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(46, 25);
            button3.TabIndex = 27;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // txtmarka
            // 
            txtmarka.BackColor = Color.MistyRose;
            txtmarka.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtmarka.Location = new Point(21, 293);
            txtmarka.Margin = new Padding(4, 3, 4, 3);
            txtmarka.Name = "txtmarka";
            txtmarka.Size = new Size(67, 23);
            txtmarka.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 35);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(185, 32);
            label10.TabIndex = 29;
            label10.Text = "Ürünleri Yönet";
            // 
            // UrunlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1063, 499);
            Controls.Add(label10);
            Controls.Add(txtmarka);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(txtsatisfiyat);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(uruneklebtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtstok);
            Controls.Add(txtbirim);
            Controls.Add(txtalisfiyat);
            Controls.Add(cmbmarka);
            Controls.Add(cmbkategori);
            Controls.Add(txtbarkod);
            Controls.Add(txturunad);
            Controls.Add(txturunid);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UrunlerForm";
            Text = "Ürün Yöneticisi";
            Load += Ürün_Yöneticisi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtalisfiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtstok).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtsatisfiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        public TextBox txturunid;
        public TextBox txturunad;
        public TextBox txtbarkod;
        public ComboBox cmbkategori;
        public ComboBox cmbmarka;
        public NumericUpDown txtalisfiyat;
        public ComboBox txtbirim;
        private Button uruneklebtn;
        public NumericUpDown txtstok;
        private Button button1;
        private Button button2;
        private Label label7;
        public NumericUpDown txtsatisfiyat;
        private Button button3;
        public TextBox txtmarka;
        private Label label10;
    }
}