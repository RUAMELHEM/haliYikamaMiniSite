namespace nttttttpOdevi
{
    partial class musteri
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            txtAdres = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 129);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 183);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 241);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Numara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 298);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 3;
            label4.Text = "Adres";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(148, 129);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 4;
            txtAd.TextChanged += textBox1_TextChanged;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(148, 291);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(148, 238);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(125, 27);
            txtNumara.TabIndex = 6;
            txtNumara.TextChanged += textBox3_TextChanged;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(148, 180);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 7;
            txtAdres.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 53);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 8;
            label5.Text = "Müşteri Listesi";
            // 
            // lstHalilar
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(510, 92);
            listBox1.Name = "lstHalilar";
            listBox1.Size = new Size(255, 264);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnHaliEkle
            // 
            button1.Location = new Point(44, 379);
            button1.Name = "btnEkle";
            button1.Size = new Size(229, 33);
            button1.TabIndex = 10;
            button1.Text = "Müşteri Ekle ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnAnaSayfa
            // 
            button2.Location = new Point(650, 383);
            button2.Name = "btnAnaSayfa";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 11;
            button2.Text = "Ana Sayfa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // musteri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(txtAdres);
            Controls.Add(txtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "musteri";
            Text = "musteri";
            Load += musteri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private TextBox txtAdres;
        private Label label5;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}
