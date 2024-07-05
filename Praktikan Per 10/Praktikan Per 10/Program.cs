using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Pelanggan
    {
        public string ID { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
    }

    static void Main(string[] args)
    {
        List<Pelanggan> daftarPelanggan = new List<Pelanggan>();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Tambah Data Pelanggan");
            Console.WriteLine("2. Hapus Data Pelanggan");
            Console.WriteLine("3. Urutkan Data Pelanggan ");
            Console.WriteLine("4. Cari Posisi Indeks Pelanggan  berdasarkan nomor ID");
            Console.WriteLine("5. Tampilkan Seluruh Data Pelanggan");
            Console.WriteLine("6. Keluar");
            Console.WriteLine("Pilih Menu:");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    TambahkanDataPelanggan(daftarPelanggan);
                    break;
                case 2:
                    HapusDataPelanggan(daftarPelanggan);
                    break;
                case 3:
                    UrutkanDataPelanggan(daftarPelanggan);
                    break;
                case 4:
                    CariPosisiIndeksPelanggan(daftarPelanggan);
                    break;
                case 5:
                    TampilkanSeluruhDataPelanggan(daftarPelanggan);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Menu Tidak Valid.Silahkan Pilih Menu Yang Benar.");
                    break;
            }

        }
    }

    static void TambahkanDataPelanggan(List<Pelanggan> list)
    {
        Console.WriteLine("\nTambah Data Pelanggan");
        Console.Write("ID:");
        string id = Console.ReadLine();
        Console.Write("Nama:");
        string nama = Console.ReadLine();
        Console.Write("Alamat:");
        string alamat = Console.ReadLine();
        list.Add(new Pelanggan { ID = id, Nama = nama, Alamat = alamat });
        Console.WriteLine(" Data pelanggan berhasil ditambahkan.");
    }
    static void HapusDataPelanggan(List<Pelanggan> list)
    {
        Console.WriteLine("\nHapus Data Pelanggan:");
        Console.Write("Masukkan ID Pelanggan yang ingin dihapus:");
        string id = Console.ReadLine();

        Pelanggan pelanggan = list.FirstOrDefault(m => m.ID == id );
        if (pelanggan != null)
        {
            list.Remove(pelanggan);
            Console.WriteLine("Data Pelanggan berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Data Pelanggan Tidak ditemukan");

        }
    }
    static void UrutkanDataPelanggan(List<Pelanggan> list)
    {
        list.Sort((x, y) => x.Nama.CompareTo(y.Nama));
        Console.WriteLine("\nData Pelanggan  Berhasil diurutkan berdasarkan Nama.");
    }
    static void CariPosisiIndeksPelanggan(List<Pelanggan> list)
    {
        Console.WriteLine("\nCari Posisi Pelanggan  yang Ingin dicari berdasarkan ID:");
        Console.Write("Masukkan ID Pelanggan yang Ingin dicari:");
        string id = Console.ReadLine();

        int index = list.FindIndex(m => m.ID == id);
        if (index != -1)
        {
            Console.WriteLine($"Pelanggan dengan ID {id} ditemukan pada indeks ke -{index}.");
        }
        else
        {
            Console.WriteLine("Pelanggan tidak ditemukan.");
        }

    }
    static void TampilkanSeluruhDataPelanggan(List<Pelanggan> list)
    {
        Console.WriteLine("\nData Pelanggan:");
        foreach (var pelanggan in list)
        {
            Console.WriteLine($"ID: {pelanggan.ID}, Nama:{pelanggan.Nama},Alamat: {pelanggan.Alamat}");
        }
    }
}