using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEEB2E8E5ED50946A, NameHash = 0xBA72D7FB7D17FABE)]
    public class GcMinimumUseConstraint : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Modules;
        /* 0x10 */ public int MinUses;
        /* 0x18 */ public NMSString0x10 Group;
    }
}
