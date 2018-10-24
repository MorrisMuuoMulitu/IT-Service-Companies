using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItServiceCompany
{
    class Employee
    {
        //properties
        public string Name { get; private set; }
        public int BirthYear { get; private set; }
        public static int AnnualSuppPayment { get; set; }
        public static int BaseSalary { get; set; }
        public static int CurrentYear { get; set; }
        //constructor
        public Employee(string name,int birthYear)
        {
            this.Name = name;
            this.BirthYear = birthYear;
        }
        //methods
        public int Age()
        {
            return CurrentYear - BirthYear;
        }
        private int Age_allowance()
        {
            return Age() * AnnualSuppPayment;
        }
        public virtual int Income()
        {
            return BaseSalary + Age_allowance();
        }
        public override string ToString()
        {
            return "\nThe " + this.GetType().Name.ToLower() + " name is: " + Name;
        }
    }
}
