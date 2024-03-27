using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59306510A2330F75, NameHash = 0xCE965FAFD6BBF99E)]
    public class GcTestMetadata : NMSTemplate
    {
        /* 0x000 */ public bool TestBool;
        /* 0x001 */ public byte TestByte;
        /* 0x004 */ public int TestInt;
        /* 0x008 */ public short TestInt16;
        /* 0x00A */ public ushort TestUInt16;
        /* 0x010 */ public long TestInt64;
        /* 0x018 */ public ulong TestUInt64;
        /* 0x020 */ public long TestInt64_2;
        /* 0x028 */ public ulong TestUInt64_2;
        /* 0x030 */ public GcResource TestResource;
        /* 0x040 */ public Vector3f TestVector;
        /* 0x050 */ public Vector2f TestVector2;
        /* 0x060 */ public Vector4f TestVector4;
        /* 0x070 */ public Colour TestColour;
        /* 0x080 */ public float TestFloat;
        /* 0x088 */ public GcSeed TestSeed;
        /* 0x098 */ public NMSString0x80 TestModelFilename;
        /* 0x118 */ public NMSString0x80 TestTextureFilename;
        /* 0x198 */ public NMSString0x20 TestString;
        /* 0x1B8 */ public NMSString0x80 TestString128;
        /* 0x238 */ public NMSString0x100 TestString256;
        /* 0x338 */ public NMSString0x200 TestString512;
        /* 0x538 */ public NMSString0x10 TestID;
        /* 0x548 */ public NMSString0x20A TestLocID;
        /* 0x568 */ public NMSString0x10 TestLookupSpecies;
        /* 0x578 */ public GcAudioWwiseEvents TestAudioEvent;
        /* 0x580 */ public Vector3f DocOptionalVector;
        /* 0x590 */ public NMSString0x40 DocRenamedString64;
        /* 0x5D0 */ public NMSString0x20A DocOptionalRenamed;
        // size: 0x4
        public enum DocOptionalEnumEnum : uint {
            SomeValue1,
            SomeValue2,
            SomeValue3,
            SomeValue4,
        }
        /* 0x5F0 */ public DocOptionalEnumEnum DocOptionalEnum;
        /* 0x5F8 */ public VariableSizeString TestDynamicString;
        // size: 0x4
        public enum TestEnumEnum : uint {
            Default,
            Option1,
            Option2,
            Option3,
        }
        /* 0x608 */ public TestEnumEnum TestEnum;
        [NMS(Size = 0xA)]
        /* 0x60C */ public float[] TestStaticArray;
        /* 0x638 */ public List<float> TestDynamicArray;
        // size: 0x4
        public enum TestEnumArrayEnum {
            Default,
            Option1,
            Option2,
            Option3,
        }
        [NMS(Size = 0x4, EnumType = typeof(TestEnumArrayEnum))]
        /* 0x648 */ public float[] TestEnumArray;
        [NMS(Size = 0x37, EnumType = typeof(GcBuildingClassification.BuildingClassEnum))]
        /* 0x658 */ public float[] TestExternalEnumArray;
        // size: 0x4
        [Flags]
        public enum TestFlagsEnum : uint {
            None = 0x0,
            Flag1 = 0x1,
            Flag2 = 0x2,
            Flag3 = 0x4,
        }
        /* 0x734 */ public TestFlagsEnum TestFlags;
    }
}
