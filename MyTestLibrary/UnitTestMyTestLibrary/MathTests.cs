using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyTestLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestLibrary.Tests
{
    [TestClass()]
    public class MathTests
    {
        [TestMethod()]
        public void SumaTest()
        {
            Math myMath = new Math();

            int a = 3;
            int b = 8;

            int resultExpected = 11;

            int c = myMath.Suma(a, b);

            Assert.IsTrue(c == resultExpected);
        }
    }
}