using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Masukkan name Anda   : ");
        string Name = Console.ReadLine();

        Console.Write("Masukkan NIM Anda    : ");
        int NIM = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan Age Anda    : ");
        int Age = Convert.ToInt32(Console.ReadLine());

        Pengguna(Name, Age);
    }

    static void Pengguna(string Name, int Age)
    {
        if (Age < 18)
        {
            Console.WriteLine($"Halo {Name}, kamu masih anak-anak!");
        }
        else if (Age >= 18 && Age <= 65)
        {
            Console.WriteLine($"Halo {Name}, selamat datang!");
        }
        else
        {
            Console.WriteLine($"Halo {Name}, semoga hari-harimu menyenangkan!");
        }
    }
}