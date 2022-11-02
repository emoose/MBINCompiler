using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xFE673F3AF6646F81, NameHash = 0x75302EADC2AAED35)]
    public class TkTrophyData : NMSTemplate
    {
        /* 0x0 */ public List<TkTrophyEntry> Trophies;
    }
}
