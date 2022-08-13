using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorDesignPattern.Models
{
    public class WageCalculator:IElementVisitor
    {
        public int Visit(Manager manager)
        {
            var wage = manager.OverHours*30000;
            Console.WriteLine("Employee's wage is " + wage);
            return wage;
        }

        public int Visit(Employee employee)
        {
            var wage = employee.OverHours * 20000;
            Console.WriteLine("Employee's wage is " + wage);
            return wage;
        }

        public int  Visit(Worker worker)
        {
            var wage = worker.OverHours * 15000;
            Console.WriteLine("Employee's wage is " + wage);
            return wage;
        }
    }
}