using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20BF15896539B66E, NameHash = 0xC46F65E7)]
    public class GcSettlementMaterialData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcBuildingMaterialOverride> BuildingMaterials;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcBuildingMaterialOverride> BuildingPalettes;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcWeightedMaterialId> DefaultMaterials;
        [NMS(Index = 0)]
        /* 0x30 */ public List<GcWeightedMaterialId> DefaultPalettes;
    }
}
