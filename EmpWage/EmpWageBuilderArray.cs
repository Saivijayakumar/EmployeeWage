using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    //Using Interface concept
    public interface IEmpWageBuilderArray
    {
        void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
    }

    class EmpWageBuilderArray : IEmpWageBuilderArray
    {
        //Initializing Constant Values
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        
        //creating an array list
        public ArrayList companyEmpwage;

        public EmpWageBuilderArray()
        {
            //giving count
            this.companyEmpwage = new ArrayList();
        }
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //every index is object
            CompanyEmpWage obj = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpwage.Add(obj);
            
        }
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage wage in companyEmpwage)
            {
                wage.setTotalEmpWage(this.computeEmpWage(wage));
                wage.allDetails();
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            //Variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                //int empCheck = 1;
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
                if(empCheck != 0)
                {
                    totalWorkingDays++;
                }
                totalEmpHrs += empHrs;
                //Console.WriteLine("Day#: " + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
            //Console.WriteLine("Total Emp Wage for company : " + company + " is: " + totalEmpWage);
        }
    }

}