using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AD6D9760D21ED40, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public NMSString0x10 StatGroup;
        /* 0x20 */ public int Level;
        /* 0x24 */ public int LevelledStatRank;
        /* 0x28 */ public bool TakeLevelFromSeasonData;
        /* 0x29 */ public bool ForceIgnoreLevelledStat;
        /* 0x30 */ public NMSString0x10 CompareStat;
        /* 0x40 */ public int DisplayMilestoneNumber;
        /* 0x44 */ public TkEqualityEnum Test;
    }
}
