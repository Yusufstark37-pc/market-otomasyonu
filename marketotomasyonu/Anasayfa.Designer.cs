namespace marketotomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            satışYapToolStripMenuItem = new ToolStripMenuItem();
            satislarToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            panelSayfa = new Panel();
            markabtn = new Button();
            kategoribtn = new Button();
            urunsayisibtn = new Button();
            pictureBox2 = new PictureBox();
            menuStrip1.SuspendLayout();
            panelSayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Tomato;
            menuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(20, 16);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, ürünEkleToolStripMenuItem, satışYapToolStripMenuItem, satislarToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1170, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = (Image)resources.GetObject("toolStripMenuItem2.Image");
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(107, 25);
            toolStripMenuItem2.Text = "Anasayfa";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Image = (Image)resources.GetObject("ürünEkleToolStripMenuItem.Image");
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(146, 25);
            ürünEkleToolStripMenuItem.Text = "Ürünleri Yönet";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // satışYapToolStripMenuItem
            // 
            satışYapToolStripMenuItem.Image = (Image)resources.GetObject("satışYapToolStripMenuItem.Image");
            satışYapToolStripMenuItem.Name = "satışYapToolStripMenuItem";
            satışYapToolStripMenuItem.Size = new Size(106, 25);
            satışYapToolStripMenuItem.Text = "Satış Yap";
            satışYapToolStripMenuItem.Click += satışYapToolStripMenuItem_Click;
            // 
            // satislarToolStripMenuItem
            // 
            satislarToolStripMenuItem.Image = (Image)resources.GetObject("satislarToolStripMenuItem.Image");
            satislarToolStripMenuItem.Name = "satislarToolStripMenuItem";
            satislarToolStripMenuItem.Size = new Size(94, 25);
            satislarToolStripMenuItem.Text = "Satışlar";
            satislarToolStripMenuItem.Click += satislarToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 25);
            // 
            // panelSayfa
            // 
            panelSayfa.BackColor = Color.WhiteSmoke;
            panelSayfa.Controls.Add(markabtn);
            panelSayfa.Controls.Add(kategoribtn);
            panelSayfa.Controls.Add(urunsayisibtn);
            panelSayfa.Controls.Add(pictureBox2);
            panelSayfa.Location = new Point(0, 31);
            panelSayfa.Name = "panelSayfa";
            panelSayfa.Size = new Size(1170, 503);
            panelSayfa.TabIndex = 8;
            panelSayfa.Paint += panelSayfa_Paint;
            // 
            // markabtn
            // 
            markabtn.BackColor = Color.LimeGreen;
            markabtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            markabtn.Location = new Point(789, 280);
            markabtn.Name = "markabtn";
            markabtn.Size = new Size(299, 79);
            markabtn.TabIndex = 10;
            markabtn.Text = "Toplam Marka Sayısı";
            markabtn.UseVisualStyleBackColor = false;
            // 
            // kategoribtn
            // 
            kategoribtn.BackColor = Color.Gold;
            kategoribtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kategoribtn.Location = new Point(418, 280);
            kategoribtn.Name = "kategoribtn";
            kategoribtn.Size = new Size(299, 79);
            kategoribtn.TabIndex = 9;
            kategoribtn.Text = "Toplam Kategori Sayısı";
            kategoribtn.UseVisualStyleBackColor = false;
            // 
            // urunsayisibtn
            // 
            urunsayisibtn.BackColor = Color.MediumTurquoise;
            urunsayisibtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunsayisibtn.Location = new Point(48, 280);
            urunsayisibtn.Name = "urunsayisibtn";
            urunsayisibtn.Size = new Size(299, 79);
            urunsayisibtn.TabIndex = 8;
            urunsayisibtn.Text = "Toplam Ürün Sayısı";
            urunsayisibtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(418, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(299, 198);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 530);
            Controls.Add(panelSayfa);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anasayfa";
            Load += Anasayfa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelSayfa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private Panel panelSayfa;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private PictureBox pictureBox2;
        private ToolStripMenuItem satışYapToolStripMenuItem;
        private ToolStripMenuItem satislarToolStripMenuItem;
        private Button urunsayisibtn;
        private Button kategoribtn;
        private Button markabtn;
    }
}