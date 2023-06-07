using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x47D3535505E0921C, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public NMSString0x20A Description;
        /* 0x40 */ public NMSString0x20A Image;
        /* 0x60 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x68 */ public List<GcMissionSequenceDetailMessagePoint> Points;
        /* 0x78 */ public NMSString0x80 DebugText;
    }
}
