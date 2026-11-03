using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2F9EBC2E4ECC3854, NameHash = 0xF8A18AA2)]
    public class GcMissionConditionNumberOfShipsOwned : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int NumShips;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
