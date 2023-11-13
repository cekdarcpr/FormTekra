namespace Ornek_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            double vize1, final, ort;
            vize1 = Double.Parse(textBox1.Text);
            final = Double.Parse(textBox2.Text);

            ort = vize1 * 0.4 + final * 0.6;
            lblortalama.Text = ort.ToString();

            if (ort <= 50)
            {
                lblDurum.Text = "KALDIN...";
                BackColor = Color.Red;
            }
            else
            {
                lblDurum.Text = "GEÇTÝN...";
                BackColor = Color.Green;
            }



        }
    }
}