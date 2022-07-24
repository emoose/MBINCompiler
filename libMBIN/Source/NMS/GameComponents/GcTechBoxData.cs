using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xA8, GUID = 0xEBC5AFAC641185EF, NameHash = 0x3839C255F197D92C)]
    public class GcTechBoxData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public NMSString0x10 InstallTechID;
        /* 0x20 */ public TkTextureResource Icon;
        /* 0xA4 */ public bool IsAlien;
    }
}
