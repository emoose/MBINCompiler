using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace libMBIN.UnitTests {

    [TestClass]
    public class FloatingPointTests {

        // These tests are proofs and examples of lossy and lossless round-trip serialization of floating point values to and from string values.
        // They don't actually test any code in libMBIN at this time.
        //
        // The default string format for floats is "G". It's main purpose is for user display, so it will truncate or round values to avoid long strings.
        // Although 32-bit floating point precision is less than 7 digits, the actual representation of any floating point value could be much more.
        // While any accuracy beyond 7 digits is unreliable, different floating point values might begin with the same 7 digits.
        // To be able to uniquely identify all floating point values in the 32-bit range requires up to 9 digits. Any further digits are extraneous
        // and can/will be inferred.
        //
        // 64-bit floats have a precision of 15 digits, but require up to 17 digits to be uniquely identifiable.

        [DataTestMethod]
        [DataRow( 0.0f              )]
        [DataRow( 1.0f              )]
        [DataRow( 0.1f              )]
        [DataRow( 6548130.0146546f  )]
        [DataRow( 6.9871324E+7f     )]
        [DataRow( -1.0f             )]
        [DataRow( -0.1f             )]
        [DataRow( -0.0004135674213f )]
        [DataRow( -8765413.664133f  )]
        [DataRow( -9.463131E-12f    )]
        [DataRow( -7.613264E+9f     )]
        // The G format is sufficient for most cases but it doesn't capture all unique floating point values.
        public void TestFloatToStringToFloat_G_Pass( float expected ) {
            string s = expected.ToString( System.Globalization.CultureInfo.InvariantCulture );
            float actual = float.Parse( s );
            Assert.AreEqual( expected, actual, $"\n{expected:G9} != {actual:G9}\nDelta: {actual - expected:G9}" );
        }

        [DataTestMethod]
        [DataRow( 0.00032456703610f )]
        [DataRow( 4.5678941E-14f    )]
        // The G format is unable to capure the unique value of some floats. The conversion is lossy.
        public void TestFloatToStringToFloat_G_Fail( float expected ) {
            string s = expected.ToString( System.Globalization.CultureInfo.InvariantCulture );
            float actual = float.Parse( s );
            Assert.AreNotEqual( expected, actual, $"\n{expected:G9} == {actual:G9}" );
        }

        [DataTestMethod]
        [DataRow( 0.0f              )]
        [DataRow( 1.0f              )]
        [DataRow( 0.1f              )]
        [DataRow( 0.00032456703610f )]
        [DataRow( 6548130.0146546f  )]
        [DataRow( 4.5678941E-14f    )]
        [DataRow( 6.9871324E+7f     )]
        [DataRow( -1.0f             )]
        [DataRow( -0.1f             )]
        [DataRow( -0.0004135674213f )]
        [DataRow( -8765413.664133f  )]
        [DataRow( -9.463131E-12f    )]
        [DataRow( -7.613264E+9f     )]
        // By enforcing 9 digits, any float value can be faithfully reproduced from a string representation.
        public void TestFloatToStringToFloat_G9_Pass( float expected ) {
            string s = expected.ToString( "G9", System.Globalization.CultureInfo.InvariantCulture );
            float actual = float.Parse( s );
            Assert.AreEqual( expected, actual, $"\n{expected:G9} != {actual:G9}\nDelta: {actual - expected:G9}" );
        }

    }

}
