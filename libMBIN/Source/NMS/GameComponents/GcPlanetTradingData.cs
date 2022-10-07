using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BB5E6CD0DF22677, NameHash = 0x645C709EAB3A1F55)]
    public class GcPlanetTradingData : NMSTemplate
    {
        /* 0x0 */ public GcWealthClass WealthClass;
        /* 0x4 */ public GcTradingClass TradingClass;
    }
}
