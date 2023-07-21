using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcNunitEx1Day10
{
    [TestFixture]
    public class CalcTestClass
    {
        Calc calc=new Calc();
        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(10, calc.Add(6, 4));
        }
        [Test]
        public void TestSub()
        {
            Assert.AreEqual(2, calc.Sub(6, 4));
        }
        [Test]
        public void TestMulti()
        {
            Assert.AreEqual(24, calc.Multi(6, 4));
        }
        [Test]
        public void TestDiv()
        {
            Assert.AreEqual(4, calc.Div(16, 4));
        }
        [Test]
        public void TestDivException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Div(5, 0));
        }
        [Test]
        public void TestPrime()
        {
            Assert.AreEqual(true, calc.IsPrime(5));
        }
    }
}
