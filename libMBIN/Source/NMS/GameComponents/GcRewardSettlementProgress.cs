using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x2101A31E19D1288, NameHash = 0x87616D37E129954C)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        /* 0x0 */ public bool UseInteractionBuildingType;
        /* 0x4 */ public GcBuildingClassification BuildingType;
    }
}
