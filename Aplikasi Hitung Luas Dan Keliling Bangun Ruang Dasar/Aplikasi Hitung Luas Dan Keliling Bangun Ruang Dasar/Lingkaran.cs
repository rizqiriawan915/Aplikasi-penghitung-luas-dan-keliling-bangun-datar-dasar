using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    public partial class Lingkaran : Form
    {
        public Lingkaran()
        {
            InitializeComponent();
        }

        private void Lingkaran_Load(object sender, EventArgs e)
        {
            // pilihan utama
            cmbPilihan.Items.Add("Halaman utama");
            cmbPilihan.Items.Add("Persegi");
            cmbPilihan.Items.Add("Persegi panjang");

            // pilihan rumus
            cmbPilihanRumus.Items.Add("Luas");
            cmbPilihanRumus.Items.Add("Keliling");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDiameterLingkaran.Text, out double diameter))
            {
                double jariJari = diameter / 2;
                double hasil = 0;
                double phi = (diameter % 7 == 0) ? (22.0 / 7.0) : 3.14;
                if (cmbPilihanRumus.SelectedItem != null)
                {
                    string pilihanRumus = cmbPilihanRumus.SelectedItem.ToString();
                    if (pilihanRumus == "Luas")
                    {
                        hasil = phi * jariJari * jariJari; // Perbaikan rumus luas
                        txtHasil.Text = hasil.ToString("F2");
                    }
                    else if (pilihanRumus == "Keliling")
                    {
                        hasil = 2 * phi * jariJari;
                        txtHasil.Text = hasil.ToString("F2");
                    }
                    else
                    {
                        MessageBox.Show("Pilih rumus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pilih rumus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Masukkan diameter yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPilihan.SelectedItem.ToString() == "Halaman utama")
            {
                halamanUtama fromHalamanUtama = new halamanUtama();
                fromHalamanUtama.Show();
                this.Hide();
            }
            else if (cmbPilihan.SelectedItem.ToString() == "Persegi")
            {
                Persegi fromPersegi = new Persegi();
                fromPersegi.Show();
                this.Hide();
            }
            else if (cmbPilihan.SelectedItem.ToString() == "Persegi panjang")
            {
                persegiPanjang fromPersegiPanjang = new persegiPanjang();
                fromPersegiPanjang.Show();
                this.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDiameterLingkaran.Text = "";
            txtHasil.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
