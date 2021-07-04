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
            EmpWageBuilderObject idea = new EmpWageBuilderObject("Idea", 15, 7, 20);
            //calling computeEmpWage method
            airtel.computeEmpWage();
            //displaying particular company details
            airtel.allDetails();
            //calling computeEmpWage method
            idea.computeEmpWage();
            //displaying particular company details
            idea.allDetails();
            
            Console.Read();
        }
    }
}
