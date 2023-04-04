namespace VisualStdCSarpders2
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
            buttonMesajGoruntule = new Button();
            textBoxMesaj = new TextBox();
            buttonMesajSil = new Button();
            comboBoxIsimler = new ComboBox();
            buttonIsmiComboyaEkle = new Button();
            labelYazilanIsim = new Label();
            buttonLabelDegistir = new Button();
            buttonLabelSil = new Button();
            listBoxDersler = new ListBox();
            buttonDersEkle = new Button();
            SuspendLayout();
            // 
            // buttonMesajGoruntule
            // 
            buttonMesajGoruntule.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMesajGoruntule.ForeColor = Color.FromArgb(0, 0, 64);
            buttonMesajGoruntule.Location = new Point(12, 35);
            buttonMesajGoruntule.Name = "buttonMesajGoruntule";
            buttonMesajGoruntule.Size = new Size(132, 29);
            buttonMesajGoruntule.TabIndex = 0;
            buttonMesajGoruntule.Text = "Mesaj Yaz";
            buttonMesajGoruntule.UseVisualStyleBackColor = true;
            buttonMesajGoruntule.Click += buttonMesajGoruntule_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxMesaj.ForeColor = Color.FromArgb(0, 0, 64);
            textBoxMesaj.Location = new Point(150, 59);
            textBoxMesaj.Multiline = true;
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(214, 65);
            textBoxMesaj.TabIndex = 1;
            textBoxMesaj.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonMesajSil
            // 
            buttonMesajSil.BackColor = Color.White;
            buttonMesajSil.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMesajSil.ForeColor = Color.Green;
            buttonMesajSil.Location = new Point(12, 110);
            buttonMesajSil.Name = "buttonMesajSil";
            buttonMesajSil.Size = new Size(132, 29);
            buttonMesajSil.TabIndex = 2;
            buttonMesajSil.Text = " Sil";
            buttonMesajSil.UseVisualStyleBackColor = false;
            buttonMesajSil.Click += buttonMesajSil_Click;
            // 
            // comboBoxIsimler
            // 
            comboBoxIsimler.FormattingEnabled = true;
            comboBoxIsimler.Items.AddRange(new object[] { "Sulhiyya", "Merdan", "Zeynal", "Aygun", "Vadim" });
            comboBoxIsimler.Location = new Point(471, 96);
            comboBoxIsimler.Name = "comboBoxIsimler";
            comboBoxIsimler.Size = new Size(161, 28);
            comboBoxIsimler.TabIndex = 3;
            // 
            // buttonIsmiComboyaEkle
            // 
            buttonIsmiComboyaEkle.BackColor = Color.White;
            buttonIsmiComboyaEkle.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIsmiComboyaEkle.ForeColor = Color.Crimson;
            buttonIsmiComboyaEkle.Location = new Point(503, 12);
            buttonIsmiComboyaEkle.Name = "buttonIsmiComboyaEkle";
            buttonIsmiComboyaEkle.Size = new Size(94, 29);
            buttonIsmiComboyaEkle.TabIndex = 4;
            buttonIsmiComboyaEkle.Text = "Isim Ekle";
            buttonIsmiComboyaEkle.UseVisualStyleBackColor = false;
            buttonIsmiComboyaEkle.Click += buttonIsmiComboyaEkle_Click;
            // 
            // labelYazilanIsim
            // 
            labelYazilanIsim.BackColor = Color.Fuchsia;
            labelYazilanIsim.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelYazilanIsim.ForeColor = Color.White;
            labelYazilanIsim.ImageAlign = ContentAlignment.BottomCenter;
            labelYazilanIsim.Location = new Point(138, 279);
            labelYazilanIsim.MaximumSize = new Size(0, 199);
            labelYazilanIsim.Name = "labelYazilanIsim";
            labelYazilanIsim.Size = new Size(128, 66);
            labelYazilanIsim.TabIndex = 5;
            labelYazilanIsim.Text = "label:)";
            labelYazilanIsim.TextAlign = ContentAlignment.MiddleCenter;
            labelYazilanIsim.Click += label1_Click;
            // 
            // buttonLabelDegistir
            // 
            buttonLabelDegistir.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLabelDegistir.ForeColor = Color.Fuchsia;
            buttonLabelDegistir.Location = new Point(272, 288);
            buttonLabelDegistir.Name = "buttonLabelDegistir";
            buttonLabelDegistir.Size = new Size(120, 49);
            buttonLabelDegistir.TabIndex = 6;
            buttonLabelDegistir.Text = "Label Degistir";
            buttonLabelDegistir.UseVisualStyleBackColor = true;
            buttonLabelDegistir.Click += buttonLabelDegistir_Click;
            // 
            // buttonLabelSil
            // 
            buttonLabelSil.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLabelSil.ForeColor = Color.Fuchsia;
            buttonLabelSil.Location = new Point(12, 288);
            buttonLabelSil.Name = "buttonLabelSil";
            buttonLabelSil.Size = new Size(120, 49);
            buttonLabelSil.TabIndex = 7;
            buttonLabelSil.Text = "Label Sil";
            buttonLabelSil.UseVisualStyleBackColor = true;
            buttonLabelSil.Click += buttonLabelSil_Click;
            // 
            // listBoxDersler
            // 
            listBoxDersler.BackColor = Color.LightGreen;
            listBoxDersler.Font = new Font("Lucida Fax", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            listBoxDersler.ForeColor = Color.Navy;
            listBoxDersler.FormattingEnabled = true;
            listBoxDersler.ItemHeight = 19;
            listBoxDersler.Items.AddRange(new object[] { "Informatika", "Riyaziyyat ", "Fizika", "Kimya", "Cografiya" });
            listBoxDersler.Location = new Point(577, 366);
            listBoxDersler.Name = "listBoxDersler";
            listBoxDersler.Size = new Size(217, 137);
            listBoxDersler.TabIndex = 8;
            // 
            // buttonDersEkle
            // 
            buttonDersEkle.BackColor = Color.LightGreen;
            buttonDersEkle.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDersEkle.ForeColor = Color.Navy;
            buttonDersEkle.Location = new Point(627, 279);
            buttonDersEkle.Name = "buttonDersEkle";
            buttonDersEkle.Size = new Size(110, 29);
            buttonDersEkle.TabIndex = 9;
            buttonDersEkle.Text = "Dersi Ekle";
            buttonDersEkle.UseVisualStyleBackColor = false;
            buttonDersEkle.Click += buttonDersEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(839, 597);
            Controls.Add(buttonDersEkle);
            Controls.Add(listBoxDersler);
            Controls.Add(buttonLabelSil);
            Controls.Add(buttonLabelDegistir);
            Controls.Add(labelYazilanIsim);
            Controls.Add(buttonIsmiComboyaEkle);
            Controls.Add(comboBoxIsimler);
            Controls.Add(buttonMesajSil);
            Controls.Add(textBoxMesaj);
            Controls.Add(buttonMesajGoruntule);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMesajGoruntule;
        private TextBox textBoxMesaj;
        private Button buttonMesajSil;
        private ComboBox comboBoxIsimler;
        private Button buttonIsmiComboyaEkle;
        private Label labelYazilanIsim;
        private Button buttonLabelDegistir;
        private Button buttonLabelSil;
        private ListBox listBoxDersler;
        private Button buttonDersEkle;
    }
}