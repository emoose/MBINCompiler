using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x823886A930D89F4F, NameHash = 0x29EEF8B053EA8F56)]
    public class GcMechMeshPartTypeData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 LocatorNodeName;
        /* 0x20 */ public NMSString0x10 RequiredTechs;
    }
}
