namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53D3B2518A469A92, NameHash = 0xD9D87A3D)]
    public class GcPetShopItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 LinkedRewardID;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 ProductID;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x10 RequiredStat;
        [NMS(Index = 4)]
        /* 0x30 */ public int Price;
        [NMS(Index = 3)]
        /* 0x34 */ public int RequiredStatTier;
    }
}
