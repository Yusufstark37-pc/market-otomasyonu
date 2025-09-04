namespace marketotomasyonu
{
    partial class SatisTamamla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatisTamamla));
            tutarlbl = new Label();
            satisview = new DataGridView();
            arkabuton = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            radioButton4 = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            pdfcikart = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)satisview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tutarlbl
            // 
            tutarlbl.AutoSize = true;
            tutarlbl.BackColor = Color.Tomato;
            tutarlbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            tutarlbl.Location = new Point(180, 312);
            tutarlbl.Name = "tutarlbl";
            tutarlbl.Size = new Size(232, 32);
            tutarlbl.TabIndex = 26;
            tutarlbl.Text = "Toplam Tutar : 0 TL";
            // 
            // satisview
            // 
            satisview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            satisview.BackgroundColor = SystemColors.Control;
            satisview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            satisview.Location = new Point(41, 12);
            satisview.Name = "satisview";
            satisview.Size = new Size(576, 277);
            satisview.TabIndex = 25;
            // 
            // arkabuton
            // 
            arkabuton.BackColor = Color.Tomato;
            arkabuton.Cursor = Cursors.Hand;
            arkabuton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            arkabuton.Location = new Point(154, 295);
            arkabuton.Margin = new Padding(4, 3, 4, 3);
            arkabuton.Name = "arkabuton";
            arkabuton.Size = new Size(342, 67);
            arkabuton.TabIndex = 27;
            arkabuton.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButton1.Location = new Point(38, 61);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 25);
            radioButton1.TabIndex = 28;
            radioButton1.TabStop = true;
            radioButton1.Text = "Nakit";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButton2.Location = new Point(194, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 25);
            radioButton2.TabIndex = 29;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kart";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(102, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(497, 430);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 67);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 34;
            pictureBox4.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.DarkGray;
            radioButton4.BackgroundImageLayout = ImageLayout.Center;
            radioButton4.Cursor = Cursors.Hand;
            radioButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            radioButton4.Location = new Point(454, 393);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(163, 31);
            radioButton4.TabIndex = 35;
            radioButton4.TabStop = true;
            radioButton4.Text = "Tamamla ve Yazdır";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Location = new Point(743, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 345);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(743, 12);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 37;
            label1.Text = "Fiş";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(12, 368);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 149);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            // 
            // pdfcikart
            // 
            pdfcikart.Appearance = Appearance.Button;
            pdfcikart.AutoSize = true;
            pdfcikart.BackColor = Color.DarkGray;
            pdfcikart.BackgroundImageLayout = ImageLayout.Center;
            pdfcikart.Cursor = Cursors.Hand;
            pdfcikart.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pdfcikart.Location = new Point(873, 404);
            pdfcikart.Name = "pdfcikart";
            pdfcikart.Size = new Size(89, 31);
            pdfcikart.TabIndex = 39;
            pdfcikart.TabStop = true;
            pdfcikart.Text = "Fiş Çıkart";
            pdfcikart.TextAlign = ContentAlignment.MiddleCenter;
            pdfcikart.UseVisualStyleBackColor = false;
            pdfcikart.CheckedChanged += pdfcikart_CheckedChanged;
            // 
            // SatisTamamla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 522);
            Controls.Add(pdfcikart);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(radioButton4);
            Controls.Add(pictureBox4);
            Controls.Add(tutarlbl);
            Controls.Add(satisview);
            Controls.Add(arkabuton);
            Name = "SatisTamamla";
            Text = "SatisTamamla";
            Load += SatisTamamla_Load;
            ((System.ComponentModel.ISupportInitialize)satisview).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tutarlbl;
        public DataGridView satisview;
        private Button arkabuton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private RadioButton radioButton4;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton pdfcikart;
    }
}