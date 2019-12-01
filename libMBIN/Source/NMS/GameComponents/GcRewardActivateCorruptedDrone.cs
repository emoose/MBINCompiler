using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x14583EC906B5D712, NameHash = 0xCA4D2B1DC7089D9D)]
    public class GcRewardActivateCorruptedDrone : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string EncounterComponentScanEvent;
    }
}
