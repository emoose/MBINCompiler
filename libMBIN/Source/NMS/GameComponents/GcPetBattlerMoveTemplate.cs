using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1372919B9AB401F6, NameHash = 0xC274168E)]
    public class GcPetBattlerMoveTemplate : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x000 */ public NMSTemplate AISelectionCriteria;
        [NMS(Index = 0)]
        /* 0x010 */ public NMSString0x10 ID;
        [NMS(Index = 7)]
        /* 0x020 */ public List<GcPetBattlerMovePhase> Phases;
        [NMS(Index = 6)]
        /* 0x030 */ public GcPetBattlerIconStyle OverrideMoveIcon;
        [NMS(Index = 1)]
        /* 0x034 */ public NMSString0x80 DebugDescription;
        [NMS(Index = 8)]
        /* 0x0B4 */ public NMSString0x80 NameStub;
        [NMS(Index = 4)]
        /* 0x134 */ public bool BasicMove;
        [NMS(Index = 5)]
        /* 0x135 */ public bool CanHaveCooldownsReset;
        [NMS(Index = 3)]
        /* 0x136 */ public bool MultiTurnMove;
        [NMS(Index = 2)]
        /* 0x137 */ public GcPetBattlerTarget PrimaryTarget;
    }
}
