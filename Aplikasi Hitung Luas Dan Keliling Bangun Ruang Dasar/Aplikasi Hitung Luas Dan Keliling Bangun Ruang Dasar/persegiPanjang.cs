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
    public partial class persegiPanjang : Form
    {
        public persegiPanjang()
        {
            InitializeComponent();
        }

        private void persegiPanjang_Load(object sender, EventArgs e)
        {
            // Pilihan navbar 
            cmbPilihan.Items.Add("Halaman utama");
            cmbPilihan.Items.Add("Persegi");
            cmbPilihan.Items.Add("Lingkaran");

            // Pilihan rumus
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
            }
            else if (cmbPilihan.SelectedItem.ToString() == "Persegi")
            {
                Persegi persegi = new Persegi();
                persegi.Show();
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
                // Validasi input kosong
                if (string.IsNullOrWhiteSpace(txtPanjangSisi.Text) || string.IsNullOrWhiteSpace(txtLebarSisi.Text))
                {
                    MessageBox.Show("Harap isi semua input terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parsing input
                if (!int.TryParse(txtPanjangSisi.Text, out int panjangPersegi) || !int.TryParse(txtLebarSisi.Text, out int lebarPersegi))
                {
                    MessageBox.Show("Masukkan angka yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi pemilihan rumus
                if (string.IsNullOrWhiteSpace(cmbPilihanRumus.Text))
                {
                    MessageBox.Show("Silakan pilih rumus yang ingin dihitung.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cmbPilihanRumus.Text == "Luas")
                {
                    int luasPersegi = panjangPersegi * lebarPersegi;
                    txtHasil.Text = luasPersegi.ToString();
                }
                else if (cmbPilihanRumus.Text == "Keliling")
                {
                    int kelilingPersegi = (2 * panjangPersegi) + (2 * lebarPersegi);
                    txtHasil.Text = kelilingPersegi.ToString();
                }
                else
                {
                    MessageBox.Show("Pilihan rumus tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPanjangSisi.Text = "";
            txtLebarSisi.Text = "";
            txtHasil.Text = "";
        }
    }
}
