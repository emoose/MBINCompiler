using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0B35A1B2E01D63, NameHash = 0x5D3C52EE)]
    public class GcModularCustomisationProductLookupList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x10> ProductLookupList;
    }
}
