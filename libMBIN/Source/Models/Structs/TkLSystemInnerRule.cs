using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class TkLSystemInnerRule : NMSTemplate // 0x38 bytes
    {
        [NMS(Size = 0x20)]
        public string LocatorType;
        public int MergeProbabilityOptions;
        public string[] MergeProbabilityOptionsValues()
        {
            return new[] { "Balance", "Prioritize", "Replace" };
        }

        public List<TkLSystemLocatorEntry> Entries;
    }
}
