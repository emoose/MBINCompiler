namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D31AF6E63D2784E, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public float WaitTime;
        /* 0x84 */ public bool BlockTimedScans;
        /* 0x85 */ public bool RequiresMissionActive;
        /* 0x86 */ public NMSString0x80 DebugText;
    }
}
