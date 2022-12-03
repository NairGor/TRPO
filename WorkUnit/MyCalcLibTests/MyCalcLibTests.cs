using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class MyCalcLibTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            //arrange
            int x = 10, y = 20;
            int expected = 30;

            //act
            MyCalcLibb c = new MyCalcLibb();
            int actual = c.Sum(x, y);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
