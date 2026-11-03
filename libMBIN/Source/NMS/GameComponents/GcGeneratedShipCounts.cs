using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x560B101EE2BBA404, NameHash = 0x4069B863)]
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAISpaceshipRoles.AIShipRoleEnum))]
        /* 0x0 */ public int[] Counts;
    }
}
