using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1B0A3F171F260450, NameHash = 0x80538FB9394B74CA)]
    public class GcBaseBuildingFamily : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        // size: 0x2
        public enum FamilyTypeEnum {
            Replacements,
            Extras,
        }
        /* 0x10 */ public FamilyTypeEnum FamilyType;
        /* 0x18 */ public List<NMSString0x10> ObjectIDs;
    }
}
