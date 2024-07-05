using System;
using System.Collections.Generic;

class Karyawan
{
    public int ID { get; set; }
    public string Nama { get; set; }
    public string Jabatan { get; set; }
    public double Gaji { get; set; }
}

class Program
{
    static void Main()
    {
        List<Karyawan> daftarKaryawan = new List<Karyawan>();

        while (true)
        {
            Console.WriteLine("Nama : Sarah Nurul Yakin");
            Console.WriteLine("NIM  : 1237050014");
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tambah karyawan baru");
            Console.WriteLine("2. Hapus karyawan berdasarkan ID");
            Console.WriteLine("3. Urutkan karyawan berdasarkan gaji");
            Console.WriteLine("4. Cari karyawan berdasarkan ID");
            Console.WriteLine("5. Tampilkan seluruh data karyawan");
            Console.WriteLine("6. Keluar dari program");
            Console.Write("Pilih Menu : ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    TambahKaryawan(daftarKaryawan);
                    break;
                case 2:
                    HapusKaryawan(daftarKaryawan);
                    break;
                case 3:
                    UrutkanKaryawan(daftarKaryawan);
                    break;
                case 4:
                    CariKaryawan(daftarKaryawan);
                    break;
                case 5:
                    TampilkanDataKaryawan(daftarKaryawan);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih menu yang benar.");
                    break;
            }
        }
    }

    static void TambahKaryawan(List<Karyawan> daftarKaryawan)
    {
        Console.Write("Masukkan ID karyawan     : ");
        int id = int.Parse(Console.ReadLine());

        // Cek ID
        if (daftarKaryawan.Exists(k => k.ID == id))
        {
            Console.WriteLine("Karyawan dengan ID tersebut sudah ada.");
            return;
        }

        Console.Write("Masukkan nama karyawan : ");
        string nama = Console.ReadLine();
        Console.Write("Masukkan jabatan karyawan: ");
        string jabatan = Console.ReadLine();
        Console.Write("Masukkan gaji karyawan   : ");
        double gaji = double.Parse(Console.ReadLine());

        daftarKaryawan.Add(new Karyawan { ID = id, Nama = nama, Jabatan = jabatan, Gaji = gaji });
        Console.WriteLine("Karyawan berhasil ditambahkan.");
    }

    static void HapusKaryawan(List<Karyawan> daftarKaryawan)
    {
        Console.Write("Masukkan ID karyawan yang akan dihapus: ");
        int id = int.Parse(Console.ReadLine());

        Karyawan karyawan = daftarKaryawan.Find(k => k.ID == id);
        if (karyawan != null)
        {
            daftarKaryawan.Remove(karyawan);
            Console.WriteLine("Karyawan berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Karyawan dengan ID tersebut tidak ditemukan.");
        }
    }

    static void UrutkanKaryawan(List<Karyawan> daftarKaryawan)
    {
        daftarKaryawan.Sort((k1, k2) => k1.Gaji.CompareTo(k2.Gaji));
        Console.WriteLine("Karyawan berhasil diurutkan berdasarkan gaji.");
    }

    static void CariKaryawan(List<Karyawan> daftarKaryawan)
    {
        Console.Write("Masukkan ID karyawan yang akan dicari: ");
        int id = int.Parse(Console.ReadLine());

        Karyawan karyawan = daftarKaryawan.Find(k => k.ID == id);
        if (karyawan != null)
        {
            Console.WriteLine($"ID: {karyawan.ID}, Nama: {karyawan.Nama}, Jabatan: {karyawan.Jabatan}, Gaji: {karyawan.Gaji}");
        }
        else
        {
            Console.WriteLine("Karyawan dengan ID tersebut tidak ditemukan.");
        }
    }

    static void TampilkanDataKaryawan(List<Karyawan> daftarKaryawan)
    {
        foreach (var karyawan in daftarKaryawan)
        {
            Console.WriteLine($"ID: {karyawan.ID}, Nama: {karyawan.Nama}, Jabatan: {karyawan.Jabatan}, Gaji: {karyawan.Gaji}");
        }
    }
}
