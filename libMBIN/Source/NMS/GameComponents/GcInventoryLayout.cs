using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0EB40D4AD4447ECD0)]
    public class GcInventoryLayout : NMSTemplate        // size: 0x20
    {
        /* 0x00 */ public int Slots;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04 */ public byte[] Padding4;
        /* 0x08 */ public GcSeed Seed;
        /* 0x18 */ public int Level;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1C */ public byte[] Endpadding;
    }
}
