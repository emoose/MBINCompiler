using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xED77BBD7595FB24A, NameHash = 0xAEBE0762190D9B2)]
    public class GcBuildingPartSearchType : NMSTemplate
    {
        // size: 0x4
        public enum BuildPartSearchTypeEnum : uint {
            Base,
            Freighter,
            AllPlayerOwned,
            OtherPlayerBase,
        }
        /* 0x00 */ public BuildPartSearchTypeEnum BuildPartSearchType;
        /* 0x08 */ public List<GcPersistentBaseTypes> BaseSearchFilters;
        /* 0x18 */ public bool IncludeOnlyOverlappingBases;
        /* 0x19 */ public bool IncludeGlobalBaseObjects;
    }
}
