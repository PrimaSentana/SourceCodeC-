using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ----------Program Matematika C#---------- ");
            Console.WriteLine("===========================================");
            Console.WriteLine("Pilih metode : ");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.Write("-------------:"); string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Write("Masukkan Nilai X : "); int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan Nilai Y : "); int y = Convert.ToInt32(Console.ReadLine());
                int jumlah = x + y;
                Console.WriteLine("-------------------");
                Console.WriteLine("Hasil = " + jumlah);
            }
            else if (choice == "2")
            {
                Console.Write("Masukkan Nilai X : "); int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan Nilai Y : "); int y = Convert.ToInt32(Console.ReadLine());
                int jumlah = x - y;
                Console.WriteLine("-------------------");
                Console.WriteLine("Hasil = " + jumlah);
            }
            else
            {
                Console.WriteLine("Parameter Invalid");
                Main(args);
            }
        }
    }
}