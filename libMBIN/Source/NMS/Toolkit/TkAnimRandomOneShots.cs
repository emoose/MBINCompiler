using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC1D8AB31E2DEEF57, NameHash = 0x7D3EA11C)]
    public class TkAnimRandomOneShots : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<NMSString0x10> List;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Parent;
        [NMS(Index = 2)]
        /* 0x20 */ public float DelayMax;
        [NMS(Index = 1)]
        /* 0x24 */ public float DelayMin;
    }
}
