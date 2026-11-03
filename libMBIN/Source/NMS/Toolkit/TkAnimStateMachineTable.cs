using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8A927DBF0555A139, NameHash = 0xB6917754)]
    public class TkAnimStateMachineTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkLayeredAnimStateMachineData> Table;
    }
}
