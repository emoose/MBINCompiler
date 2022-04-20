using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x90AFF8495F58C9E3, NameHash = 0xC5B9CCD1978B8755)]
    public class GcCharacterCustomisationSaveData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SelectedPreset;
        /* 0x10 */ public GcCharacterCustomisationData CustomData;
    }
}
