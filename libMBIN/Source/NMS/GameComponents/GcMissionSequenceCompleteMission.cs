namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCEA9EF02A04E383, NameHash = 0xF34AADF7CA91192B)]
    public class GcMissionSequenceCompleteMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public bool UseSeed;
        /* 0x11 */ public NMSString0x80 DebugText;
    }
}
