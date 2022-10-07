namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7777570EFFE16F34, NameHash = 0x29C73977774C3241)]
    public class GcStateTimeEvent : NMSTemplate
    {
        /* 0x0 */ public float Seconds;
        /* 0x4 */ public float RandomSeconds;
        /* 0x8 */ public bool UseMissionClock;
    }
}
