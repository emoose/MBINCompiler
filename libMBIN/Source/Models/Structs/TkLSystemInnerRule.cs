using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8999A8B76829CCD5)]
    public class TkLSystemInnerRule : NMSTemplate // 0x38 bytes
    {
        [NMS(Size = 0x20)]
        public string LocatorType;
		public enum MergeProbabilityOptionsEnum { Balance, Prioritize, Replace }
		public MergeProbabilityOptionsEnum MergeProbabilityOptions;

        public List<TkLSystemLocatorEntry> Entries;
    }
}
