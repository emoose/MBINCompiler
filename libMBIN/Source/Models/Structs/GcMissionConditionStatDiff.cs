namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcMissionConditionStatDiff : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string CurrentStat;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string TargetStat;
        /* 0x20 */ public int AmountPastTarget;
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
