using Microsoft.VisualStudio.TestTools.UnitTesting;
using libMBIN;
using System;

namespace MBINCompilerTests
{

    [TestClass]
    public class IntRevTests
    {

        [TestMethod]
        public void TestIntRevFromBytes()
        {
            float[] actualValue = INT_2_10_10_10_REV.FromBytes(1592787842);
            float[] expectedValue = new float[4] { -0.24667928063493072f, 0.0f, 0.9690971739229421f, 1.0f };

            // accommodate floating-point inaccuracies
            bool pass = true;
            pass &= Math.Abs( expectedValue[0] - actualValue[0] ) <= 1e-7f;
            pass &= Math.Abs( expectedValue[1] - actualValue[1] ) <= 1e-7f;
            pass &= Math.Abs( expectedValue[2] - actualValue[2] ) <= 1e-7f;
            pass &= Math.Abs( expectedValue[3] - actualValue[3] ) <= 1e-7f;

            Assert.IsTrue( pass,
                $"Assert Failed: Expected " +
                $"[{expectedValue[0]}, {expectedValue[1]}, {expectedValue[2]}, {expectedValue[3]}]" +
                $" but got " +
                $"[{actualValue[0]}, {actualValue[1]}, {actualValue[2]}, {actualValue[3]}]" );
        }

        [TestMethod]
        public void TestIntRevFromVerts()
        {
            int actualValue = INT_2_10_10_10_REV.FromVerts(new float[4] { -0.24667928063493072f, 0.0f, 0.9690971739229421f, 1.0f });
            int expectedValue = 1592787842;
            Assert.AreEqual( expectedValue, actualValue, $"Assert Failed: Expected [{expectedValue}] but got [{actualValue}]" );
        }
    }
}