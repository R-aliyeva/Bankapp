using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unibank unibank = new Unibank();
            unibank.Balance = 100;
            unibank.Cashin(10);
            unibank.Cashout(5);
            AccessBank accessBank = new AccessBank();
            accessBank.Balance = 200;
            accessBank.Cashout(30);
            accessBank.Cashin(15);
            PashaBank pashaBank = new PashaBank();
            pashaBank.Balance = 300;
            pashaBank.Cashout(5);
            pashaBank.Cashin(20);
            LeoBank leoBank = new LeoBank();
            leoBank.Balance = 400;
            leoBank.Cashout(5);
            leoBank.Cashin(30);
            

        }
    }
    public abstract class Bank 
        {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? CardNumber 
        {
            get 
            {
                return this.CardNumber;
            
            }


            set {
                if (value.Length == 16)
                {

                }
                else
                {
                    Console.WriteLine("CardNumber must be 16 numbers");
                }
            } }
        public int Cvv { get; set; }
        public double Balance { get; set; }
        public abstract void Cashin(double bl);
        public abstract void Cashout(double bl);

        }
    public class Unibank : Bank 
    
    {
        public override void Cashin(double bl)
        {
            
            // Console.WriteLine("Unibank cash in implemented");

        }
        public override void Cashout(double bl)
        {
            Balance = (Balance - bl - bl * 1.5 / 100);
            Console.WriteLine(Balance);
            //Console.WriteLine("Unibank cashout implemented");
        }


    }
    public class AccessBank : Bank 
    {
        public override void Cashin(double bl)
        {
            Balance = (Balance + bl - bl * 0.3 / 100);
            Console.WriteLine(Balance);
        }
        public override void Cashout(double bl)
        {
            Balance = (Balance - bl - bl * 1.6 / 100);
            Console.WriteLine(Balance);
        }

    }
    public class PashaBank : Bank 
    
    {
        public override void Cashin(double bl)
        {
            Balance = (Balance + bl - bl * 0.6 / 100);
            Console.WriteLine(Balance);
        }
        public override void Cashout(double bl)
        {
            Balance = (Balance - bl - bl * 1.1 / 100);
            Console.WriteLine(Balance);
        }


    }
    public class LeoBank : Bank 
    {

        public override void Cashin(double bl)
        {
            Balance += bl;
            Console.WriteLine(Balance);
        }
        public override void Cashout(double bl)
        {
            Balance -= bl;
            Console.WriteLine(Balance);
        }


    }
}