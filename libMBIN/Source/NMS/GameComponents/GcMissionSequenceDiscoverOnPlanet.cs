using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x108, GUID = 0x0350697CF0829EFA, NameHash = 0x00368D06565D9CC1)]
    public class GcMissionSequenceDiscoverOnPlanet : NMSTemplate
    {
        /* 0x00 */ public float PercentToDiscover;
        [NMS(Size = 0x80)]
        /* 0x04 */ public string Message;
        public enum DiscoverTargetOnThisPlanetEnum { Animal, Vegetable, Mineral };
        /* 0x84 */ public DiscoverTargetOnThisPlanetEnum DiscoverTargetOnThisPlanet;
        [NMS(Size = 0x80)]
        /* 0x88 */ public string DebugText;
    }
}
