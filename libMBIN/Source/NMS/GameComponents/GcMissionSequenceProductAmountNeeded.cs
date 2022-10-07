namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BB6B50446320098, NameHash = 0x49B1F2E8A11B19B6)]
    public class GcMissionSequenceProductAmountNeeded : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Item;
        /* 0x90 */ public NMSString0x10 ToBuild;
        /* 0xA0 */ public bool IsRepair;
        /* 0xA1 */ public NMSString0x80 DebugText;
    }
}
