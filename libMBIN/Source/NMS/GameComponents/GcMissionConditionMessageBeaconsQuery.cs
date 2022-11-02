namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA7A71D2D98606DEE, NameHash = 0x7A896811854A127F)]
    public class GcMissionConditionMessageBeaconsQuery : NMSTemplate
    {
        /* 0x0 */ public int MinPartsFound;
        /* 0x4 */ public int MaxPartsFound;
        /* 0x8 */ public float SearchDistanceLimit;
    }
}
