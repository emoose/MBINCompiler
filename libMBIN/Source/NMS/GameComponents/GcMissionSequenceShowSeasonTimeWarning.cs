namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC45A8B074F0BB2C0, NameHash = 0x232C5143BAE4E2F9)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public float TimeToShow;
        /* 0x84 */ public NMSString0x80 DebugText;
    }
}
