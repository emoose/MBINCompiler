using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xF8, GUID = 0x15D122F716C8436A, NameHash = 0xA29EE4D703004484)]
    public class GcMissionSequenceDetailMessage : NMSTemplate
    {
        public NMSString0x20A Title;
        public NMSString0x20A Description;
        public NMSString0x20A Image;
        public GcAudioWwiseEvents AudioEvent;
        public List<GcMissionSequenceDetailMessagePoint> Points;
        public NMSString0x80 DebugText;
    }
}
