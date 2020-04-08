using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xF0, GUID = 0x7EA1EEF36039128B, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string TopicID;
        /* 0x20 */ public TkTextureResource Icon;
        /* 0xA8 */ public List<GcWikiPage>  Pages;
        [NMS(Size = 0x10)]
        /* 0xB8 */ public string Mission;
        [NMS(Size = 0x20)]
        /* 0xC8 */ public string MissionButtonText;
        /* 0xE8 */ public bool Seen;
        /* 0xE9 */ public bool Unlocked;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0xEA */ public byte[] PaddingEA;
        /* 0xEC */ public GcActionSetType ActionSet;
    }
}
