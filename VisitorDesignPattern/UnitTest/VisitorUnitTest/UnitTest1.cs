using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisitorDesignPattern.Models;

namespace VisitorUnitTest
{
    [TestClass]
    public class VisitorUnitTest
    {
        [TestMethod]
        public void TestMethodSalaryManagerCalculator()
        {
            //arrange
            IElement manager = new Manager();
            

            var fine = new FinancialSystem();
            fine.Attach(manager);
           

            //act
            var salareis = fine.Accept(new SalaryCalculator());            


            //expect
            Assert.AreEqual(135000, salareis[0]);
            
        }
        [TestMethod]
        public void TestMethodSalaryEmploeeCalculator()
        {
            //arrange           
            IElement employee = new Employee();            

            var fine = new FinancialSystem();
            fine.Attach(employee);

            //act
            var salareis = fine.Accept(new SalaryCalculator());


            //expect
           Assert.AreEqual(135000, salareis[0]);
        }
        [TestMethod]
        public void TestMethodSalaryWorkerCalculator()
        {
            //arrange           
            IElement employee = new Worker();

            var fine = new FinancialSystem();
            fine.Attach(employee);

            //act
            var salareis = fine.Accept(new SalaryCalculator());


            //expect
            Assert.AreEqual(135000, salareis[0]);
        }

        [TestMethod]
        public void TestMethodWageCalculator()
        {
            //arrange
            IElement manager = new Manager();
            IElement employee = new Employee();
            IElement worker = new Worker();

            var fine = new FinancialSystem();
            fine.Attach(manager);
            fine.Attach(employee);
            fine.Attach(worker);

            //act
            var Ezafe = fine.Accept(new WageCalculator());


            //expect
            Assert.AreEqual(360000, Ezafe[0]);
        }
    }
}
