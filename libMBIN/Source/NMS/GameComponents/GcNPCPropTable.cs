using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD205652DBD1D7298, NameHash = 0x22BD6A8E5AD4C4CB)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Size = 0xD, EnumType = typeof(GcNPCPropType.NPCPropEnum))]
        /* 0x0 */ public GcNPCPropInfo[] Props;
    }
}
