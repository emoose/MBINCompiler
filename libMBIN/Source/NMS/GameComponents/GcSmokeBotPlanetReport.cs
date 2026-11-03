using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBDA8D8474AFC316, NameHash = 0xCB5C0481)]
    public class GcSmokeBotPlanetReport : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcSmokeBotStats PlanetStats;
        [NMS(Index = 0)]
        /* 0x90 */ public ulong UA;
    }
}
