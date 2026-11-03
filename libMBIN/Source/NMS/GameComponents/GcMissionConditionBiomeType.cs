using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA79DA136FDF3691, NameHash = 0xFD18D350)]
    public class GcMissionConditionBiomeType : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBiomeType Type;
        [NMS(Index = 1)]
        /* 0x4 */ public bool AnyInfested;
        [NMS(Index = 2)]
        /* 0x5 */ public bool AnyRuins;
    }
}
