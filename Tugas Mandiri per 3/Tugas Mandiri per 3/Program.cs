using System;

namespace ProgramSegitiga
{
    class Program
    {
        static void Main(string[] args)
        {

            string nama = "Sarah Nurul Yakin";
            string nim = "1237050014";

            Console.WriteLine(" Membuat Segitiga");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"NIM : {nim}\n");


            Console.Write("Masukkan tinggi segitiga: ");
            int tinggi = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSegitiga Sama Kaki dengan Simbol Bintang:");
            for (int i = 1; i <= tinggi; i++)
            {
                for (int j = 1; j <= tinggi - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSegitiga Siku-Siku Terbalik dengan Nomor:");
            int counter = 1;
            for (int i = tinggi; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                    counter++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nSegitiga Siku-Siku dengan Nomor:");
            counter = 1;
            for (int i = 1; i <= tinggi; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}", j);
                    counter++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
