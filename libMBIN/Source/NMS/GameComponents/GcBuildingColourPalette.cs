using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x7566D03181E5578F, NameHash = 0xE3CA41789B108657)]
    public class GcBuildingColourPalette : NMSTemplate
    {
        /* 0x0 */ public GcBuildingClassification Building;
        /* 0x8 */ public List<GcWeightedColourId> Palettes;
    }
}
