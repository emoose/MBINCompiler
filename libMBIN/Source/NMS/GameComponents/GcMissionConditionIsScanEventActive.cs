namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x344CD6CF94084593, NameHash = 0xDF80EC28C687305E)]
    public class GcMissionConditionIsScanEventActive : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public bool MustMatchThisMissionIDSeed;
    }
}
