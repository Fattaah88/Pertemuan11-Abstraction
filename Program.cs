using System;

namespace Pertemuan_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hewan Ayam = new Ayam();
            Hewan Kucing = new Kucing();

            Console.WriteLine("Pilih hewan yang dimaksud : ");
            Console.WriteLine("[1...2]");
            int Pilih = Convert.ToInt32(Console.ReadLine());

            if (Pilih == 1)
                Ayam.Bersuara();
            else if (Pilih == 2)
                Kucing.Bersuara();
            else
                Console.WriteLine("Hewan yang Anda pilih tidak valid :) ");

            Console.ReadKey();
        }
    }
}
