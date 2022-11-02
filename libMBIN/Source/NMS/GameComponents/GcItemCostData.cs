namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F75FB6C7361C08B, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float Cost;
        /* 0x14 */ public float MinCost;
        /* 0x18 */ public float MaxCost;
        /* 0x1C */ public float ChangePerSale;
    }
}
