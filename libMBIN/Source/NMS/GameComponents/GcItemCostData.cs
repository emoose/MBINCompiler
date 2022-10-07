namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C6EA5392999C687, NameHash = 0xA3976E1971095FC4)]
    public class GcItemCostData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public float Cost;
        /* 0x14 */ public float MinCost;
        /* 0x18 */ public float MaxCost;
        /* 0x1C */ public float ChangePerSale;
    }
}
