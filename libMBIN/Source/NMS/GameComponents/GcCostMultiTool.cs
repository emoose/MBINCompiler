using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFE97F5747DB4F877, NameHash = 0xDACA92E9)]
    public class GcCostMultiTool : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A CostString;
        [NMS(Index = 1)]
        /* 0x20 */ public GcWeaponClasses WeaponClass;
    }
}
