using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDCC50E4A9E9724D, NameHash = 0xA8FBF05C737FA4E2)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<GcSelectableObjectSpawnData> Objects;
    }
}
