namespace Aplikasi_Hitung_Luas_Dan_Keliling_Bangun_Ruang_Dasar
{
    partial class halamanUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbPilihan = new ComboBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // cmbPilihan
            // 
            cmbPilihan.FormattingEnabled = true;
            cmbPilihan.Location = new Point(12, 12);
            cmbPilihan.Name = "cmbPilihan";
            cmbPilihan.Size = new Size(380, 23);
            cmbPilihan.TabIndex = 0;
            cmbPilihan.SelectedIndexChanged += cmbPilihan_SelectedIndexChanged;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 41);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 55);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // halamanUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 109);
            Controls.Add(btnExit);
            Controls.Add(cmbPilihan);
            Name = "halamanUtama";
            Text = "Penghitung Bangun Ruang Dasar";
            Load += halamanUtama_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPilihan;
        private Button btnExit;
    }
}
