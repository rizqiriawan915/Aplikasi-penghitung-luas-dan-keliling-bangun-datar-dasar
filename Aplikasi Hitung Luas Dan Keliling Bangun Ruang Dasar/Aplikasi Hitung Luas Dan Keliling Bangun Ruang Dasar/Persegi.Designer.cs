namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    partial class Persegi
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
            btnExit = new Button();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnHitung = new Button();
            txtHasil = new TextBox();
            lblHasil = new Label();
            txtSisiPersegi = new TextBox();
            lblSisiPersegi = new Label();
            cmbPilihanRumus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPilihan
            // 
            cmbPilihan.FormattingEnabled = true;
            cmbPilihan.Location = new Point(12, 12);
            cmbPilihan.Name = "cmbPilihan";
            cmbPilihan.Size = new Size(251, 23);
            cmbPilihan.TabIndex = 0;
            cmbPilihan.SelectedIndexChanged += cmbPilihan_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(6, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnHitung);
            groupBox1.Controls.Add(txtHasil);
            groupBox1.Controls.Add(lblHasil);
            groupBox1.Controls.Add(txtSisiPersegi);
            groupBox1.Controls.Add(lblSisiPersegi);
            groupBox1.Controls.Add(cmbPilihanRumus);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Location = new Point(12, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(251, 264);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(168, 202);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnHitung
            // 
            btnHitung.Location = new Point(87, 202);
            btnHitung.Name = "btnHitung";
            btnHitung.Size = new Size(75, 23);
            btnHitung.TabIndex = 3;
            btnHitung.Text = "Hitung";
            btnHitung.UseVisualStyleBackColor = true;
            btnHitung.Click += btnHitung_Click;
            // 
            // txtHasil
            // 
            txtHasil.Location = new Point(6, 140);
            txtHasil.Name = "txtHasil";
            txtHasil.ReadOnly = true;
            txtHasil.Size = new Size(237, 23);
            txtHasil.TabIndex = 6;
            // 
            // lblHasil
            // 
            lblHasil.AutoSize = true;
            lblHasil.Location = new Point(6, 122);
            lblHasil.Name = "lblHasil";
            lblHasil.Size = new Size(33, 15);
            lblHasil.TabIndex = 5;
            lblHasil.Text = "Hasil";
            // 
            // txtSisiPersegi
            // 
            txtSisiPersegi.Location = new Point(6, 77);
            txtSisiPersegi.Name = "txtSisiPersegi";
            txtSisiPersegi.Size = new Size(237, 23);
            txtSisiPersegi.TabIndex = 3;
            // 
            // lblSisiPersegi
            // 
            lblSisiPersegi.AutoSize = true;
            lblSisiPersegi.Location = new Point(6, 59);
            lblSisiPersegi.Name = "lblSisiPersegi";
            lblSisiPersegi.Size = new Size(121, 15);
            lblSisiPersegi.TabIndex = 4;
            lblSisiPersegi.Text = "Masukkan sisi persegi";
            // 
            // cmbPilihanRumus
            // 
            cmbPilihanRumus.FormattingEnabled = true;
            cmbPilihanRumus.Location = new Point(6, 22);
            cmbPilihanRumus.Name = "cmbPilihanRumus";
            cmbPilihanRumus.Size = new Size(237, 23);
            cmbPilihanRumus.TabIndex = 3;
            // 
            // Persegi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 311);
            Controls.Add(groupBox1);
            Controls.Add(cmbPilihan);
            Name = "Persegi";
            Text = "Persegi";
            Load += Persegi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPilihan;
        private Button btnExit;
        private GroupBox groupBox1;
        private ComboBox cmbPilihanRumus;
        private Label lblSisiPersegi;
        private Button btnClear;
        private Button btnHitung;
        private TextBox txtHasil;
        private Label lblHasil;
        private TextBox txtSisiPersegi;
    }
}