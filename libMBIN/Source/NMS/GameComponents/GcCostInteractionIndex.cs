using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x5FFECA337CC7908A, NameHash = 0x8005E8FA6CB39C35)]
    public class GcCostInteractionIndex : NMSTemplate
    {
        /* 0x00 */ public GcInteractionType InteractionType;
        /* 0x04 */ public GcAlienRace Race;
        /* 0x08 */ public int Index;
        /* 0x0C */ public bool AffordIfGreaterThanIndex;
        /* 0x10 */ public NMSString0x20A CantAffordLocID;
    }
}
