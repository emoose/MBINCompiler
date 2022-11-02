using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5615F54FAD7042F3, NameHash = 0x87616D37E129954C)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        /* 0x0 */ public bool UseInteractionBuildingType;
        /* 0x4 */ public GcBuildingClassification BuildingType;
    }
}
