namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    public partial class halamanUtama : Form
    {
        public halamanUtama()
        {
            InitializeComponent();
        }

        private void halamanUtama_Load(object sender, EventArgs e)
        {
            cmbPilihan.Items.Add("Persegi");
            cmbPilihan.Items.Add("Persegi panjang");
            cmbPilihan.Items.Add("Lingkaran");
            cmbPilihan.SelectedIndex = -1;
        }

        private void cmbPilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPilihan.SelectedItem.ToString() == "Persegi")
            {
                Persegi fromPersegi = new Persegi();
                fromPersegi.Show();
                this.Hide();
            }else if(cmbPilihan.SelectedItem.ToString() == "Persegi panjang")
            {
                persegiPanjang fromPersegiPanjang = new persegiPanjang();
                fromPersegiPanjang.Show();
                this.Hide();
            }else if(cmbPilihan.SelectedItem.ToString() == "Lingkaran")
            {
                Lingkaran fromLingkran = new Lingkaran();
                fromLingkran.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
