using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x47B9100FE44F5FF3, NameHash = 0xB230AD2C)]
    public class TkLSystemRule : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFilename Model;
        [NMS(Index = 2)]
        /* 0x10 */ public List<TkLSystemInnerRule> Rules;
        // size: 0x2
        public enum RuleTypeEnum : uint {
            Default,
            BaseRule,
        }
        [NMS(Index = 3)]
        /* 0x20 */ public RuleTypeEnum RuleType;
        [NMS(Index = 0)]
        /* 0x24 */ public NMSString0x20 Name;
    }
}
