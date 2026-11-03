using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D810CA55583D2FC, NameHash = 0xD585FDA4)]
    public class GcRewardSettlementProgress : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcBuildingClassification BuildingType;
        [NMS(Index = 0)]
        /* 0x1 */ public bool UseInteractionBuildingType;
    }
}
