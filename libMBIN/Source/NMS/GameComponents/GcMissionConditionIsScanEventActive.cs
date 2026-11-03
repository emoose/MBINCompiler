namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x989370EA957C1DA8, NameHash = 0x7F011F09)]
    public class GcMissionConditionIsScanEventActive : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool MustMatchThisMissionIDSeed;
    }
}
