using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C, GUID = 0x1E174AAC81BFAF86, NameHash = 0xB150A87B0DD42807)]
    public class GcDistanceScaleComponentData : NMSTemplate
    {
        /* 0x00 */ public bool UseGlobals;
        /* 0x04 */ public float Scale;
        /* 0x08 */ public float MinDistance;
        /* 0x0C */ public float MaxDistance;
        /* 0x10 */ public float MinHeight;
        /* 0x14 */ public float MaxHeight;
        /* 0x18 */ public bool DisabledWhenOnFreighter;
    }
}
