using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB9D61CFC45A85BA, NameHash = 0x80538FB9394B74CA)]
    public class GcBaseBuildingFamily : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        // size: 0x2
        public enum FamilyTypeEnum : uint {
            Replacements,
            Extras,
        }
        /* 0x10 */ public FamilyTypeEnum FamilyType;
        /* 0x18 */ public List<NMSString0x10> ObjectIDs;
    }
}
