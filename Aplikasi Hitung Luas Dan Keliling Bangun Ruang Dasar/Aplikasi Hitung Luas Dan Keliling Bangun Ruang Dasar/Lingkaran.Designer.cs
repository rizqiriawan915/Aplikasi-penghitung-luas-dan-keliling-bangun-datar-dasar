namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    partial class Lingkaran
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
            txtHasil = new TextBox();
            lblHasil = new Label();
            btnClear = new Button();
            btnHitung = new Button();
            btnExit = new Button();
            txtDiameterLingkaran = new TextBox();
            lblDiameterLingkaran = new Label();
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
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(lblHasil);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnHitung);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(txtDiameterLingkaran);
            groupBox1.Controls.Add(lblDiameterLingkaran);
            groupBox1.Controls.Add(cmbPilihanRumus);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 249);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(6, 124);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(232, 23);
            txtHasil.TabIndex = 7;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(6, 106);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(33, 15);
            lblHasil.TabIndex = 6;
            lblHasil.Text = "Hasil";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(163, 220);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(87, 220);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(75, 23);
            btnHitung.TabIndex = 4;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(6, 220);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // txtDiameterLingkaran
            // 
            txtDiameterLingkaran.Location = new Point(6, 80);
            txtDiameterLingkaran.Name = "txtDiameterLingkaran";
            txtDiameterLingkaran.Size = new Size(232, 23);
            txtDiameterLingkaran.TabIndex = 2;
            // 
            // lblDiameterLingkaran
            // 
            lblDiameterLingkaran.AutoSize = true;
            lblDiameterLingkaran.Location = new Point(6, 62);
            lblDiameterLingkaran.Name = "lblDiameterLingkaran";
            lblDiameterLingkaran.Size = new Size(163, 15);
            lblDiameterLingkaran.TabIndex = 1;
            lblDiameterLingkaran.Text = "Masukkan diameter lingkaran";
            // 
            // cmbPilihanRumus
            // 
            cmbPilihanRumus.FormattingEnabled = true;
            cmbPilihanRumus.Location = new Point(6, 22);
            cmbPilihanRumus.Name = "cmbPilihanRumus";
            cmbPilihanRumus.Size = new Size(232, 23);
            cmbPilihanRumus.TabIndex = 0;
            // 
            // Lingkaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 311);
            Controls.Add(groupBox1);
            Controls.Add(cmbPilihan);
            Name = "Lingkaran";
            Text = "Lingkaran";
            Load += Lingkaran_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPilihan;
        private GroupBox groupBox1;
        private ComboBox cmbPilihanRumus;
        private TextBox txtDiameterLingkaran;
        private Label lblDiameterLingkaran;
        private Button btnExit;
        private Button btnHitung;
        private Button btnClear;
        private TextBox txtHasil;
        private Label lblHasil;
    }
}