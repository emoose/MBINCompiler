using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x366F0B4FDF672403, NameHash = 0x8505F02597BABF0)]
    public class GcFrigateClassCost : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public int[] Cost;
    }
}
