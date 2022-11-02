using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6604454B3FE63E95, NameHash = 0x8984A8784D46EE5F)]
    public class GcMissionConditionSquadronPilotsOwned : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x4 */ public TkEqualityEnum Test;
        /* 0x8 */ public bool TakeNumberFromSeasonData;
    }
}
