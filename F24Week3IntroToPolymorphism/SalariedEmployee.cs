using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToPolymorphism
{
    public class SalariedEmployee : Employee
    {
        public double Salary { get; set; }

        public SalariedEmployee(int id, string name, double salary) : base(id, name)
        {
            Salary = salary;
        }

        public override double Earnings()
        {
            return Salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary = {Salary:C}\n";
        }
    }
}
