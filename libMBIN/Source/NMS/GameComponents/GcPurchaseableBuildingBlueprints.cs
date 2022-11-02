using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29A0CE635F9CA6A3, NameHash = 0x7DB6471B493F5A78)]
    public class GcPurchaseableBuildingBlueprints : NMSTemplate
    {
        /* 0x00 */ public List<GcBuildingBlueprint> Table;
        /* 0x10 */ public List<int> GroupMaxItems;
    }
}
