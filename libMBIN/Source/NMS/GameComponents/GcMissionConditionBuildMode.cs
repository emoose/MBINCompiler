using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x18E906572B634741, NameHash = 0xB24BA773)]
    public class GcMissionConditionBuildMode : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcBaseBuildingMode Mode;
    }
}
