namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFCF41239EA24F2FB, NameHash = 0xD5973A3E)]
    public class GcRewardSettlementParty : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A OSD;
        [NMS(Index = 0)]
        /* 0x20 */ public float FireworksDuration;
        [NMS(Index = 1)]
        /* 0x24 */ public float FireworksFrequency;
    }
}
