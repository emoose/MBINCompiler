using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x87C238749E3F9703, NameHash = 0xE3CA41789B108657)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x8 */ public List<GcWeightedColourId> Palettes;
    }
}
