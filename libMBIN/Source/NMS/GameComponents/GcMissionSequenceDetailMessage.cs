using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3690284308F0CBD, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Title;
        /* 0x20 */ public NMSString0x20A Description;
        /* 0x40 */ public NMSString0x20A Image;
        /* 0x60 */ public NMSString0x10 TakeImageFromItemIcon;
        /* 0x70 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x78 */ public List<GcMissionSequenceDetailMessagePoint> Points;
        /* 0x88 */ public bool TakeDataFromSeason;
        /* 0x89 */ public NMSString0x80 DebugText;
    }
}
