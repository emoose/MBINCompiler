using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5200, GUID = 0x1E0206B2601F3050, NameHash = 0x266F5269ED2C5661)]
    public class GcStatIconTable : NMSTemplate
    {
        [NMS(Size = 0xA4, EnumType = typeof(GcStatsTypes.StatsTypeEnum))]
        public NMSString0x80[] StatIcons;
    }
}
