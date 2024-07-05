using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nama : Sarah Nurul Yakin");
        Console.WriteLine("NIM : 1237050014");
        Console.Write("Enter the month number (1-12):");
        int monthNumber = Convert.ToInt32(Console.ReadLine());
        string monthName;
        string jumDay;
        switch (monthNumber)
        {
            case 1:
                monthName = "Januari";
                jumDay = " 31";
                break;
            case 2:
                monthName = "Februari";
                jumDay = "29";
                break;
            case 3:
                monthName = "March";
                jumDay = " 31";
                break;
            case 4:
                monthName = "April";
                jumDay = "30";
                break;
            case 5:
                monthName = "May";
                jumDay = "31";
                break;
            case 6:
                monthName = "June";
                jumDay = "30";
                break;
            case 7:
                monthName = "July";
                jumDay = "31";
                break;
            case 8:
                monthName = "August";
                jumDay = "30";
                break;
            case 9:
                monthName = "September";
                jumDay = "31";
                break;
            case 10:
                monthName = "Oktober";
                jumDay = "31";
                break;
            case 11:
                monthName = "November";
                jumDay = "30";
                break;
            case 12:
                monthName = "Desember";
                jumDay = "31";
                break;
            default:
                monthName = "Invalid month number";
                jumDay = "Invalid Day number";
                break;
        }
        Console.WriteLine("Month name: " + monthName);
        Console.WriteLine("Jum day: " + jumDay);
        if (monthNumber % 2 == 0)
        {
            Console.WriteLine($"{monthNumber} adalah bulan genap.");
        }
        else
        {
            Console.WriteLine($"{monthNumber} adalah bulan ganjil.");
        }
    }
}