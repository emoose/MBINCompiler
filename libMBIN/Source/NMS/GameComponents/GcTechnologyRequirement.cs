using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD5C2A72563BEA93, NameHash = 0xD46635882CF8E5)]
    public class GcTechnologyRequirement : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public GcInventoryType Type;
        /* 0x14 */ public int Amount;
    }
}
