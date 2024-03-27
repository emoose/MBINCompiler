namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46D744585C16A122, NameHash = 0xFCFEF60947A44802)]
    public class GcRewardMission : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public bool SetAsSelected;
        /* 0x11 */ public bool Restart;
        /* 0x12 */ public bool FailRewardIfMissionActive;
        /* 0x18 */ public NMSString0x20A AlreadyActiveFailureMessage;
    }
}
