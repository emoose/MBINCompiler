namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56C5A291BA653D60, NameHash = 0x3D9281DDAAB505CF)]
    public class GcPurchaseableSpecial : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public int ShopNumber;
        /* 0x14 */ public int MissionTier;
        /* 0x18 */ public bool IsConsumable;
        /* 0x19 */ public bool IsCape;
    }
}
