using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_main
{
    class InvaliddataException : Exception
    {
        public InvaliddataException() { }
        public InvaliddataException(string error) : base(String.Format("Please check the error: {0}", error))
        {

        }
    }
    public class login
    {
        public string name, password;
        public void login_check()
        {
            try
            {
                Console.WriteLine("Select Type of user");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Admin/Bank Employee");
                Console.WriteLine("2.Customer");
                Console.WriteLine("3.Exit");
                Console.Write("Select from(1-3):");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Please Enter your Login details");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("Enter User Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter User Password:");
                        password = Console.ReadLine();
                        if (name == "admin" && password == "1234")
                        {
                            Console.WriteLine("Welcome:" + name);
                            Console.WriteLine("----------------------------");
                            Bank_details bdetails = new Bank_details();
                            bdetails.details();
                        }
                        else
                        {
                            Console.WriteLine("Please Enter valid Login details");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Please Enter your Login details");
                            Console.WriteLine("----------------------------");
                            Console.WriteLine("Enter User Name:");
                            name = Console.ReadLine();

                            Console.WriteLine("Enter User Password:");
                            password = Console.ReadLine();
                            if (name == "admin" && password == "1234")
                            {
                                Console.WriteLine("Welcome:" + name);
                                Bank_details bdetails = new Bank_details();
                                bdetails.details();
                            }
                            else
                            {
                                Console.WriteLine("Please Enter valid Login details");
                            }
                        }
                        break;
                    case 2:
                        Bank_type bt = new Bank_type();
                        bt.display_bank();
                        bt.display_bank1();
                        break;
                    case 3:
                        Console.WriteLine("-----------------------------");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid details");
                        break;
                }
            }
            catch (InvaliddataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
