using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x10, GUID = 0xA8E9E19BEA438001, NameHash = 0x5DE2B54C774CA122)]
    public class TkTriggerFeedbackData : NMSTemplate
    {
        public enum FeedbackTypeEnum { None, Feedback, Weapon, Vibration };
        public FeedbackTypeEnum FeedbackType;
        public float Strength;
        public float Position;
        public float Frequency;
    }
}
