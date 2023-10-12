namespace VisualStdCSarpders2

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonMesajGoruntule_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Hey Necesen? Yaxsisan?";
        }

        private void ButtonMesajSil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLabelDegistir_Click(object sender, EventArgs e)
        {
            labelYazilanIsim.Text = textBoxLabel.Text;
        }

        private void ButtonLabelSil_Click(object sender, EventArgs e) => labelYazilanIsim.Text = "";

        private void ButtonDersEkle_Click(object sender, EventArgs e)
        {
            listBoxDerslerim.Items.Add(textBoxDersler.Text);
        }

        private void TextBoxMesaj_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonrichTextBox_Click(object sender, EventArgs e)
        {
            //richTextBoxMetin.Text = richTextBoxMetin.Text + "\nHello World";
            richTextBoxMetin.Text += "\nHello World!";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonZamanEkle_Click(object sender, EventArgs e)
        {
            //richTextBoxMetin.Text = richTextBoxMetin.Text + "\n" + dateTimePicker1.Text;
            richTextBoxMetin.Text += "\n" + dateTimePicker1.Text;
        }

        private void ButtonDegerBelirt_Click(object sender, EventArgs e)
        {
            //richTextBoxVolumeDegeri.Text = richTextBoxVolumeDegeri.Text + "\n" + trackBarVolume.Value;
            richTextBoxVolumeDegeri.Text += trackBarVolume.Value; //richTextBoxVolumeDegeri.Text += "\n" + trackBarVolume.Value;
        }

        private void ButtonDegerSil_Click(object sender, EventArgs e)
        {
            richTextBoxVolumeDegeri.Text = "";
        }

        private void buttonIsmiComboyaEkle_Click(object sender, EventArgs e)
        {
            comboBoxIsimler.Items.Add(textBoxEklenecekIsim.Text);
        }

        private void buttonDeneme_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }






    }

}
