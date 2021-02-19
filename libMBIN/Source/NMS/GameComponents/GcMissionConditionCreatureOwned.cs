using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x6CF32D5B93742139, NameHash = 0x1518FAA28FFA87F7)]
    public class GcMissionConditionCreatureOwned : NMSTemplate
    {
        public int Amount;
        public TkEqualityEnum Test;
    }
}
