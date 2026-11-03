namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6EBE9A69980C69E5, NameHash = 0xD71452BA)]
    public class GcItemAmountCostPair : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ItemId;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
    }
}
