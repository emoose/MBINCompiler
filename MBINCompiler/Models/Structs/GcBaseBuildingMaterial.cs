using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcBaseBuildingMaterial : NMSTemplate       // size: 0xA0
    {
        /* 0x00 */ public int MaterialIndex;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string Name;
        /* 0x18 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x9C */ public byte[] EndPadding;
    }
}
