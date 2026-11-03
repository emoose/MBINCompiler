using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99683B0D60211AD2, NameHash = 0x2F76F833)]
    public class GcAISpaceshipMappingData : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public GcAISpaceshipInstanceData[] ClassMap;
    }
}
