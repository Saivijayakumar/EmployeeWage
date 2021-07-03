using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Program
    {
<<<<<<< HEAD
        //It is require for UC4
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;

        public static void ComputingEmpWage()
        {
            //Here Emp means Employee
            int EmpHours = 0;
            int EmpWage = 0;
            int TotalWage = 0;
            int WrorkingDays = 1;
            int WorkingHrs = 0;
=======
        //Initializing Constant Values
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
>>>>>>> UC8-MultipleCompanies

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays,int maxHoursPerMonth)
        {
            //Local Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
            }
<<<<<<< HEAD
            Console.WriteLine("WorkingHrs = " + WorkingHrs + " Working days =" + WrorkingDays);
            Console.WriteLine("Employee wage for " + MAX_WORKING_DAYS + "days = " + TotalWage);
=======
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for company : " + company + "is: " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            computeEmpWage("Airtel",20,4,10);
            computeEmpWage("Idea", 10, 4, 30);
>>>>>>> UC8-MultipleCompanies
            Console.Read();
        }
        static void Main(string[] args)
        {
            ComputingEmpWage();
        }
    }
}
