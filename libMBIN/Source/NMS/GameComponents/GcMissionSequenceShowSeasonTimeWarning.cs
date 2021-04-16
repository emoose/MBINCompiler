using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x104, GUID = 0xC45A8B074F0BB2C0, NameHash = 0x232C5143BAE4E2F9)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        public float TimeToShow;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
