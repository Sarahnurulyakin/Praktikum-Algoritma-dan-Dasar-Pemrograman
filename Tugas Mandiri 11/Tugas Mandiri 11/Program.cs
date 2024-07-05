using System;
using System.Collections.Generic;

class Program
{
    class JadwalKerja
    {
        public string Nama { get; set; }
        public string Jam { get; set; }
    }

    static void Main(string[] args)
    {
        List<List<JadwalKerja>> jadwalKerja = new List<List<JadwalKerja>>();

        for (int i = 0; i < 7; i++)
        {
            jadwalKerja.Add(new List<JadwalKerja>());
        }
        Console.WriteLine("Nama : Sarah Nurul Yakin");
        Console.WriteLine("NIM  : 1237050014");
        Console.WriteLine("|===================================|");
        Console.WriteLine("|===================================|");
        Console.WriteLine();
        while (true)
        {
            
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Tambah Shift Kerja");
            Console.WriteLine("2. Hapus Shift Kerja");
            Console.WriteLine("3. Tampilkan Jadwal Kerja");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih Opsi: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    TambahShiftKerja(jadwalKerja);
                    break;
                case 2:
                    HapusShiftKerja(jadwalKerja);
                    break;
                case 3:
                    TampilkanJadwalKerja(jadwalKerja);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Menu tidak valid. Silakan pilih menu yang benar.");
                    break;
            }
        }
    }

    static void TambahShiftKerja(List<List<JadwalKerja>> jadwal)
    {
        Console.WriteLine("\nTambah Shift Kerja:");
        Console.Write("Masukkan hari (0=Senin, 1=Selasa, 2=rabu, 3=kamis, 4=jumat 5=sabtu, 6=Minggu): ");
        int hari = Convert.ToInt32(Console.ReadLine());

        if (hari < 0 || hari > 6)
        {
            Console.WriteLine("Hari tidak valid.");
            return;
        }

        Console.Write("Nama  Karyawan: ");
        string nama = Console.ReadLine();
        Console.Write("Jam Kerja     : ");
        string jam = Console.ReadLine();

        jadwal[hari].Add(new JadwalKerja { Nama = nama, Jam = jam });

        Console.WriteLine("Jam Kerja berhasil ditambahkan.");
    }

    static void HapusShiftKerja(List<List<JadwalKerja>> jadwal)
    {
        Console.WriteLine("\nHapus Shift Kerja:");
        Console.Write("Masukkan hari (0=Senin, 1=Selasa, ..., 6=Minggu): ");
        int hari = Convert.ToInt32(Console.ReadLine());

        if (hari < 0 || hari > 6)
        {
            Console.WriteLine("Hari tidak valid.");
            return;
        }

        Console.Write(" Nama Karyawan shif kerja yang ingin dihapus: ");
        string nama = Console.ReadLine();

        JadwalKerja jadwalKerja = jadwal[hari].Find(mk => mk.Nama == nama);

        if (jadwalKerja != null)
        {
            jadwal[hari].Remove(jadwalKerja);
            Console.WriteLine("Shift Kerja berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Shift Kerja tidak ditemukan.");
        }
    }

    static void TampilkanJadwalKerja(List<List<JadwalKerja>> jadwal)
    {
        string[] namaHari = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"\n{namaHari[i]}:");
            if (jadwal[i].Count == 0)
            {
                Console.WriteLine("Tidak ada Jadwal Kerja.");
            }
            else
            {
                foreach (var jadwalKerja in jadwal[i])
                {
                    Console.WriteLine($"- {jadwalKerja.Nama} ({jadwalKerja.Jam})");
                }
            }
        }
    }
}