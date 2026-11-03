using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D27A5F991A4D756, NameHash = 0x33020686)]
    public class GcMissionConditionHasFish : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 0)]
        /* 0x68 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x6C */ public TkEqualityEnum QualityTest;
        [NMS(Index = 3)]
        /* 0x70 */ public TkEqualityEnum SizeTest;
        [NMS(Index = 4)]
        /* 0x74 */ public bool TakeAmountFromSeasonData;
    }
}
