using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorDesignPattern.Models;

namespace VisitorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Is Sample For Visitor Pattern");
            IElement manager = new Manager();
            IElement employee = new Employee();
            IElement worker = new Worker();

            var fine = new FinancialSystem();
            fine.Attach(manager);
            fine.Attach(employee);
            fine.Attach(worker);

            Console.WriteLine(Environment.NewLine
                + Environment.NewLine
                + "------ hoghoogh -----");
            fine.Accept(new SalaryCalculator());

            Console.WriteLine(Environment.NewLine
                + Environment.NewLine
                + "------ ezafe kar -----");
            fine.Accept(new WageCalculator());

            Console.ReadKey();
        }
    }
}
