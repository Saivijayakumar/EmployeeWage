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
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("Airtel", 20, 4, 10);
            empWageBuilder.addCompanyEmpWage("Idea", 15, 7, 20);
            empWageBuilder.computeEmpWage();
            
            Console.Read();
        }
    }
}
