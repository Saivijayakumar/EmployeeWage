using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Program
    {
        //It is require for UC4
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HR = 20;
        public const int WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            //Here Emp means Employee
            int EmpHours = 0;
            int EmpWage = 0;
            int TotalWage = 0;

            //Creating object or instance of Random class
            Random random = new Random();

            //UC5 Calucating wages per month(20days)
            for (int day = 1; day <= WORKING_DAYS; day++)
            {
                //For random values useing Next() method
                int EmpInput = random.Next(0, 3);
                //UC4 Using switch case satement
                switch (EmpInput)
                {
                    case FULL_TIME:
                        EmpHours = 8;
                        break;
                    case PART_TIME:
                        EmpHours = 4;
                        break;
                    default:
                        EmpHours = 0;
                        break;
                }
                //Applying formula for finding out employee salary
                EmpWage = EMP_RATE_PER_HR * EmpHours;
                TotalWage += EmpWage;
            }
            Console.WriteLine("Employee wage for " + WORKING_DAYS + "days = " + TotalWage);
            Console.Read();
        }
    }
}
