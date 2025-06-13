using System;
using System.Windows.Forms;

namespace modul12_2211104070
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial values
            lblHasil.Text = "Hasil: ";
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil input dari textbox
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);

                // Panggil method CariNilaiPangkat
                long hasil = CariNilaiPangkat(a, b);

                // Tampilkan hasil
                if (hasil == -1)
                {
                    lblHasil.Text = "Hasil: Error - B tidak boleh negatif";
                }
                else if (hasil == -2)
                {
                    lblHasil.Text = "Hasil: Error - A > 100 atau B > 10";
                }
                else if (hasil == -3)
                {
                    lblHasil.Text = "Hasil: Error - Overflow";
                }
                else
                {
                    lblHasil.Text = $"Hasil: {a}^{b} = {hasil}";
                }
            }
            catch (FormatException)
            {
                lblHasil.Text = "Hasil: Error - Input harus berupa angka";
            }
            catch (Exception ex)
            {
                lblHasil.Text = $"Hasil: Error - {ex.Message}";
            }
        }

        /// <summary>
        /// Method untuk menghitung pangkat dengan aturan khusus
        /// </summary>
        /// <param name="a">Basis</param>
        /// <param name="b">Eksponen</param>
        /// <returns>Hasil pangkat atau kode error</returns>
        public long CariNilaiPangkat(int a, int b)
        {
            // Aturan 1: Jika b = 0, return 1 (bahkan jika a = 0)
            if (b == 0)
            {
                return 1;
            }

            // Aturan 2: Jika b negatif, return -1
            if (b < 0)
            {
                return -1;
            }

            // Aturan 3: Jika a > 100 atau b > 10, return -2
            if (a > 100 || b > 10)
            {
                return -2;
            }

            // Hitung pangkat dengan iterasi
            try
            {
                long hasil = 1;

                for (int i = 0; i < b; i++)
                {
                    // Cek overflow sebelum perkalian
                    if (hasil > long.MaxValue / Math.Abs(a))
                    {
                        return -3; // Overflow
                    }
                    hasil *= a;
                }

                return hasil;
            }
            catch (OverflowException)
            {
                // Aturan 4: Jika overflow, return -3
                return -3;
            }
        }
    }
}