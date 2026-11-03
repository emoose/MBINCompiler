using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CB9594378169D51, NameHash = 0xA34F6515)]
    public class GcCutSceneTriggerInputData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcCutSceneTriggerActionData> Actions;
        // size: 0xD
        public enum CutSceneKeyPressEnum : uint {
            _1,
            _2,
            _3,
            _4,
            _5,
            _6,
            _7,
            _8,
            _9,
            PadUp,
            PadDown,
            PadLeft,
            PadRight,
        }
        [NMS(Index = 0)]
        /* 0x10 */ public CutSceneKeyPressEnum CutSceneKeyPress;
    }
}
