namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC715EF7CC96ECF8, NameHash = 0xB7F9543C)]
    public class GcMissionConditionCookingSearch : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Product;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x14 */ public bool IfCookerOutputMustBeCorvetteModule;
        [NMS(Index = 3)]
        /* 0x15 */ public bool ReturnTrueIfCanMakeProduct;
        [NMS(Index = 2)]
        /* 0x16 */ public bool SetIcon;
    }
}
