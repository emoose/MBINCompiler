using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7993F7B402A1267D, NameHash = 0x6F8085E)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource DungeonRootScene;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x20A MarkerLabel;
        [NMS(Index = 3)]
        /* 0x40 */ public TkTextureResource MarkerIcon;
        [NMS(Index = 1)]
        /* 0x58 */ public List<GcFreighterDungeonChoice> DungeonOptions;
    }
}
