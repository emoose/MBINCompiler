using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB859FE93EE77A89F, NameHash = 0x49261BF3)]
    public class GcPetBattlerMovesTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetBattlerMoveTemplate> Moves;
    }
}
