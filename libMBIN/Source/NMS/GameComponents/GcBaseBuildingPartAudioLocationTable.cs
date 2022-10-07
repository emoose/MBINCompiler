using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBB1B3A17887CC5D, NameHash = 0x6E17046D2670AB02)]
    public class GcBaseBuildingPartAudioLocationTable : NMSTemplate
    {
        /* 0x0 */ public List<GcBaseBuildingPartAudioLocationEntry> AudioLocations;
    }
}
