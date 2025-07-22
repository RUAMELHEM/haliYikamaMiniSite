namespace nttttttpOdevi
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnHaliEkle
            // 
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(314, 86);
            button1.Name = "btnHaliEkle";
            button1.Size = new Size(130, 44);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Ekle ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(314, 177);
            button3.Name = "button3";
            button3.Size = new Size(130, 44);
            button3.TabIndex = 2;
            button3.Text = "Halı Ekle ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Crimson;
            button4.Location = new Point(314, 269);
            button4.Name = "button4";
            button4.Size = new Size(130, 43);
            button4.TabIndex = 3;
            button4.Text = "Halı Listele";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Halı Yıkama Fabrikası ";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
    }
}
