using System;
using static Bank_main.filehandling;

namespace Bank_main
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bank_Emp_methods methods_calling = new Bank_Emp_methods();
            //methods_calling.invoke_bankdetails();


            //Employee_details empdetails = new Employee_details();
            //empdetails.details();
            login ldetails = new login();
            ldetails.login_check();
            Console.ReadKey();
        }
    }
}
