using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14;

namespace ConsoleApp14.Test
{
    internal class CoutingBanknotesTests
    {
        [TestCase(2800, 6)]
        [TestCase(3500, 4)]
        [TestCase(4900, 9)]
        [TestCase(800,  4)]

        public void CountResultTests (int n, int expected)
        {
            int actual = CoutingBanknotes.CountResult(n);  
            Assert.AreEqual(expected, actual);

        }

    }
}
