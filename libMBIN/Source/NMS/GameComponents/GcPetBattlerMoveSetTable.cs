using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC19583BE65D155D, NameHash = 0xDAF36E2B)]
    public class GcPetBattlerMoveSetTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetBattlerMoveSet> MoveSets;
    }
}
