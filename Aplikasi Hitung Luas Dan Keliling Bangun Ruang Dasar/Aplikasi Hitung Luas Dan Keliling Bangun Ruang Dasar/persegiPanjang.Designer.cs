namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    partial class persegiPanjang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbPilihan = new ComboBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnHitung = new Button();
            btnExit = new Button();
            txtHasil = new TextBox();
            lblHasil = new Label();
            txtLebarSisi = new TextBox();
            lblLebarSisi = new Label();
            txtPanjangSisi = new TextBox();
            lblPanjangSisi = new Label();
            cmbPilihanRumus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPilihan
            // 
            cmbPilihan.FormattingEnabled = true;
            cmbPilihan.Location = new Point(12, 12);
            cmbPilihan.Name = "cmbPilihan";
            cmbPilihan.Size = new Size(244, 23);
            cmbPilihan.TabIndex = 0;
            cmbPilihan.SelectedIndexChanged += cmbPilihan_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnHitung);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(lblHasil);
            groupBox1.Controls.Add(txtLebarSisi);
            groupBox1.Controls.Add(lblLebarSisi);
            groupBox1.Controls.Add(txtPanjangSisi);
            groupBox1.Controls.Add(lblPanjangSisi);
            groupBox1.Controls.Add(cmbPilihanRumus);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 264);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(169, 224);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(87, 224);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(75, 23);
            btnHitung.TabIndex = 8;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(6, 224);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(6, 195);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(238, 23);
            txtHasil.TabIndex = 6;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(6, 177);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(33, 15);
            lblHasil.TabIndex = 5;
            lblHasil.Text = "Hasil";
            // 
            // txtLebarSisi
            // 
            txtLebarSisi.Location = new Point(6, 137);
            txtLebarSisi.Name = "txtLebarSisi";
            txtLebarSisi.Size = new Size(239, 23);
            txtLebarSisi.TabIndex = 4;
            // 
            // lblLebarSisi
            // 
            lblLebarSisi.AutoSize = true;
            lblLebarSisi.Location = new Point(6, 119);
            lblLebarSisi.Name = "lblLebarSisi";
            lblLebarSisi.Size = new Size(109, 15);
            lblLebarSisi.TabIndex = 3;
            lblLebarSisi.Text = "Masukkan lebar sisi";
            // 
            // txtPanjangSisi
            // 
            txtPanjangSisi.Location = new Point(6, 81);
            txtPanjangSisi.Name = "txtPanjangSisi";
            txtPanjangSisi.Size = new Size(238, 23);
            txtPanjangSisi.TabIndex = 2;
            // 
            // lblPanjangSisi
            // 
            lblPanjangSisi.AutoSize = true;
            lblPanjangSisi.Location = new Point(6, 63);
            lblPanjangSisi.Name = "lblPanjangSisi";
            lblPanjangSisi.Size = new Size(126, 15);
            lblPanjangSisi.TabIndex = 1;
            lblPanjangSisi.Text = "Masukkan panjang sisi";
            // 
            // cmbPilihanRumus
            // 
            cmbPilihanRumus.FormattingEnabled = true;
            cmbPilihanRumus.Location = new Point(6, 22);
            cmbPilihanRumus.Name = "cmbPilihanRumus";
            cmbPilihanRumus.Size = new Size(239, 23);
            cmbPilihanRumus.TabIndex = 0;
            // 
            // persegiPanjang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 311);
            Controls.Add(groupBox1);
            Controls.Add(cmbPilihan);
            Name = "persegiPanjang";
            Text = "Persegi panjang";
            Load += persegiPanjang_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPilihan;
        private GroupBox groupBox1;
        private ComboBox cmbPilihanRumus;
        private Label lblPanjangSisi;
        private TextBox txtPanjangSisi;
        private TextBox txtLebarSisi;
        private Label lblLebarSisi;
        private Button btnExit;
        private TextBox txtHasil;
        private Label lblHasil;
        private Button btnHitung;
        private Button btnClear;
    }
}