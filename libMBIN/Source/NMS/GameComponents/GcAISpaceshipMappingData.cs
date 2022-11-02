using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBFF21C24F3FE5C74, NameHash = 0xD67478E5FA6B9871)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
