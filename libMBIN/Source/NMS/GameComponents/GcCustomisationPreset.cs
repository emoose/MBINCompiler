using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x10825C911C1BD784, NameHash = 0x6B329F862808895A)]
    public class GcCustomisationPreset : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public GcCharacterCustomisationData Data;
    }
}
