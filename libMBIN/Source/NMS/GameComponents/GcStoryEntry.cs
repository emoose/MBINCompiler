using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46C4D966A15AFF1E, NameHash = 0x7D4184057E24E50A)]
    public class GcStoryEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public NMSString0x20A Entry;
        /* 0x40 */ public List<GcStoryEntryBranch> BranchedEntries;
        /* 0x50 */ public NMSString0x20A AlienText;
        /* 0x70 */ public bool AutoPrefixWithAlienText;
    }
}
