using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD09353C3B46C18EA, NameHash = 0x5A86E9AA)]
    public class GcMissionConditionRequestedPhoto : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Biome;
    }
}
