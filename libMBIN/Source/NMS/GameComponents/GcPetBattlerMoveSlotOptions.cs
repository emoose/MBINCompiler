using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x85826936223A340E, NameHash = 0xE7A35CD5)]
    public class GcPetBattlerMoveSlotOptions : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPetBattlerMoveSlotOption> AllowedMoveTemplates;
    }
}
