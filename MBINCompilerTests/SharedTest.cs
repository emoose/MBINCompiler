using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MBINCompilerTests
{
    [TestClass]
    public class SharedTest
    {
        private class WriteStringTestCase
        {
            public string Value { get; set; }

            public Encoding Encoding { get; set; }

            public int? Size { get; set; }

            public bool NullTerminated { get; set; }

            public byte[] Expected { get; set; }

            public override string ToString()
            {
                string size = Size.HasValue ? Size.ToString() : "null";
                return $"{nameof(Size)}: {size}, {nameof(NullTerminated)}: {NullTerminated}, Value: \'{Value}\'";
            }
        }

        [TestMethod]
        public void TestStringWriteAscii()
        {
            List<WriteStringTestCase> testCases = new List<WriteStringTestCase>();
            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.ASCII,
                Size = null,
                NullTerminated = false,
                Expected = new byte[] { }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = null,
                NullTerminated = false,
                Expected = new byte[] { 0x61, 0x62, 0x63 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.ASCII,
                Size = null,
                NullTerminated = false,
                Expected = new byte[] { }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 2,
                NullTerminated = false,
                Expected = new byte[] { 0x61, 0x62 }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 3,
                NullTerminated = false,
                Expected = new byte[] { 0x61, 0x62, 0x63 }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 4,
                NullTerminated = false,
                Expected = new byte[] { 0x61, 0x62, 0x63, 0x00 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.ASCII,
                Size = null,
                NullTerminated = true,
                Expected = new byte[] { 0x00 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = null,
                NullTerminated = true,
                Expected = new byte[] { 0x61, 0x62, 0x63, 0x00 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.ASCII,
                Size = 0,
                NullTerminated = true,
                Expected = new byte[] { }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.ASCII,
                Size = 2,
                NullTerminated = true,
                Expected = new byte[] { 0x00, 0x00 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 1,
                NullTerminated = true,
                Expected = new byte[] { 0x00 }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 2,
                NullTerminated = true,
                Expected = new byte[] { 0x61, 0x00 }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "abc",
                Encoding = Encoding.ASCII,
                Size = 5,
                NullTerminated = true,
                Expected = new byte[] { 0x61, 0x62, 0x63, 0x00, 0x00 }
            });

            RunWriteStringTests(testCases);
        }

        [TestMethod]
        public void TestStringWriteUtf8()
        {
            List<WriteStringTestCase> testCases = new List<WriteStringTestCase>();
            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.UTF8,
                Size = null,
                NullTerminated = false,
                Expected = new byte[] { }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = null,
                NullTerminated = false,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98
                }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.UTF8,
                Size = null,
                NullTerminated = false,
                Expected = new byte[] { }
            });
            //testCases.Add(new WriteStringTestCase
            //{
            //    Value = "𠜎𢱑𩶘",
            //    Encoding = Encoding.UTF8,
            //    Size = 7,
            //    NullTerminated = false,
            //    Expected = new byte[] { 0xF0, 0xA0, 0x9C, 0x8E }
            //});
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = 8,
                NullTerminated = false,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = 12,
                NullTerminated = false,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98
                }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = 13,
                NullTerminated = false,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00
                }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.UTF8,
                Size = null,
                NullTerminated = true,
                Expected = new byte[] { 0x00 }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = null,
                NullTerminated = true,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00
                }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.UTF8,
                Size = 0,
                NullTerminated = true,
                Expected = new byte[] { }
            });
            testCases.Add(new WriteStringTestCase
            {
                Value = "",
                Encoding = Encoding.UTF8,
                Size = 2,
                NullTerminated = true,
                Expected = new byte[] { 0x00, 0x00 }
            });

            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = 1,
                NullTerminated = true,
                Expected = new byte[] { 0x00 }
            });
            //testCases.Add(new WriteStringTestCase
            //{
            //    Value = "𠜎𢱑𩶘",
            //    Encoding = Encoding.UTF8,
            //    Size = 8,
            //    NullTerminated = true,
            //    Expected = new byte[]
            //    {
            //        0xF0, 0xA0, 0x9C, 0x8E,
            //        0x00, 0x00, 0x00, 0x00
            //    }
            //});
            testCases.Add(new WriteStringTestCase
            {
                Value = "𠜎𢱑𩶘",
                Encoding = Encoding.UTF8,
                Size = 14,
                NullTerminated = true,
                Expected = new byte[]
                {
                    0xF0, 0xA0, 0x9C, 0x8E,
                    0xF0, 0xA2, 0xB1, 0x91,
                    0xF0, 0xA9, 0xB6, 0x98,
                    0x00, 0x00
                }
            });

            RunWriteStringTests(testCases);
        }

        private static void RunWriteStringTests(List<WriteStringTestCase> testCases)
        {
            foreach (var testCase in testCases)
            {
                var stream = new MemoryStream();
                var writer = new BinaryWriter(stream);

                MBINCompiler.Shared.WriteString(writer, testCase.Value, testCase.Encoding, testCase.Size,
                    testCase.NullTerminated);

                byte[] actual = stream.ToArray();
                CollectionAssert.AreEqual(testCase.Expected, actual, testCase.ToString());
            }
        }
    }
}