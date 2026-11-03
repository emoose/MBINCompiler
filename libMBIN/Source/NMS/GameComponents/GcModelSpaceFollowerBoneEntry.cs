using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32872E0842D4F151, NameHash = 0xBAC3725B)]
    public class GcModelSpaceFollowerBoneEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public AxisSpecification Axis;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x100 Name;
    }
}
