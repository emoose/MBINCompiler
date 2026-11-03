namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED2CE2B5DDA94E98, NameHash = 0x62FB4792)]
    public class GcMinMaxFloat : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Max;
        [NMS(Index = 0)]
        /* 0x4 */ public float Min;
    }
}
