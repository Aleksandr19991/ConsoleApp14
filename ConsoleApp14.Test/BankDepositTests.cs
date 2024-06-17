using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Test
{
    internal class BankDepositTests
    {
        [TestCase(1000, 1, 10, 1100)]
        [TestCase(1000, 2, 10, 1210)]
        [TestCase(1000, 3, 10, 1320)]
        [TestCase(1000, 4, 10, 1430)]

        public void CoutingSavingTest(int amount, int year, int percent, int expected)
        {
            int actual = BankDeposit.CoutingSaving(amount, year, percent);   
            Assert.AreEqual(expected,actual);

        }
    
    }

}


