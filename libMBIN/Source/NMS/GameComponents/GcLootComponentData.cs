using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, Alignment = 0x8, GUID = 0xF0E6D81FCD11E097, NameHash = 0x1E85F3A419864E16)]
    public class GcLootComponentData : NMSTemplate
    {
        /* 0x00 */ public Vector2f Timed;
        [NMS(Size = 0x10)]
        /* 0x08 */ public string TimeOutEffect;
        /* 0x18 */ public bool DeathPoint;
        [NMS(Size = 7, Ignore = true)]
        /* 0x19 */ public byte[] EndPadding;
    }
}
