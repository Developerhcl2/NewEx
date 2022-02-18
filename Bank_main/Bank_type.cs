using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_main
{
    public class Bank_type
    {
        public static int amt, result, transactions = 0;
        public static int savings = 100000, current = 200000, child = 50000;
        public static string name, address, contact, address_proof;
        Add_amount delex = new Add_amount();
        List<emp_collectionsdisplay> employees = new List<emp_collectionsdisplay>();
        int i, n = 0;

        //class for exception handling
        class InvaliddataException : Exception
        {
            public InvaliddataException() { }

            public InvaliddataException(string error): base(String.Format("Please check the error: {0}", error))
            {

            }
        }
        public class emp_collectionsdisplay
            {
            public string name { get; set; }
            public string address { get; set; }
            public string contact { get; set; }
            public string address_proof { get; set; }
            public int amt { get; set; }

        }
        public void check_dailylimit()
        {
            Console.WriteLine("Please Enter number of customers:");
            n = Convert.ToInt16(Console.ReadLine());
            for (i=0;i<=n;i++)
            {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your Address:");
            address = Console.ReadLine();
            Console.WriteLine("Please Enter your Contact Information:");
            contact = Console.ReadLine();
            Console.WriteLine("Please select Address Proof Type:");
            address_proof = Console.ReadLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Your Entered Details are");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Address:" + address);
            Console.WriteLine("Contact Information:" + contact);
            Console.WriteLine("Address Proof:" + address_proof);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the amount to be deposited");
            Console.WriteLine("----------------------------");
            amt = Convert.ToInt32(Console.ReadLine());

            if (amt > 100000 || amt > 200000 || amt > 50000)
            {
                Console.WriteLine("The amount is exeeding your daily limit");
            }
            else
            {
                transactions++;
                AddDelegate del1 = new AddDelegate(Add_amount.Add);
                del1.Invoke(amt);
                Console.WriteLine("The amount deposited by" + name + "is," +amt);
                }
            }
            
        }

        //code to enter the customer details
        public void customer_details()
        {
            employees.Add(new emp_collectionsdisplay { name = name, address = address, contact = contact, address_proof = address_proof, amt = amt });
            Console.WriteLine("Name        ||    Address    ||    Contact     ||    Address_proof    || Amount ");
            foreach (emp_collectionsdisplay e in employees)
            {
                Console.WriteLine(e.name + "         " + e.address + "         " + e.contact + "       " + e.address_proof + "      " + e.amt);
            }
        }

        //code to deposit the amt
        public void daily_deposit()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the amount to be deposited");
            Console.WriteLine("----------------------------");
            amt = Convert.ToInt32(Console.ReadLine());

            if (amt > 100000 || amt > 200000 || amt > 50000)
            {
                Console.WriteLine("The amount is exeeding your daily limit");
            }
            else
            {
                transactions++;
                AddDelegate del1 = new AddDelegate(Add_amount.Add);
                del1.Invoke(amt);
                Console.WriteLine("The amount deposited successfully");
            }

        }

        //code to withdraw the amt
        public void daily_withdrawt()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Please enter the amount to be withdrawn");
            Console.WriteLine("----------------------------");
            amt = Convert.ToInt32(Console.ReadLine());

            if (amt > 100000 || amt > 200000 || amt > 50000)
            {
                Console.WriteLine("The amount is exeeding your daily limit");
            }
            else
            {
                transactions++;
                AddDelegate del1 = new AddDelegate(Add_amount.Withdraw);
                del1.Invoke(amt);
                Console.WriteLine("The amount withdrawn is:" +amt);
            }
        }
        public void display_bank()
        {
            try
            {
                Console.WriteLine("Select Bank type");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Savings Account");
                Console.WriteLine("2.Current Account");
                Console.WriteLine("3.Child Account");
                Console.WriteLine("4.View Customer Details");
                Console.WriteLine("5.Exit");
                Console.Write("Select from(1-5):");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("You have selected bank type: Savings Account");
                        Console.WriteLine("Your Account limit is INR 1,00,000 ");
                        check_dailylimit();
                        num_transactions();
                        break;
                    case 2:
                        Console.WriteLine("You have selected bank type: Current Account");
                        Console.WriteLine("Your Account limit is INR 2,00,000 ");
                        check_dailylimit();
                        break;
                    case 3:
                        Console.WriteLine("You have selected bank type: Child Account");
                        Console.WriteLine("Your Account limit is INR 50,000 ");
                        check_dailylimit();
                        break;
                    case 4:
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Bank Customer Details");
                        check_dailylimit();
                        break;
                    case 5:
                        Console.WriteLine("-----------------------------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Bank type");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //code to select the transaction type
        public void display_bank1()
        {
            try
            {
                Console.WriteLine("Select type");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Check Balance");
                Console.WriteLine("4.Main menu");
                Console.WriteLine("5.Exit");
                Console.Write("Select from(1-5):");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Your Account limit is INR 1,00,000 ");
                        daily_deposit();
                        num_transactions();
                        break;
                    case 2:
                        Console.WriteLine("Your Account limit is INR 2,00,000 ");
                        daily_withdrawt();
                        num_transactions();
                        break;
                    case 3:
                        Console.WriteLine("Your balance is", + amt);
                        break;
                    case 4:
                        display_extra();
                        break;
                    case 5:
                        Console.WriteLine("-----------------------------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Bank type");
                        break;
                }
                display_extra();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void display_extra()
        {
            try
            {
                Console.WriteLine("Do you want to continue");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");

                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        display_bank1();
                        break;
                    case 2:
                        Console.WriteLine("Thank you for visiting us.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("We are happy to serve you.");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //code to check the daily transsactions
        public void num_transactions()
        {
            try
            {
                if (transactions == 3)
                {
                    Console.WriteLine("You exceeded the daily limit of transactions per day");
                    AddDelegate del1 = new AddDelegate(Add_amount.Withdraw);
                    del1.Invoke(500);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
