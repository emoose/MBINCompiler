using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BA49B0D1A4A7720, NameHash = 0x8DE7D82B)]
    public class GcMissionConditionNumAtlasStationsVisited : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Count;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
