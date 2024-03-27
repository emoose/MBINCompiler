namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957D0B90903AE97, NameHash = 0x271F1C7199403F55)]
    public class GcMissionSequenceFeed : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public bool RequireSpecificBait;
        /* 0x84 */ public int AmountMin;
        /* 0x88 */ public int AmountMax;
        /* 0x8C */ public NMSString0x80 DebugText;
    }
}
