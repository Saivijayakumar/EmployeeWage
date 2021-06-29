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
        static void Main(string[] args)
        {
            //Here Emp means Employee
            int EmpHours = 0;
            int EmpWage = 0;

            //UC1 Finding Employee Present or Absent by using Random class
            //Creating object or instance of Random class
            Random random = new Random();

            //For random values useing Next() method
            int EmpInput = random.Next(0, 3);
            //UC4 Using switch case satement
            switch (EmpInput)
            {
                case FULL_TIME:
                    Console.WriteLine("FullTime Employee");
                    EmpHours = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("PartTime Employee");
                    EmpHours = 4;
                    break;
                default:
                    Console.WriteLine("Employee Absent");
                    EmpHours = 0;
                    break;
            }
            //Applying formula for finding out employee salary
            EmpWage = EMP_RATE_PER_HR * EmpHours;
            Console.WriteLine("Employee wage per day =" + EmpWage);
            Console.Read();
        }
    }
}
