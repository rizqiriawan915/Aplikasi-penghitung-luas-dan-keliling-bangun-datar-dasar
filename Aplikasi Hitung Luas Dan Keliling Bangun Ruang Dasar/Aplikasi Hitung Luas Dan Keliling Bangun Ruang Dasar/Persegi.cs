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
    public partial class Persegi : Form
    {
        public Persegi()
        {
            InitializeComponent();
        }

        private void Persegi_Load(object sender, EventArgs e)
        {
            // ComboBox untuk navbar utama
            cmbPilihan.Items.Add("Halaman utama");
            cmbPilihan.Items.Add("Persegi panjang");
            cmbPilihan.Items.Add("Lingkaran");

            // ComboBox untuk pilihan rumus
            cmbPilihanRumus.Items.Add("Luas");
            cmbPilihanRumus.Items.Add("Keliling");
        }

        private void cmbPilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPilihan.SelectedItem.ToString() == "Halaman utama")
            {
                halamanUtama halamanUtama = new halamanUtama();
                halamanUtama.Show();
                this.Hide();
            }else if(cmbPilihan.SelectedItem.ToString() == "Persegi panjang")
            {
                persegiPanjang persegiPanjang = new persegiPanjang();
                persegiPanjang.Show();
                this.Hide();
            }else if(cmbPilihan.SelectedItem.ToString() == "Lingkaran")
            {
                Lingkaran fromLingkaran = new Lingkaran();
                fromLingkaran.Show();
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah ComboBox sudah dipilih
                if (cmbPilihanRumus.SelectedIndex == -1)
                {
                    MessageBox.Show("Silakan pilih rumus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cek apakah TextBox tidak kosong
                if (string.IsNullOrWhiteSpace(txtSisiPersegi.Text))
                {
                    MessageBox.Show("Silakan masukkan nilai sisi persegi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Coba konversi input ke angka
                if (!int.TryParse(txtSisiPersegi.Text, out int sisiPersegi))
                {
                    MessageBox.Show("Masukkan angka yang valid untuk sisi persegi!", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Pastikan angka tidak negatif
                if (sisiPersegi <= 0)
                {
                    MessageBox.Show("Nilai sisi harus lebih dari 0!", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int hasil = 0;

                // Perhitungan berdasarkan pilihan
                if (cmbPilihanRumus.SelectedItem.ToString() == "Luas")
                {
                    hasil = sisiPersegi * sisiPersegi;
                }
                else if (cmbPilihanRumus.SelectedItem.ToString() == "Keliling")
                {
                    hasil = 4 * sisiPersegi;
                }

                // Tampilkan hasil
                txtHasil.Text = hasil.ToString();
            }
            catch (Exception ex)
            {
                // Tangani error tak terduga
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSisiPersegi.Text = "";
            txtHasil.Text = "";
        }
    }
}
