using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8585E00EE8E6D88F, NameHash = 0x7AC176B8)]
    public class TkNamedAudioIdArray : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x80> Values;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 Name;
    }
}
