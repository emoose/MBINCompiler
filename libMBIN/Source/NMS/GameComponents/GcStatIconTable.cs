using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCBEEF83A1C0B60AA, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Size = 0xBE, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public NMSString0x80[] StatIcons;
    }
}
