namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EA99B3B2857FA6F, NameHash = 0xFEEBE158)]
    public class GcRewardDummyLocID : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A LocID;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x24 */ public int AmountMin;
    }
}
