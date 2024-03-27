using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7BEC79BB9EE655A1, NameHash = 0x8ECE9ECB68A7E994)]
    public class TkLSystemRulesData : NMSTemplate
    {
        /* 0x00 */ public List<TkLSystemGlobalRestriction> GlobalRestriction;
        /* 0x10 */ public List<TkLSystemGlobalVariation> GlobalVariation;
        /* 0x20 */ public List<TkLSystemRule> Rules;
        /* 0x30 */ public List<TkLSystemRuleTemplate> Templates;
    }
}
