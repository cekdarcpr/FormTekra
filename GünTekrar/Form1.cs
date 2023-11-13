namespace GünTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void topla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc = 0;

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            sonuc = sayi1 + sayi2;

            lblSonuc.Text = "Sonuc : " + sonuc;



        }
    }
}