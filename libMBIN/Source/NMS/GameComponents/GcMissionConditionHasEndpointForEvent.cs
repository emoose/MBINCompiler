namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDE5A932BCC8BDB5A, NameHash = 0x3353504E)]
    public class GcMissionConditionHasEndpointForEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A EventID;
        [NMS(Index = 1)]
        /* 0x20 */ public float MaxDistance;
    }
}
