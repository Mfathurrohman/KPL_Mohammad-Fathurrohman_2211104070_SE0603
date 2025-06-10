using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatematikaLibraries
{
    public class MatematikaOperasi
    {
        /// <summary>
        /// Mencari Faktor Persekutuan Terbesar (FPB) dari dua bilangan
        /// </summary>
        /// <param name="input1">Bilangan pertama</param>
        /// <param name="input2">Bilangan kedua</param>
        /// <returns>FPB dari kedua bilangan</returns>
        public int FPB(int input1, int input2) 
        {
            // Menggunakan algoritma Euclidean
            input1 = Math.Abs(input1);
            input2 = Math.Abs(input2);

            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }
            return input1;
        }

        /// <summary>
        /// Mencari Kelipatan Persekutuan Terkecil (KPK) dari dua bilangan
        /// </summary>
        /// <param name="input1">Bilangan pertama</param>
        /// <param name="input2">Bilangan kedua</param>
        /// <returns>KPK dari kedua bilangan</returns>
        public int KPK(int input1, int input2)
        {
            // Rumus: KPK(a,b) = |a*b| / FPB(a,b)
            return Math.Abs(input1 * input2) / FPB(input1, input2);
        }

        /// <summary>
        /// Mendapatkan turunan dari persamaan polynomial
        /// </summary>
        /// <param name="persamaan">Array koefisien polynomial dari pangkat tertinggi ke terendah</param>
        /// <returns>String representasi turunan</returns>
        public string Turunan(int[] persamaan)
        {
            if (persamaan == null || persamaan.Length <= 1)
                return "0";

            List<string> terms = new List<string>();
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koefisien = persamaan[i] * pangkat;

                if (koefisien != 0)
                {
                    string term = "";

                    // Menangani tanda
                    if (terms.Count == 0)
                    {
                        if (koefisien < 0)
                            term += "-";
                    }
                    else
                    {
                        term += koefisien > 0 ? " + " : " - ";
                    }

                    int absKoefisien = Math.Abs(koefisien);

                    // Menangani koefisien
                    if (pangkat - 1 == 0) // Konstanta
                    {
                        term += absKoefisien.ToString();
                    }
                    else if (absKoefisien == 1) // Koefisien 1
                    {
                        if (pangkat - 1 == 1)
                            term += "x";
                        else
                            term += $"x{pangkat - 1}";
                    }
                    else // Koefisien selain 1
                    {
                        if (pangkat - 1 == 1)
                            term += $"{absKoefisien}x";
                        else
                            term += $"{absKoefisien}x{pangkat - 1}";
                    }

                    terms.Add(term);
                }
                pangkat--;
            }

            return terms.Count == 0 ? "0" : string.Join("", terms);
        }

        /// <summary>
        /// Mendapatkan integral dari persamaan polynomial
        /// </summary>
        /// <param name="persamaan">Array koefisien polynomial dari pangkat tertinggi ke terendah</param>
        /// <returns>String representasi integral</returns>
        public string Integral(int[] persamaan)
        {
            if (persamaan == null || persamaan.Length == 0)
                return "C";

            List<string> terms = new List<string>();
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                if (persamaan[i] != 0)
                {
                    string term = "";

                    // Menangani tanda
                    if (terms.Count == 0)
                    {
                        if (persamaan[i] < 0)
                            term += "-";
                    }
                    else
                    {
                        term += persamaan[i] > 0 ? " + " : " - ";
                    }

                    // Menghitung koefisien baru (koefisien lama / pangkat baru)
                    double koefisienBaru = (double)Math.Abs(persamaan[i]) / pangkat;

                    // Menangani koefisien
                    if (pangkat == 1) // Akan menjadi konstanta
                    {
                        if (koefisienBaru == (int)koefisienBaru)
                            term += $"{(int)koefisienBaru}x";
                        else
                            term += $"{koefisienBaru}x";
                    }
                    else if (koefisienBaru == 1) // Koefisien 1
                    {
                        term += $"x{pangkat}";
                    }
                    else // Koefisien selain 1
                    {
                        if (koefisienBaru == (int)koefisienBaru)
                            term += $"{(int)koefisienBaru}x{pangkat}";
                        else
                            term += $"{koefisienBaru}x{pangkat}";
                    }

                    terms.Add(term);
                }
                pangkat--;
            }

            string result = terms.Count == 0 ? "" : string.Join("", terms);
            return result + (result.Length > 0 ? " + C" : "C");
        }
    }
}