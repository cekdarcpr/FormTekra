namespace Mağaza_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                fiyat1.Text = "0";
            }
            else if (listBox1.Text == "Uzun Kol")
            {
                fiyat1.Text = "70";
            }
            else if (listBox1.Text == "Kısa Kol")
            {
                fiyat1.Text = "50";
            }
            else if (listBox1.Text == "Hakim Yaka")
            {
                fiyat1.Text = "95";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
            {
                fiyat2.Text = "0";
            }
            else if (listBox2.Text == "Keten")
            {
                fiyat2.Text = "85";
            }
            else if (listBox2.Text == "Kot")
            {
                fiyat2.Text = "105";
            }
            else if (listBox2.Text == "Kumaş")
            {
                fiyat2.Text = "115";
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.Text == "")
            {
                fiyat3.Text = "0";
            }
            else if (listBox3.Text == "Kot")
            {
                fiyat3.Text = "150";
            }
            else if (listBox3.Text == "Deri")
            {
                fiyat3.Text = "175";
            }
            else if (listBox3.Text == "Kumaş")
            {
                fiyat3.Text = "160";
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.Text == "")
            {
                fiyat4.Text = "0";
            }
            else if (listBox4.Text == "Bot")
            {
                fiyat4.Text = "650";
            }
            else if (listBox4.Text == "Spor")
            {
                fiyat4.Text = "470";
            }
            else if (listBox4.Text == "Deri")
            {
                fiyat4.Text = "345";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam;

            Sepet.Items.Clear();

            if (listBox1.Text != "")
                Sepet.Items.Add(listBox1.Text + " : " + fiyat1.Text);
            if (listBox2.Text != "")
                Sepet.Items.Add(listBox2.Text + " : " + fiyat2.Text);
            if (listBox3.Text != "")
                Sepet.Items.Add($"{listBox3.Text} : {fiyat3.Text}");
            if (listBox4.Text != "")
                Sepet.Items.Add($"{listBox4.Text} : {fiyat4.Text}");

            toplam = int.Parse(fiyat1.Text) + int.Parse(fiyat2.Text) + int.Parse(fiyat3.Text) + int.Parse(fiyat4.Text);
            textBox1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double toplam, indirim, ogrenci, odenecekttr;
            toplam = double.Parse(textBox1.Text);

            if (checkBox1.Checked)
                ogrenci = toplam / 20;
            else
                ogrenci = 0;

            if (toplam >= 150)
                indirim = toplam / 10;
            else
                indirim = 0;

            odenecekttr = toplam - indirim - ogrenci;

            richTextBox1.Clear();
            richTextBox1.Text += "Toplam Tutar : " + toplam + "\n";
            richTextBox1.Text += "İndirim Tutar : " + indirim + "\n";
            richTextBox1.Text += "Öğrenci İndirimi : " + ogrenci + "\n";
            richTextBox1.Text += "_________________________________" + "\r";
            richTextBox1.Text += "Ödenecek Tutar : " + odenecekttr ;

           
        }
    }
}