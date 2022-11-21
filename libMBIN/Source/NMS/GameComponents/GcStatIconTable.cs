using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x38E4DC4566DA3C, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Size = 0xBD, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        /* 0x0 */ public NMSString0x80[] StatIcons;
    }
}
