namespace marketotomasyonu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtad = new TextBox();
            txtsifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            girisbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtad
            // 
            txtad.Location = new Point(542, 182);
            txtad.Name = "txtad";
            txtad.Size = new Size(181, 23);
            txtad.TabIndex = 0;
            // 
            // txtsifre
            // 
            txtsifre.Location = new Point(542, 267);
            txtsifre.Name = "txtsifre";
            txtsifre.Size = new Size(181, 23);
            txtsifre.TabIndex = 1;
            txtsifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(542, 162);
            label1.Name = "label1";
            label1.Size = new Size(86, 17);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(542, 237);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // girisbtn
            // 
            girisbtn.BackColor = Color.Tomato;
            girisbtn.Cursor = Cursors.Hand;
            girisbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            girisbtn.Location = new Point(570, 318);
            girisbtn.Name = "girisbtn";
            girisbtn.Size = new Size(113, 60);
            girisbtn.TabIndex = 4;
            girisbtn.Text = "Giriş Yap";
            girisbtn.UseVisualStyleBackColor = false;
            girisbtn.Click += girisbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(515, 459);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(533, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(774, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(girisbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtsifre);
            Controls.Add(txtad);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Giriş";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtad;
        public TextBox txtsifre;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        public Button girisbtn;
        private PictureBox pictureBox2;
    }
}
