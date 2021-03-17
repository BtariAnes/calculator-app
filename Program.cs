using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih menu calculator\n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian\n");


            Console.WriteLine("Masukan Pilihan [1-4]: ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int b = 0;


            switch (pilihan)
            {
                case 1:
                    Console.Write("inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    var totalTambah = penjumlahan(a, b);
                    Console.WriteLine("Hasil:" + totalTambah);
                    break;
                case 2:
                    Console.Write("inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    var totalKurang = pengurangan(a, b);
                    Console.WriteLine("Hasil:" + totalKurang);
                    break;
                case 3:

                    Console.Write("inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    var totalKali = perkalian(a, b);
                    Console.WriteLine("Hasil:" + totalKali);
                    break;
                case 4:

                    Console.Write("inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Inputkan nilai b = ");
                    b = Convert.ToInt32(Console.ReadLine());

                    double totalBagi = pembagian(a, b);
                    Console.WriteLine("Hasil:" + totalBagi);
                    break;

                default:
                    Console.WriteLine("Maaf, Menu yg Anda pilih tidak tersedia");
                    break;
            }

        }

        private static int penjumlahan(int a, int b)
        {
            return a + b;
        }
        private static int pengurangan(int a, int b)
        {
            return a - b;
        }
        private static int perkalian(int a, int b)
        {
            return a * b;
        }
        private static double pembagian(int a, int b)
        {
            return a / b;
        }

    }

}