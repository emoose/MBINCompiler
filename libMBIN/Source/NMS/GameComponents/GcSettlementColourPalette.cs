using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x2B94909B231687A0, NameHash = 0x4D5124F6D6062BBF)]
    public class GcSettlementColourPalette : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float RelativeProbability;
        /* 0x14 */ public GcBaseBuildingPartStyle LimitToStyle;
        /* 0x18 */ public List<GcWeightedColourId> DefaultPalettes;
        /* 0x28 */ public List<GcBuildingColourPalette> BuildingPalettes;
    }
}
