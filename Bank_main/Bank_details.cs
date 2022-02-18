using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_main
{
    public sealed class  Bank_details
    {
        public static string bankname, bankcode, bankaddress, bankbranch, bankifsc;
        Employee_details empdetails = new Employee_details();

        public void details()
        {
            Console.WriteLine("Please Enter the Bank details");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter Bank Name:");
            bankname = Console.ReadLine();
            Console.WriteLine("Enter Bank Code:");
            bankcode = Console.ReadLine();
            Console.WriteLine("Enter Bank Address:");
            bankaddress = Console.ReadLine();
            Console.WriteLine("Enter Bank Branch:");
            bankbranch = Console.ReadLine();
            Console.WriteLine("Enter Bank IFSC Code:");
            bankifsc = Console.ReadLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("The entered Bank details are:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("The Bank Name:" + bankname);
            Console.WriteLine("The Bank Code:" + bankcode);
            Console.WriteLine("The Bank Address:" + bankaddress);
            Console.WriteLine("The Bank Branch:" + bankbranch);
            Console.WriteLine("The Bank IFSC Code:" + bankifsc);
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Please Enter Employee details:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            empdetails.details();
        }
    }

}
