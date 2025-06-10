using System;
using MatematikaLibraries;

namespace MainApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PROGRAM MATEMATIKA LIBRARY ===");
            Console.WriteLine("Nama: Mohammad Fathurrohman");
            Console.WriteLine("NIM: 2211104070");
            Console.WriteLine("=====================================\n");

            // Membuat instance dari class MatematikaOperasi
            MatematikaOperasi matematik = new MatematikaOperasi();

            // Testing FPB (Faktor Persekutuan Terbesar)
            Console.WriteLine("1. TESTING FPB (Faktor Persekutuan Terbesar)");
            Console.WriteLine("-------------------------------------------");
            int bil1 = 60, bil2 = 45;
            int hasilFPB = matematik.FPB(bil1, bil2);
            Console.WriteLine($"FPB({bil1}, {bil2}) = {hasilFPB}");

            bil1 = 48; bil2 = 18;
            hasilFPB = matematik.FPB(bil1, bil2);
            Console.WriteLine($"FPB({bil1}, {bil2}) = {hasilFPB}");
            Console.WriteLine();

            // Testing KPK (Kelipatan Persekutuan Terkecil)
            Console.WriteLine("2. TESTING KPK (Kelipatan Persekutuan Terkecil)");
            Console.WriteLine("-----------------------------------------------");
            bil1 = 12; bil2 = 8;
            int hasilKPK = matematik.KPK(bil1, bil2);
            Console.WriteLine($"KPK({bil1}, {bil2}) = {hasilKPK}");

            bil1 = 15; bil2 = 20;
            hasilKPK = matematik.KPK(bil1, bil2);
            Console.WriteLine($"KPK({bil1}, {bil2}) = {hasilKPK}");
            Console.WriteLine();

            // Testing Turunan
            Console.WriteLine("3. TESTING TURUNAN");
            Console.WriteLine("------------------");

            // Contoh: x³ + 4x² - 12x + 9
            int[] persamaan1 = { 1, 4, -12, 9 };
            string hasilTurunan = matematik.Turunan(persamaan1);
            Console.WriteLine("Persamaan: x³ + 4x² - 12x + 9");
            Console.WriteLine($"Turunan: {hasilTurunan}");

            // Contoh: 2x⁴ - 3x³ + 5x² - 7x + 1
            int[] persamaan2 = { 2, -3, 5, -7, 1 };
            hasilTurunan = matematik.Turunan(persamaan2);
            Console.WriteLine("\nPersamaan: 2x⁴ - 3x³ + 5x² - 7x + 1");
            Console.WriteLine($"Turunan: {hasilTurunan}");
            Console.WriteLine();

            // Testing Integral
            Console.WriteLine("4. TESTING INTEGRAL");
            Console.WriteLine("-------------------");

            // Contoh: 4x³ + 6x² - 12x + 9
            int[] persamaan3 = { 4, 6, -12, 9 };
            string hasilIntegral = matematik.Integral(persamaan3);
            Console.WriteLine("Persamaan: 4x³ + 6x² - 12x + 9");
            Console.WriteLine($"Integral: {hasilIntegral}");

            // Contoh: 3x² + 8x - 12
            int[] persamaan4 = { 3, 8, -12 };
            hasilIntegral = matematik.Integral(persamaan4);
            Console.WriteLine("\nPersamaan: 3x² + 8x - 12");
            Console.WriteLine($"Integral: {hasilIntegral}");
            Console.WriteLine();

            Console.WriteLine("=====================================");
            Console.WriteLine("Program selesai. Tekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}