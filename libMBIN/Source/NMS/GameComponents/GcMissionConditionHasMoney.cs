using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD27766F8EE556E1A, NameHash = 0x58D4887623FE6FF5)]
    public class GcMissionConditionHasMoney : NMSTemplate
    {
        /* 0x0 */ public int Amount;
        /* 0x4 */ public GcCurrency TestCurrency;
        /* 0x8 */ public bool ApplyDifficultyScaling;
    }
}
