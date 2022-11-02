using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA2224DDB65C014B, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationPreset> Presets;
    }
}
