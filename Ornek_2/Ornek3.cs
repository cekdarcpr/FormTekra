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
    public partial class Ornek3 : Form
    {
        public Ornek3()
        {
            InitializeComponent();
        }

        private void Ornek3_Load(object sender, EventArgs e)
        {
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                {
                    comboBox1.Items.Add(prop.Name);
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color renk = Color.FromName(comboBox1.Text);
            this.BackColor = renk;
        }
    }
}
