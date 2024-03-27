using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x83F8EF11C161AA7C, NameHash = 0x4F8B68FB20F9A030)]
    public class TkLSystemInnerRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LocatorType;
        // size: 0x3
        public enum MergeProbabilityOptionsEnum : uint {
            Balance,
            Prioritize,
            Replace,
        }
        /* 0x20 */ public MergeProbabilityOptionsEnum MergeProbabilityOptions;
        /* 0x28 */ public List<TkLSystemLocatorEntry> Entries;
    }
}
