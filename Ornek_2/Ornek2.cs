using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_2
{
    public partial class Ornek2 : Form
    {
        public Ornek2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı, sonuc = 1;
            sayı = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= sayı; i++)
            {
                sonuc *= i;
            }
            lblSonuc.Text = sonuc.ToString();

        }

        
    }
}
