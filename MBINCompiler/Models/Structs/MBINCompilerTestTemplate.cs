using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class MBINCompilerTestTemplate : NMSTemplate
    {
        public bool TestBoolTrue;
        public bool TestBoolFalse;
        public bool TestBool3;
        public short TestInt16;
        public int TestInt32;
        public long TestInt64;
        public float TestFloat;
        public int TestEnumYes;
        public int TestEnumNo;
        [NMS(Size = 0x10)]
        public string TestString;
        public VariableSizeString TestDynamicString;
        public List<NMSString0x80> Test0x80ByteStringList;
        public List<int> TestListInt;
        // todo: public List<NMSTemplate> TestGenericList
    }
}
