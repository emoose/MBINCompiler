using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B3463652C929012, NameHash = 0x952196ED)]
    public class GcModSettings : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcModSettingsInfo> Data;
        [NMS(Index = 0)]
        /* 0x10 */ public bool DisableAllMods;
    }
}
