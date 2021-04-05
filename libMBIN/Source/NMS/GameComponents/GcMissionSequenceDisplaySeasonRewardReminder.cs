using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x84, GUID = 0x0000000000000000, NameHash = 0x6A64F8439AFA975E)]
    public class GcMissionSequenceDisplaySeasonRewardReminder : NMSTemplate
    {
        public float Time;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
