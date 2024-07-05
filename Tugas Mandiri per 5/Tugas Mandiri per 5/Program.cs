using System;

class Program
{
    static void Main(string[] args)
    {
        int merahDurasi, kuningDurasi, hijauDurasi, iterasi;

        Console.Write("Masukkan nama   : ");
        string Nama = Console.ReadLine();

        Console.Write("Masukkan NIM    : ");
        int NIM = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Program  Lampu Lalu Lintas");

        Console.Write("Masukkan durasi waktu lampu merah (detik) : ");
        merahDurasi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan durasi waktu lampu kuning (detik): ");
        kuningDurasi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan durasi waktu lampu hijau (detik) : ");
        hijauDurasi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan jumlah iterasi simulasi          : ");
        iterasi = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(" Simulasi Dimulai...");

        SimulasiLampu(merahDurasi, kuningDurasi, hijauDurasi, iterasi);

        Console.WriteLine("Simulasi selesai.");
    }

    static void SimulasiLampu(int merahDurasi, int kuningDurasi, int hijauDurasi, int iterasi)
    {
        for (int i = 1; i <= iterasi; i++)
        {
            Console.WriteLine("Iterasi ke-{0}", i);
            Console.WriteLine("Lampu Merah...");
            System.Threading.Thread.Sleep(merahDurasi * 1000);

            Console.WriteLine("Lampu Kuning...");
            System.Threading.Thread.Sleep(kuningDurasi * 1000);

            Console.WriteLine("Lampu Hijau...");
            System.Threading.Thread.Sleep(hijauDurasi * 1000);
        }
    }
}
