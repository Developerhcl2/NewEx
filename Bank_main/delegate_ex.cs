using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_main
{
    public delegate void AddDelegate(int amount);

   public class Add_amount
    {
       public static int balance;
        public static void Add(int x)
        {
            Console.WriteLine("The amount deposited is : " + (x));
            balance += x;
            Console.WriteLine("Your remaining balance is:" + balance);
        }
        public static void Withdraw(int x)
        {
            Console.WriteLine("The amount to be withdrawn is : " + (x));
            balance -= x;
            Console.WriteLine("Your remaining balance is:" + balance);
        }
    }
}
