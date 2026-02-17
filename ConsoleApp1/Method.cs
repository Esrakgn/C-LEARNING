using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    internal class Method
    {
    }
}

//----METHODS----


/*
class Person
{
    public void Speak()
    {
        Console.WriteLine("Hello!");
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person(); 
        p.Speak();              
    }
}
*/

/*
//DEĞER DÖNDÜREN METOD

class Calculator
{
    public int Add(int a,int b) 
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        int result = c.Add(5, 10);
        Console.WriteLine(result);
    }
}
*/


/*

//----PARAMETRE ALAN METOD----

class Person
{
    public void Speak(string name)
    {
        Console.WriteLine("Hello " + name);
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Speak("Esra");
    }
}


*/

/*
// ----STATİC CLASS METHOD----

class MyMethod
{
    public static void Print()
    {
        Console.WriteLine("Hello staticc method!");
    }

}
class Program
{
    static void Main()
    {
        MyMethod.Print();
    }
}

*/


 /*

// ----ORNEK BANKA UYGULAMASI----

class BankAccount
{
    public string OwnerName;  //Hesap bilgileri
    public decimal Balance;

    public void Deposit(decimal amount)  // hesaba para yatırma
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        Balance += amount;
        Console.WriteLine($"Deposited: {amount} New Balance: {Balance}");
    }


    public void Withdraw(decimal amount) // hesaptan para çekme
    {
        if (amount <= 0)
        {
            {

                Console.WriteLine("Withdraw amount must be positive");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance ");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Owner: {OwnerName} Balance: {Balance}");

        } }


        public void ShowInfo()
    {
        Console.WriteLine($"Owner: {OwnerName}  Balance: {Balance}");
    }
  }

class Program
{
    static void Main()
    {
        BankAccount accnt = new BankAccount();
        accnt.OwnerName = "Esra";
        accnt.Balance = 1000;
        accnt.ShowInfo();
        accnt.Deposit(500m);
        accnt.Withdraw(700m);
        accnt.Withdraw(2000m);

        accnt.ShowInfo();
    }

}
       

*/


