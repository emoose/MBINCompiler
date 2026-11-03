namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C84CFB0D0D4BDCB, NameHash = 0x5B7C3EF1)]
    public class GcCreatureGroupProbability : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 1)]
        /* 0x10 */ public float Probability;
    }
}
