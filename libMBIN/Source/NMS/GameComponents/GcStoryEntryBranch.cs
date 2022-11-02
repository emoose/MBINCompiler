namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFEEAC16298416F86, NameHash = 0x259D492A614EC840)]
    public class GcStoryEntryBranch : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Entry;
        /* 0x20 */ public NMSString0x10 RequiresMission;
        /* 0x30 */ public bool ConditionMissionComplete;
    }
}
