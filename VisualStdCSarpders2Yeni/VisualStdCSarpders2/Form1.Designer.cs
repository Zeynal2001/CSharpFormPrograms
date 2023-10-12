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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonMesajGoruntule = new Button();
            textBoxMesaj = new TextBox();
            buttonMesajSil = new Button();
            labelYazilanIsim = new Label();
            buttonLabelDegistir = new Button();
            buttonLabelSil = new Button();
            buttonDersEkle = new Button();
            groupBox1 = new GroupBox();
            richTextBoxMetin = new RichTextBox();
            buttonrichTextBox = new Button();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            buttonZamanEkle = new Button();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            textBoxLabel = new TextBox();
            trackBarVolume = new TrackBar();
            richTextBoxVolumeDegeri = new RichTextBox();
            buttonDegerBelirt = new Button();
            buttonDegerSil = new Button();
            groupBox4 = new GroupBox();
            textBoxDersler = new TextBox();
            listBoxDerslerim = new ListBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox5 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox6 = new GroupBox();
            panel1 = new Panel();
            comboBoxIsimler = new ComboBox();
            buttonIsmiComboyaEkle = new Button();
            textBoxEklenecekIsim = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonDeneme = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMesajGoruntule
            // 
            buttonMesajGoruntule.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonMesajGoruntule.ForeColor = Color.FromArgb(0, 0, 64);
            buttonMesajGoruntule.Location = new Point(6, 29);
            buttonMesajGoruntule.Name = "buttonMesajGoruntule";
            buttonMesajGoruntule.Size = new Size(132, 29);
            buttonMesajGoruntule.TabIndex = 0;
            buttonMesajGoruntule.Text = "Mesaj Yaz";
            buttonMesajGoruntule.UseVisualStyleBackColor = true;
            buttonMesajGoruntule.Click += ButtonMesajGoruntule_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBoxMesaj.ForeColor = Color.FromArgb(0, 0, 64);
            textBoxMesaj.Location = new Point(211, 32);
            textBoxMesaj.Multiline = true;
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(214, 65);
            textBoxMesaj.TabIndex = 1;
            textBoxMesaj.TextAlign = HorizontalAlignment.Center;
            textBoxMesaj.TextChanged += TextBoxMesaj_TextChanged;
            // 
            // buttonMesajSil
            // 
            buttonMesajSil.BackColor = Color.White;
            buttonMesajSil.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMesajSil.ForeColor = Color.Green;
            buttonMesajSil.Location = new Point(6, 66);
            buttonMesajSil.Name = "buttonMesajSil";
            buttonMesajSil.Size = new Size(132, 29);
            buttonMesajSil.TabIndex = 2;
            buttonMesajSil.Text = " Sil";
            buttonMesajSil.UseVisualStyleBackColor = false;
            buttonMesajSil.Click += ButtonMesajSil_Click;
            // 
            // labelYazilanIsim
            // 
            labelYazilanIsim.BackColor = Color.Fuchsia;
            labelYazilanIsim.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelYazilanIsim.ForeColor = Color.White;
            labelYazilanIsim.ImageAlign = ContentAlignment.BottomCenter;
            labelYazilanIsim.Location = new Point(135, 146);
            labelYazilanIsim.MaximumSize = new Size(0, 199);
            labelYazilanIsim.Name = "labelYazilanIsim";
            labelYazilanIsim.Size = new Size(128, 66);
            labelYazilanIsim.TabIndex = 5;
            labelYazilanIsim.Text = "label:)";
            labelYazilanIsim.TextAlign = ContentAlignment.MiddleCenter;
            labelYazilanIsim.Click += Label1_Click;
            // 
            // buttonLabelDegistir
            // 
            buttonLabelDegistir.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLabelDegistir.ForeColor = Color.Fuchsia;
            buttonLabelDegistir.Location = new Point(269, 165);
            buttonLabelDegistir.Name = "buttonLabelDegistir";
            buttonLabelDegistir.Size = new Size(120, 49);
            buttonLabelDegistir.TabIndex = 6;
            buttonLabelDegistir.Text = "Label Degistir";
            buttonLabelDegistir.UseVisualStyleBackColor = true;
            buttonLabelDegistir.Click += ButtonLabelDegistir_Click;
            // 
            // buttonLabelSil
            // 
            buttonLabelSil.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonLabelSil.ForeColor = Color.Fuchsia;
            buttonLabelSil.Location = new Point(9, 164);
            buttonLabelSil.Name = "buttonLabelSil";
            buttonLabelSil.Size = new Size(120, 49);
            buttonLabelSil.TabIndex = 7;
            buttonLabelSil.Text = "Label Sil";
            buttonLabelSil.UseVisualStyleBackColor = true;
            buttonLabelSil.Click += ButtonLabelSil_Click;
            // 
            // buttonDersEkle
            // 
            buttonDersEkle.BackColor = Color.LightGreen;
            buttonDersEkle.Font = new Font("Lucida Fax", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDersEkle.ForeColor = Color.Navy;
            buttonDersEkle.Location = new Point(963, 78);
            buttonDersEkle.Name = "buttonDersEkle";
            buttonDersEkle.Size = new Size(110, 29);
            buttonDersEkle.TabIndex = 9;
            buttonDersEkle.Text = "Dersi Ekle";
            buttonDersEkle.UseVisualStyleBackColor = false;
            buttonDersEkle.Click += ButtonDersEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonMesajSil);
            groupBox1.Controls.Add(buttonMesajGoruntule);
            groupBox1.Controls.Add(textBoxMesaj);
            groupBox1.Location = new Point(2, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 111);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Metin Kutusu Islemleri";
            // 
            // richTextBoxMetin
            // 
            richTextBoxMetin.Location = new Point(0, 19);
            richTextBoxMetin.Name = "richTextBoxMetin";
            richTextBoxMetin.Size = new Size(138, 106);
            richTextBoxMetin.TabIndex = 11;
            richTextBoxMetin.Text = "Hello C#\nSalam C#";
            // 
            // buttonrichTextBox
            // 
            buttonrichTextBox.Location = new Point(144, 18);
            buttonrichTextBox.Name = "buttonrichTextBox";
            buttonrichTextBox.Size = new Size(94, 29);
            buttonrichTextBox.TabIndex = 12;
            buttonrichTextBox.Text = "Metin Ekle";
            buttonrichTextBox.UseVisualStyleBackColor = true;
            buttonrichTextBox.Click += ButtonrichTextBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += PictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonZamanEkle);
            groupBox2.Controls.Add(richTextBoxMetin);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(buttonrichTextBox);
            groupBox2.Location = new Point(2, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 198);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Metın Kutusu ve Zaman Islemlerı";
            // 
            // buttonZamanEkle
            // 
            buttonZamanEkle.Location = new Point(144, 96);
            buttonZamanEkle.Name = "buttonZamanEkle";
            buttonZamanEkle.Size = new Size(94, 29);
            buttonZamanEkle.TabIndex = 16;
            buttonZamanEkle.Text = "Tarih Ekle";
            buttonZamanEkle.UseVisualStyleBackColor = true;
            buttonZamanEkle.Click += ButtonZamanEkle_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 165);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxLabel);
            groupBox3.Controls.Add(buttonLabelDegistir);
            groupBox3.Controls.Add(labelYazilanIsim);
            groupBox3.Controls.Add(buttonLabelSil);
            groupBox3.Location = new Point(493, 14);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(380, 222);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Label Islemlerı";
            // 
            // textBoxLabel
            // 
            textBoxLabel.Location = new Point(96, 46);
            textBoxLabel.Name = "textBoxLabel";
            textBoxLabel.Size = new Size(201, 27);
            textBoxLabel.TabIndex = 8;
            // 
            // trackBarVolume
            // 
            trackBarVolume.Location = new Point(0, 17);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(251, 56);
            trackBarVolume.TabIndex = 17;
            // 
            // richTextBoxVolumeDegeri
            // 
            richTextBoxVolumeDegeri.Location = new Point(-1, 74);
            richTextBoxVolumeDegeri.Name = "richTextBoxVolumeDegeri";
            richTextBoxVolumeDegeri.Size = new Size(132, 74);
            richTextBoxVolumeDegeri.TabIndex = 18;
            richTextBoxVolumeDegeri.Text = "";
            // 
            // buttonDegerBelirt
            // 
            buttonDegerBelirt.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDegerBelirt.Location = new Point(137, 79);
            buttonDegerBelirt.Name = "buttonDegerBelirt";
            buttonDegerBelirt.Size = new Size(128, 29);
            buttonDegerBelirt.TabIndex = 19;
            buttonDegerBelirt.Text = "Degeri belirt";
            buttonDegerBelirt.UseVisualStyleBackColor = true;
            buttonDegerBelirt.Click += ButtonDegerBelirt_Click;
            // 
            // buttonDegerSil
            // 
            buttonDegerSil.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDegerSil.Location = new Point(137, 119);
            buttonDegerSil.Name = "buttonDegerSil";
            buttonDegerSil.Size = new Size(128, 29);
            buttonDegerSil.TabIndex = 20;
            buttonDegerSil.Text = "Degeri Sil";
            buttonDegerSil.UseVisualStyleBackColor = true;
            buttonDegerSil.Click += ButtonDegerSil_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(trackBarVolume);
            groupBox4.Controls.Add(buttonDegerSil);
            groupBox4.Controls.Add(richTextBoxVolumeDegeri);
            groupBox4.Controls.Add(buttonDegerBelirt);
            groupBox4.Location = new Point(2, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(265, 148);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ses Degeri Islemleri";
            // 
            // textBoxDersler
            // 
            textBoxDersler.Location = new Point(939, 25);
            textBoxDersler.Name = "textBoxDersler";
            textBoxDersler.Size = new Size(161, 27);
            textBoxDersler.TabIndex = 22;
            // 
            // listBoxDerslerim
            // 
            listBoxDerslerim.BackColor = Color.LightGreen;
            listBoxDerslerim.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            listBoxDerslerim.ForeColor = Color.Navy;
            listBoxDerslerim.FormattingEnabled = true;
            listBoxDerslerim.ItemHeight = 17;
            listBoxDerslerim.Items.AddRange(new object[] { "Informatika", "Riyaziyyat", "Fizika", "Kimya", "Cografiya" });
            listBoxDerslerim.Location = new Point(939, 130);
            listBoxDerslerim.Name = "listBoxDerslerim";
            listBoxDerslerim.Size = new Size(161, 106);
            listBoxDerslerim.TabIndex = 23;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(27, 44);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 24);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Zeytin";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 75);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(64, 24);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "Sosis";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(27, 105);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(72, 24);
            checkBox3.TabIndex = 26;
            checkBox3.Text = "Salata";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkBox1);
            groupBox5.Controls.Add(checkBox3);
            groupBox5.Controls.Add(checkBox2);
            groupBox5.Location = new Point(63, 146);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(121, 141);
            groupBox5.TabIndex = 27;
            groupBox5.TabStop = false;
            groupBox5.Text = " Pizza Malzemesi";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(27, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 24);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Small";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(27, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(85, 24);
            radioButton2.TabIndex = 28;
            radioButton2.Text = "Medium";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(27, 91);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 24);
            radioButton3.TabIndex = 29;
            radioButton3.Text = "Big";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton1);
            groupBox6.Controls.Add(radioButton3);
            groupBox6.Controls.Add(radioButton2);
            groupBox6.Location = new Point(63, 293);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(121, 125);
            groupBox6.TabIndex = 30;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kahve Boyutu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(groupBox5);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1127, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 717);
            panel1.TabIndex = 31;
            // 
            // comboBoxIsimler
            // 
            comboBoxIsimler.FormattingEnabled = true;
            comboBoxIsimler.Items.AddRange(new object[] { "Aygun", "Vadim", "Zeynal", "Sulhiyya", "Merdan" });
            comboBoxIsimler.Location = new Point(605, 410);
            comboBoxIsimler.Name = "comboBoxIsimler";
            comboBoxIsimler.Size = new Size(151, 28);
            comboBoxIsimler.TabIndex = 32;
            // 
            // buttonIsmiComboyaEkle
            // 
            buttonIsmiComboyaEkle.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonIsmiComboyaEkle.ForeColor = Color.Crimson;
            buttonIsmiComboyaEkle.Location = new Point(632, 358);
            buttonIsmiComboyaEkle.Name = "buttonIsmiComboyaEkle";
            buttonIsmiComboyaEkle.Size = new Size(94, 29);
            buttonIsmiComboyaEkle.TabIndex = 33;
            buttonIsmiComboyaEkle.Text = "Ismi Ekle";
            buttonIsmiComboyaEkle.UseVisualStyleBackColor = true;
            buttonIsmiComboyaEkle.Click += buttonIsmiComboyaEkle_Click;
            // 
            // textBoxEklenecekIsim
            // 
            textBoxEklenecekIsim.Location = new Point(605, 296);
            textBoxEklenecekIsim.Name = "textBoxEklenecekIsim";
            textBoxEklenecekIsim.Size = new Size(151, 27);
            textBoxEklenecekIsim.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(923, 317);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(923, 395);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 36;
            // 
            // buttonDeneme
            // 
            buttonDeneme.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            buttonDeneme.ForeColor = Color.Crimson;
            buttonDeneme.Location = new Point(939, 355);
            buttonDeneme.Name = "buttonDeneme";
            buttonDeneme.Size = new Size(94, 29);
            buttonDeneme.TabIndex = 37;
            buttonDeneme.Text = "Tasimak";
            buttonDeneme.UseVisualStyleBackColor = true;
            buttonDeneme.Click += buttonDeneme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1316, 659);
            Controls.Add(buttonDeneme);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxEklenecekIsim);
            Controls.Add(buttonIsmiComboyaEkle);
            Controls.Add(comboBoxIsimler);
            Controls.Add(panel1);
            Controls.Add(listBoxDerslerim);
            Controls.Add(textBoxDersler);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonDersEkle);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMesajGoruntule;
        private TextBox textBoxMesaj;
        private Button buttonMesajSil;
        private Label labelYazilanIsim;
        private Button buttonLabelDegistir;
        private Button buttonLabelSil;
        private Button buttonDersEkle;
        private GroupBox groupBox1;
        private RichTextBox richTextBoxMetin;
        private Button buttonrichTextBox;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private Button buttonZamanEkle;
        private TrackBar trackBarVolume;
        private RichTextBox richTextBoxVolumeDegeri;
        private Button buttonDegerBelirt;
        private Button buttonDegerSil;
        private GroupBox groupBox4;
        private TextBox textBoxDersler;
        private ListBox listBoxDerslerim;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox6;
        private Panel panel1;
        private ComboBox comboBoxIsimler;
        private Button buttonIsmiComboyaEkle;
        private TextBox textBoxEklenecekIsim;
        private TextBox textBoxLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonDeneme;
    }
}