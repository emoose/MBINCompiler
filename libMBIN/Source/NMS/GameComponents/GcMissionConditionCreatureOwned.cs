using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x7E13B6505AC7D5A6, NameHash = 0x1518FAA28FFA87F7)]
    public class GcMissionConditionCreatureOwned : NMSTemplate
    {
        public int Amount;
        public TkEqualityEnum Test;
        public NMSString0x10 SpecificCreatureID;
    }
}
