namespace VisualStdCSarpders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMesajGoruntule_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "Hey Vun Hikya? Veziyatar Qsan Yeni?";
        }

        private void buttonMesajSil_Click(object sender, EventArgs e)
        {
            textBoxMesaj.Text = "";
        }

        private void buttonIsmiComboyaEkle_Click(object sender, EventArgs e)
        {
            comboBoxIsimler.Items.Add(textBoxMesaj.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLabelDegistir_Click(object sender, EventArgs e)
        {
            labelYazilanIsim.Text = textBoxMesaj.Text;
        }

        private void buttonLabelSil_Click(object sender, EventArgs e)
        {
            labelYazilanIsim.Text = "";
        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            listBoxDersler.Items.Add(textBoxMesaj.Text);
        }
    }
}