namespace marketotomasyonu
{
    partial class SatisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisForm));
            tabControl1 = new TabControl();
            temelgida = new TabPage();
            atistirmalik = new TabPage();
            icecekler = new TabPage();
            temizlik = new TabPage();
            esyalar = new TabPage();
            kirtasiye = new TabPage();
            meyvesebze = new TabPage();
            datagridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            satisyapbtn = new Button();
            tutarlbl = new Label();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(temelgida);
            tabControl1.Controls.Add(atistirmalik);
            tabControl1.Controls.Add(icecekler);
            tabControl1.Controls.Add(temizlik);
            tabControl1.Controls.Add(esyalar);
            tabControl1.Controls.Add(kirtasiye);
            tabControl1.Controls.Add(meyvesebze);
            tabControl1.Location = new Point(712, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(460, 386);
            tabControl1.TabIndex = 15;
            // 
            // temelgida
            // 
            temelgida.BackColor = Color.Gainsboro;
            temelgida.Location = new Point(4, 24);
            temelgida.Name = "temelgida";
            temelgida.Padding = new Padding(3);
            temelgida.Size = new Size(452, 358);
            temelgida.TabIndex = 0;
            temelgida.Text = "Temel Gıda";
            // 
            // atistirmalik
            // 
            atistirmalik.BackColor = Color.Gainsboro;
            atistirmalik.Location = new Point(4, 24);
            atistirmalik.Name = "atistirmalik";
            atistirmalik.Padding = new Padding(3);
            atistirmalik.Size = new Size(469, 358);
            atistirmalik.TabIndex = 1;
            atistirmalik.Text = "Atıştırmalık";
            // 
            // icecekler
            // 
            icecekler.BackColor = Color.Gainsboro;
            icecekler.Location = new Point(4, 24);
            icecekler.Name = "icecekler";
            icecekler.Padding = new Padding(3);
            icecekler.Size = new Size(469, 358);
            icecekler.TabIndex = 2;
            icecekler.Text = "İçecek";
            // 
            // temizlik
            // 
            temizlik.BackColor = Color.Gainsboro;
            temizlik.Location = new Point(4, 24);
            temizlik.Name = "temizlik";
            temizlik.Padding = new Padding(3);
            temizlik.Size = new Size(469, 358);
            temizlik.TabIndex = 3;
            temizlik.Text = "Temizlik";
            // 
            // esyalar
            // 
            esyalar.BackColor = Color.Gainsboro;
            esyalar.Location = new Point(4, 24);
            esyalar.Name = "esyalar";
            esyalar.Padding = new Padding(3);
            esyalar.Size = new Size(469, 358);
            esyalar.TabIndex = 4;
            esyalar.Text = "Ev Eşyaları";
            // 
            // kirtasiye
            // 
            kirtasiye.BackColor = Color.Gainsboro;
            kirtasiye.Location = new Point(4, 24);
            kirtasiye.Name = "kirtasiye";
            kirtasiye.Padding = new Padding(3);
            kirtasiye.Size = new Size(469, 358);
            kirtasiye.TabIndex = 5;
            kirtasiye.Text = "Kırtasiye";
            // 
            // meyvesebze
            // 
            meyvesebze.BackColor = Color.Gainsboro;
            meyvesebze.Location = new Point(4, 24);
            meyvesebze.Name = "meyvesebze";
            meyvesebze.Padding = new Padding(3);
            meyvesebze.Size = new Size(469, 358);
            meyvesebze.TabIndex = 6;
            meyvesebze.Text = "Meyve & Sebze";
            // 
            // datagridView1
            // 
            datagridView1.AllowUserToAddRows = false;
            datagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView1.BackgroundColor = SystemColors.Control;
            datagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView1.Location = new Point(163, 59);
            datagridView1.Name = "datagridView1";
            datagridView1.Size = new Size(538, 376);
            datagridView1.TabIndex = 11;
            datagridView1.CellContentClick += datagridView1_CellContentClick;
            datagridView1.CellPainting += datagridView1_CellPainting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(712, 30);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 16;
            label2.Text = "Ürün Listesi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(163, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 17;
            label1.Text = "Satış Ekranı";
            // 
            // satisyapbtn
            // 
            satisyapbtn.BackColor = Color.Tomato;
            satisyapbtn.Cursor = Cursors.Hand;
            satisyapbtn.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            satisyapbtn.Location = new Point(313, 441);
            satisyapbtn.Margin = new Padding(4, 3, 4, 3);
            satisyapbtn.Name = "satisyapbtn";
            satisyapbtn.Size = new Size(237, 44);
            satisyapbtn.TabIndex = 23;
            satisyapbtn.Text = "Satışı Tamamla";
            satisyapbtn.UseVisualStyleBackColor = false;
            satisyapbtn.Click += satisyapbtn_Click;
            // 
            // tutarlbl
            // 
            tutarlbl.AutoSize = true;
            tutarlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tutarlbl.Location = new Point(490, 402);
            tutarlbl.Name = "tutarlbl";
            tutarlbl.Size = new Size(152, 21);
            tutarlbl.TabIndex = 24;
            tutarlbl.Text = "Toplam Tutar : 0 TL";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(2, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // SatisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1201, 518);
            Controls.Add(pictureBox2);
            Controls.Add(tutarlbl);
            Controls.Add(satisyapbtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(tabControl1);
            Controls.Add(datagridView1);
            Name = "SatisForm";
            Text = "SatisForm";
            Load += SatisForm_Load;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TabControl tabControl1;
        public TabPage temelgida;
        private TabPage atistirmalik;
        private TabPage icecekler;
        private Label label2;
        private Label label1;
        private Button satisyapbtn;
        private Label tutarlbl;
        public DataGridView datagridView1;
        private TabPage temizlik;
        private TabPage esyalar;
        private TabPage kirtasiye;
        private TabPage meyvesebze;
        private PictureBox pictureBox2;
    }
}