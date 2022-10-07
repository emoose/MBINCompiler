using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD72055522079998, NameHash = 0x95028D8CB7957BEF)]
    public class GcAbandonedFreighterComponentData : NMSTemplate
    {
        /* 0x00 */ public TkModelResource DungeonRootScene;
        /* 0x88 */ public List<GcFreighterDungeonChoice> DungeonOptions;
        /* 0x98 */ public NMSString0x20A MarkerLabel;
        /* 0xB8 */ public TkTextureResource MarkerIcon;
    }
}
