using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x78, GUID = 0x0000000000000000, NameHash = 0xFC506DC8F06CBE6D)]
    public class TkMaterialShaderMillLink : NMSTemplate
    {
        /* 0x00 */ public int InputNode;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string InputConnect;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x24 */ public byte[] Padding24;
        [NMS(Size = 0x10)]
        /* 0x28 */ public string InputShuffle;
        /* 0x38 */ public int OutputNode;
        [NMS(Size = 0x20)]
        /* 0x3C */ public string OutputConnect;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x5C */ public byte[] Padding5C;
        [NMS(Size = 0x10)]
        /* 0x60 */ public string OutputShuffle;
        /* 0x70 */ public int Count;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x74 */ public byte[] EndPadding;
    }
}
