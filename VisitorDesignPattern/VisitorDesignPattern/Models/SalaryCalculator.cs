using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorDesignPattern.Models
{
    public class SalaryCalculator:IElementVisitor
    {
        
        public int Visit(Manager manager)
        {
            return NewMethod(manager, 10000, 25000, 20000, 5000);

        }

        public int Visit(Employee employee)
        {
            return NewMethod(employee, 7000, 15000, 10000, 6000);
        }

        public int Visit(Worker worker)
        {
            return NewMethod(worker, 6000, 5000, 2000, 7000);

        }

        private static int NewMethod(IElement element, int WorkingHour, int Wife, int Children, int OffDays)
        {
            var salary = element.WorkingHour * WorkingHour;
            salary += element.Wife * Wife;
            salary += element.Children * Children;
            salary -= element.OffDays * OffDays;
            Console.WriteLine($"{element.GetType().Name}'s Salary is " + salary);
            return salary;
        }
    }

    
}