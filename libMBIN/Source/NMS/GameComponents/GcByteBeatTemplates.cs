using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC0, GUID = 0x1BC1379529E5A2D3, NameHash = 0xBBB68492659143C4)]
    public class GcByteBeatTemplates : NMSTemplate
    {
        /* 0x00 */ public List<GcByteBeatTemplate> Templates;
        [NMS(Size = 0x12, EnumType = typeof(GcByteBeatToken.ByteBeatTokenEnum))]
        /* 0x10 */ public float[] CombinerWeights;
        /* 0x58 */ public List<NMSString0x40> Kicks;
        /* 0x68 */ public List<NMSString0x40> Snares;
        /* 0x78 */ public List<NMSString0x40> Hats;
        /* 0x88 */ public List<GcByteBeatDrum> KickDrums;
        /* 0x98 */ public List<GcByteBeatDrum> SnareDrums;
        /* 0xA8 */ public List<GcByteBeatDrum> HiHats;
        /* 0xB8 */ public float OperatorPermuteChance;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xBC */ public byte[] EndPadding;
    }
}
