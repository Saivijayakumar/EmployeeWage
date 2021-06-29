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
        public const int MAX_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            //Here Emp means Employee
            int EmpHours = 0;
            int EmpWage = 0;
            int TotalWage = 0;
            int WrorkingDays = 1;
            int WorkingHrs = 0;

            //Creating object or instance of Random class
            Random random = new Random();
            //UC6 Calculating wages till total working hours or days is reached for a month
            while (WrorkingDays <= MAX_WORKING_DAYS && WorkingHrs <= MAX_WORKING_HRS)
            {
                //For random values useing Next() method
                int EmpInput = random.Next(0, 3);
                //Selection satement
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
                WorkingHrs += EmpHours;
                TotalWage += EmpWage;
                if (EmpInput != 0)
                {
                    WrorkingDays++;
                }
            }
            Console.WriteLine("WorkingHrs = "+WorkingHrs+" Working days ="+WrorkingDays);
            Console.WriteLine("Employee wage for " + MAX_WORKING_DAYS + "days = " + TotalWage);
            Console.Read();
        }
    }
}
