using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6C488AC968947D56, NameHash = 0xF8617113)]
    public class GcFreighterDungeonsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcFreighterDungeonParams> Dungeons;
    }
}
