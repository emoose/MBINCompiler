using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDF1F7C7B5D0B647A, NameHash = 0x7845DC8347C337B3)]
    public class TkActionButtonLookup : NMSTemplate
    {
        /* 0x0 */ public List<TkActionButtonMap> Lookup;
    }
}
