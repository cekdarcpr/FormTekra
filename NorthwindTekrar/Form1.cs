using Microsoft.Data.SqlClient;
using System.Data;

namespace NorthwindTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP-3RDN6LK\\SQLEXPRESS; Initial Catalog=Northwind; Integrated Security=True;TrustServerCertificate=True; ");

        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Customers", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

    }
}