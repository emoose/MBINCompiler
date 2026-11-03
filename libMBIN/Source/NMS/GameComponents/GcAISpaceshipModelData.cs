using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD3394CCE93FFF98F, NameHash = 0x9D94FFAB)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Id;
        [NMS(Index = 1)]
        /* 0x20 */ public GcFilename Filename;
        [NMS(Index = 3)]
        /* 0x30 */ public GcAISpaceshipRoles AIRole;
        [NMS(Index = 2)]
        /* 0x34 */ public GcSpaceshipClasses Class;
        [NMS(Index = 4)]
        /* 0x38 */ public GcFrigateClass FrigateClass;
    }
}
