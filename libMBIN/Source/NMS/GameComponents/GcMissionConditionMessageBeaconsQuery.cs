namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCC581F3512D8D6EC, NameHash = 0xE72CD1C3)]
    public class GcMissionConditionMessageBeaconsQuery : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int MaxPartsFound;
        [NMS(Index = 0)]
        /* 0x4 */ public int MinPartsFound;
        [NMS(Index = 2)]
        /* 0x8 */ public float SearchDistanceLimit;
    }
}
