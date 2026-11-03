using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A7E6848B9AE1C38, NameHash = 0xB330B032)]
    public class GcMinimumUseConstraint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 Group;
        [NMS(Index = 0)]
        /* 0x10 */ public List<NMSString0x10> Modules;
        [NMS(Index = 1, MxmlName = "Min Uses")]
        /* 0x20 */ public int MinUses;
    }
}
