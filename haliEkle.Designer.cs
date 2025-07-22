namespace nttttttpOdevi
{
    partial class HaliEkle
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
            cmbMusterilers = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtAlimTarihi = new TextBox();
            label3 = new Label();
            txtTeslimTarihi = new TextBox();
            btnHaliEkle = new Button();
            btnAnaSayfa = new Button();
            label6 = new Label();
            txtMetre = new TextBox();
            lstHalilar = new ListBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbMusterilers
            // 
            cmbMusterilers.FormattingEnabled = true;
            cmbMusterilers.Location = new Point(43, 59);
            cmbMusterilers.Name = "cmbMusterilers";
            cmbMusterilers.Size = new Size(248, 28);
            cmbMusterilers.TabIndex = 0;
            cmbMusterilers.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 1;
            label1.Text = "Müşteri Seç";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 107);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Alındığı Tarih";
            // 
            // txtAlimTarihi
            // 
            txtAlimTarihi.Location = new Point(43, 144);
            txtAlimTarihi.Name = "txtAlimTarihi";
            txtAlimTarihi.Size = new Size(248, 27);
            txtAlimTarihi.TabIndex = 3;
            txtAlimTarihi.TextChanged += txtAlimTarihi_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 187);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Teslim Tarihi";
            // 
            // txtTeslimTarihi
            // 
            txtTeslimTarihi.Location = new Point(41, 215);
            txtTeslimTarihi.Name = "txtTeslimTarihi";
            txtTeslimTarihi.Size = new Size(248, 27);
            txtTeslimTarihi.TabIndex = 7;
            // 
            // btnHaliEkle
            // 
            btnHaliEkle.Location = new Point(532, 236);
            btnHaliEkle.Name = "btnHaliEkle";
            btnHaliEkle.Size = new Size(153, 32);
            btnHaliEkle.TabIndex = 9;
            btnHaliEkle.Text = "Halı Ekle ";
            btnHaliEkle.UseVisualStyleBackColor = true;
            btnHaliEkle.Click += button1_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.Location = new Point(532, 292);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(153, 32);
            btnAnaSayfa.TabIndex = 10;
            btnAnaSayfa.Text = "Ana Sayfa ";
            btnAnaSayfa.UseVisualStyleBackColor = true;
            btnAnaSayfa.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 260);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 12;
            label6.Text = "Metre";
            // 
            // txtMetre
            // 
            txtMetre.Location = new Point(41, 295);
            txtMetre.Name = "txtMetre";
            txtMetre.Size = new Size(248, 27);
            txtMetre.TabIndex = 14;
            // 
            // lstHalilar
            // 
            lstHalilar.FormattingEnabled = true;
            lstHalilar.Location = new Point(501, 83);
            lstHalilar.Name = "lstHalilar";
            lstHalilar.Size = new Size(225, 124);
            lstHalilar.TabIndex = 15;
            lstHalilar.SelectedIndexChanged += lstHalilar_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(565, 47);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 16;
            label4.Text = "Halı Listesi";
            // 
            // button1
            // 
            button1.Location = new Point(446, 349);
            button1.Name = "button1";
            button1.Size = new Size(331, 33);
            button1.TabIndex = 19;
            button1.Text = "Yenile(buna basmadan müşteriler yüklenmiyor )";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // HaliEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(lstHalilar);
            Controls.Add(txtMetre);
            Controls.Add(label6);
            Controls.Add(btnAnaSayfa);
            Controls.Add(btnHaliEkle);
            Controls.Add(txtTeslimTarihi);
            Controls.Add(label3);
            Controls.Add(txtAlimTarihi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbMusterilers);
            Name = "HaliEkle";
            Text = "HaliEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusterilers;
        private Label label1;
        private Label label2;
        private TextBox txtAlimTarihi;
        private Label label3;
        private TextBox txtTeslimTarihi;
        private Button btnHaliEkle;
        private Button btnAnaSayfa;
        private Label label6;
        private TextBox txtMetre;
        private ListBox lstHalilar;
        private Label label4;
        private Button button1;
    }
}
