using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD41F4B0A7C42E501, NameHash = 0x6E01B266)]
    public class TkNamedAudioIdArrayTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkNamedAudioIdArray> Array;
    }
}
