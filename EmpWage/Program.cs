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
            EmpWageBuilderObject airtel = new EmpWageBuilderObject("Airtel", 20, 4, 10);
            EmpWageBuilderObject idea = new EmpWageBuilderObject("Idea", 10, 5, 30);
            airtel.computeEmpWage();
            Console.WriteLine(airtel.toString());
            idea.computeEmpWage();
            Console.WriteLine(idea.toString());
            Console.Read();
        }
    }
}
