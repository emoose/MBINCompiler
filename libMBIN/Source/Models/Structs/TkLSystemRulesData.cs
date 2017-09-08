using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class TkLSystemRulesData : NMSTemplate
    {
        public List<TkLSystemGlobalRestriction> GlobalRestriction;

        public List<TkLSystemGlobalVariation> GlobalVariation;

        public List<TkLSystemRule> Rules;

        public List<TkLSystemRuleTemplate> Templates;
    }
}
