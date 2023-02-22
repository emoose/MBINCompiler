namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B04EBF0C9459B33, NameHash = 0xB254C2F2874C6D05)]
    public class GcCustomNotifyTimerOptions : NMSTemplate
    {
        /* 0x0 */ public bool HasCustomNotifyTimer;
        /* 0x4 */ public float NotifyDisplayTime;
        /* 0x8 */ public float NotifyPauseTime;
    }
}
