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
            empWageBuilder.addCompanyEmpWage("Airtel", 20, 6, 100);
            empWageBuilder.addCompanyEmpWage("Idea", 20, 5, 100);
            empWageBuilder.computeEmpWage();
            
            Console.Read();
        }
    }
}
