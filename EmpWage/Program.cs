using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here Emp means Employee
            int EmpPresent = 1;

            //UC1 Finding Employee Present or Absent by using Random class
            //Creating object or instance of Random class
            Random random = new Random();

            //For random values useing Next() method
            int EmpInput = random.Next(0, 2);
            if (EmpInput == EmpPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.Read();
        }
    }
}
