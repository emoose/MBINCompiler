using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AF6D4AC38EA0BF2, NameHash = 0x778378F86BB2392C)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        /* 0x00 */ public ulong UA;
        /* 0x10 */ public GcSmokeBotStats PlanetStats;
    }
}
