using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x64AA97FB40881F68, NameHash = 0x6955787592193D13)]
    public class TkAnimationDataTable : NMSTemplate
    {
        /* 0x0 */ public List<TkAnimationData> Table;
    }
}
