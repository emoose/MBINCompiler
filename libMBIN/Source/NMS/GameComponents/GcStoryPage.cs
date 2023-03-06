using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8EF7AE92F0F264, NameHash = 0xDA4CC10DF6E92F8C)]
    public class GcStoryPage : NMSTemplate
    {
        /* 0x00 */ public GcInteractionType InteractionType;
        /* 0x08 */ public NMSString0x10 Stat;
        /* 0x18 */ public bool StatIsBitmask;
        /* 0x1C */ public TkTextureResource Icon;
        /* 0xA0 */ public NMSString0x20A ID;
        /* 0xC0 */ public List<GcStoryEntry> Entries;
        /* 0xD0 */ public bool UseGridType;
        /* 0xD4 */ public GcWikiTopicType WikiGridType;
    }
}
