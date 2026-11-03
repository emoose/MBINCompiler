using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x503A198E12DA19F7, NameHash = 0x36328696)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public int[] Cost;
    }
}
