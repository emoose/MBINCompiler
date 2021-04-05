using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5180, GUID = 0x0, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Size = 0xA3, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        public NMSString0x80[] StatIcons;
    }
}
