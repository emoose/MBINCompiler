namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD91C0E1B0B47CD9E, NameHash = 0xFCFEF60947A44802)]
    public class GcRewardMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public bool SetAsSelected;
        /* 0x11 */ public bool FailRewardIfMissionActive;
    }
}
