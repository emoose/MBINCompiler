using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC529A4DE111AF6A6, NameHash = 0x9E0F95A6)]
    public class GcNPCPropTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xF, EnumType = typeof(GcNPCPropType.NPCPropEnum))]
        /* 0x0 */ public GcNPCPropInfo[] Props;
    }
}
