
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14;

namespace ConsoleApp14.Test
{
    internal class SpesialOffersTests
    {
        [TestCase(58, 2, 2000,     0)]
        [TestCase(61, 2, 5000,     1)]
        [TestCase(44, 4, 2500,     1)]
        [TestCase(36, 1, 450000,   1)]
        [TestCase(65, 5, 500000,   1)]
        [TestCase(70, 6, 4500,     1)]
        [TestCase(66, 2, 650000,   1)]
        [TestCase(31, 8, 850000,   1)]
        public void CheckingValueTests (int age, int service, int sum, int expected)
        {
            int actual = SpesialOffers.CheckingValue(age,service,sum);
            Assert.AreEqual(expected,actual);
        }
    }

}





