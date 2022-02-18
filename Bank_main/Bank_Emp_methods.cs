using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_main
{
    public class Bank_Emp_methods
    {
       public static double days;
        public static double NumberOfOverTime, OvertimeRate, Bonus;
        Manager cal_emp = new Manager();//down casting

        public void invoke_bankdetails()
        {
            try
            {
                Console.WriteLine("Select type of Operation to be Performed");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1.Enter Employee details");
                Console.WriteLine("2.Enter Manager details");
                Console.WriteLine("3.Enter Bank details");
                Console.WriteLine("4.Exit");
                Console.Write("Select from(1-4):");
                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("-----------------------------");
                        cal_emp.details();
                        CalSalary_emp calculate1 = new CalSalary_emp(cal_emp.CalculateEmpSalary);
                        calculate1.Invoke(days);

                        break;
                    case 2:
                        Console.WriteLine("----------------------------------");
                        cal_emp.details();
                        CalSalary_mgr calculat21 = new CalSalary_mgr(cal_emp.CalculateSalaryManager);
                        calculat21.Invoke(NumberOfOverTime, OvertimeRate, Bonus);
                        break;
                    case 3:
                        Console.WriteLine("-----------------------------");
                        Bank_details bdetails = new Bank_details();
                        bdetails.details();
                        break;
                    case 4:
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

    }
}
