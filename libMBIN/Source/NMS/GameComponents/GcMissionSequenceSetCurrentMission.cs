namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBDC892A5AE89318A, NameHash = 0x48508806BFEC4731)]
    public class GcMissionSequenceSetCurrentMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public bool Silent;
        /* 0x11 */ public NMSString0x80 DebugText;
    }
}
