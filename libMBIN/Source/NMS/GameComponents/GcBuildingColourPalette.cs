using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB89D93BFCDA9EDCA, NameHash = 0xE3CA41789B108657)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x8 */ public List<GcWeightedColourId> Palettes;
    }
}
