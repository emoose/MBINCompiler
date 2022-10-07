using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D17AE27518A3733, NameHash = 0x556A3DBA7B5C9168)]
    public class GcFreighterDungeonsTable : NMSTemplate
    {
        /* 0x0 */ public List<GcFreighterDungeonParams> Dungeons;
    }
}
