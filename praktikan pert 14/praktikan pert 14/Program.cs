using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Sarah Nurul Yakin", 1000);
            Console.WriteLine($"Akun {account.Number} dibuat untuk {account.Owner} dengan saldo awal {account.Balance}.");

            account.MakeWithdrawal(500, DateTime.Now, "Pembayaran sewa");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Teman membayar hutang");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
public class Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }
}
public class BankAccount
{
    private static int s_accountNumberSeed = 1234567890;
    private List<Transaction> _allTransactions = new List<Transaction>();

    public string Number { get; private set; }
    public string Owner { get; set; }
    public decimal Balance
    {
        get
        {
            decimal balance = 0;
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
            }
            return balance;
        }
    }

    public BankAccount(string name, decimal initialBalance)
    {
        Number = s_accountNumberSeed.ToString();
        s_accountNumberSeed++;
        Owner = name;
        MakeDeposit(initialBalance, DateTime.Now, "Saldo awal");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Jumlah deposit harus positif");
        }
        var deposit = new Transaction(amount, date, note);
        _allTransactions.Add(deposit);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "Jumlah penarikan harus positif");
        }
        if (Balance - amount < 0)
        {
            throw new InvalidOperationException("Dana tidak cukup untuk penarikan ini");
        }
        var withdrawal = new Transaction(-amount, date, note);
        _allTransactions.Add(withdrawal);
    }

    public string GetAccountHistory()
    {
        var report = new System.Text.StringBuilder();
        decimal balance = 0;
        report.AppendLine("Tanggal\t\tJumlah\tSaldo\tCatatan");
        foreach (var item in _allTransactions)
        {
            balance += item.Amount;
            report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
        }
        return report.ToString();
    }
}