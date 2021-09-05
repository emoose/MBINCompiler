using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x170, GUID = 0xFDC63F5AD4E609D7, NameHash = 0x55D566D2C6EFD1C1)]
    public class GcWikiTopic : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A TopicID;
        /* 0x020 */ public TkTextureResource Icon;
        /* 0x0A4 */ public TkTextureResource NotifyIcon;
        /* 0x128 */ public List<GcWikiPage>  Pages;
        /* 0x138 */ public NMSString0x10 Mission;
        /* 0x148 */ public NMSString0x20A MissionButtonText;
        /* 0x168 */ public bool Seen;
        /* 0x169 */ public bool Unlocked;
        /* 0x16C */ public GcActionSetType ActionSet;
    }
}
