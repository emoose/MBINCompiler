using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCE8501F13500B7C3, NameHash = 0x3CA3D3FD)]
    public class TkAudioIDArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x80> Array;
    }
}
