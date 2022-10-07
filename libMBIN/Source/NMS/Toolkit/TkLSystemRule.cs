using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC3D61DFE9D3AB5CD, NameHash = 0xE09F11724D654285)]
    public class TkLSystemRule : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Name;
        /* 0x20 */ public NMSString0x80 Model;
        /* 0xA0 */ public List<TkLSystemInnerRule> Rules;
        // size: 0x2
        public enum RuleTypeEnum {
            Default,
            BaseRule
        }
        /* 0xB0 */ public RuleTypeEnum RuleType;
    }
}
