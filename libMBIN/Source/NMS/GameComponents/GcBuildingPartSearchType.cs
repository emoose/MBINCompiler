using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x59231321C9A913A8, NameHash = 0xAEBE0762190D9B2)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
		public enum BuildPartSearchTypeEnum { Base, Freighter, AllPlayerOwned, OtherPlayerBase }
		public BuildPartSearchTypeEnum BuildPartSearchType;
        public List<GcPersistentBaseTypes> BaseSearchFilters;
        public bool IncludeOnlyOverlappingBases;
        public bool IncludeGlobalBaseObjects;
    }
}
