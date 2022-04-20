using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x862CE51DFC6C9F19, NameHash = 0x94F8E55312096B6B)]
    public class GcCustomisationPresets : NMSTemplate
    {
        /* 0x0 */ public List<GcCustomisationPreset> Presets;
    }
}
