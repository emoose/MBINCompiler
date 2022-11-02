using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE8C45901F234670, NameHash = 0x68651D6CBA2152DE)]
    public class GcNPCColourTable : NMSTemplate
    {
        /* 0x0 */ public List<GcNPCColourGroup> Groups;
    }
}
