using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bank_main
{
    public delegate void CalSalary_emp(double days);
    public delegate void CalSalary_mgr(double NumberOfOverTime,double OvertimeRate,double Bonus);
    
    public class Employee_details
    {
        List<emp_collectionsdisplay> employees = new List<emp_collectionsdisplay>();
        public string name, age, address, contact, email, fname, mname;
        public static double salary, No_days;
        public double NumberOfOverTime, OvertimeRate, Bonus;
        public static int empID;
        public string filepath = "D:\\Employee.txt";

        //class for exception handling
        class InvaliddataException : Exception
        {
            public InvaliddataException() { }

            public InvaliddataException(string error) : base(String.Format("Please check the error: {0}", error))
            {

            }
        }
        public class emp_collectionsdisplay
        {
            public int empID { get; set; }
            public string name { get; set; }
            public string age { get; set; }
            public string address { get; set; }
            public string contact { get; set; }
            public string email { get; set; }
            public string fname { get; set; }
            public string mname { get; set; }
            public string salary { get; set; }
            public string SalaryManager { get; set; }

        }

        //fetch emp details
        public void details()
        {
            int i, n = 0;
            Console.WriteLine("Please Enter number of customers:");
            n = Convert.ToInt16(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine("Please Enter the details");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter Employee ID:");
                empID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter Age:");
                age = Console.ReadLine();
                Console.WriteLine("Enter Address:");
                address = Console.ReadLine();
                Console.WriteLine("Enter Contact Information:");
                contact = Console.ReadLine();
                Console.WriteLine("Enter email:");
                email = Console.ReadLine();
                Console.WriteLine("Enter Father's Name:");
                fname = Console.ReadLine();
                Console.WriteLine("Enter Mother's Name:");
                mname = Console.ReadLine();
                Console.WriteLine("Enter Salary:");
                salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-----------------------");
                Console.WriteLine("The entered Employee details are:");
                Console.WriteLine("-----------------------");
                Console.WriteLine("The ID:" + empID);
                Console.WriteLine("The Name:" + name);
                Console.WriteLine("The Age:" + age);
                Console.WriteLine("The Address:" + address);
                Console.WriteLine("The Email:" + email);
                Console.WriteLine("The Contact Info:" + contact);
                Console.WriteLine("The Father's Name:" + fname);
                Console.WriteLine("The Mother's Name:" + mname);
                Console.WriteLine("Your Salary:" + salary);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Enter Number of days worked:");
                Console.WriteLine("-----------------------");
                No_days = Convert.ToDouble(Console.ReadLine());
                CalculateEmpSalary(No_days);
                display1();
            }
            displayempdetails_id(employees);
        }

        //search employee by ID
        public void displayempdetails_id(List<emp_collectionsdisplay> employees)
        {
            try
            {
                Console.WriteLine("Search by Employee ID:");
                Console.WriteLine("-----------------------");
                Console.WriteLine("Please Enter Employee ID:");
                empID = Convert.ToInt32(Console.ReadLine());
                if (employees.Count > 0)
                {
                    var empdetails = employees.Where(x => x.empID == empID).ToList();
                    if (empdetails != null)
                    {
                        List<emp_collectionsdisplay> details_ID = new List<emp_collectionsdisplay>();

                        details_ID.Add(empdetails[0]);
                        displayby_ID(details_ID);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        //display employees by ID
        public void displayby_ID(List<emp_collectionsdisplay> employees)
        {
            emp_collectionsdisplay emp = employees[0];
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Employee Details by ID:");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID ||Name         || Age ||    Address  ||    Contact||    Email        || Father's Name    || Mother's Name   ||  Salary");
            employees.Add(new emp_collectionsdisplay { empID = empID, name = name, age = age, address = address, contact = contact, email = email, fname = fname, mname = mname, salary = Convert.ToDouble(salary).ToString() });
            
                Console.WriteLine(emp.empID + " " + emp.name + "           " + emp.age + "           " + emp.address + "         " + emp.contact + "     " + emp.email + "       " + emp.fname + "         " + emp.mname + "          " + emp.salary);
        }

        //calculate emp salary
        public void CalculateEmpSalary(double days)
        {
            salary = salary * No_days;
            Console.WriteLine("---------------------------");
        }

        //display employee details and download the same to text file
        public void display1()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Employee Details:");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("ID ||Name         || Age ||    Address  ||    Contact||    Email        || Father's Name    || Mother's Name   ||  Salary");
            employees.Add(new emp_collectionsdisplay { empID = empID, name = name, age = age, address = address, contact = contact, email = email, fname = fname, mname = mname, salary = Convert.ToDouble(salary).ToString() });
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach (emp_collectionsdisplay e in employees)
                    {
                        sw.WriteLine(e.empID + " " + e.name + "           " + e.age + "           " + e.address + "         " + e.contact + "     " + e.email + "       " + e.fname + "         " + e.mname + "          " + e.salary);
                        Console.WriteLine(e.empID + " " + e.name + "           " + e.age + "           " + e.address + "         " + e.contact + "     " + e.email + "       " + e.fname + "         " + e.mname + "          " + e.salary);
                    }
                }
            }
            catch (InvaliddataException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    //Inherited from details class
    class Manager : Employee_details
    {
        //Salary calculation for Manager
        public void CalculateSalaryManager(double NumberOfOverTime, double OvertimeRate, double Bonus)
        {
            Console.WriteLine("Enter Number of Overtime :");
            NumberOfOverTime = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number of OvertimeRate:");
            OvertimeRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Bonus:");
            Bonus = Convert.ToDouble(Console.ReadLine());
            salary = salary + NumberOfOverTime * OvertimeRate + Bonus;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Your monthly salary is:" + salary);
        }
    }
}
