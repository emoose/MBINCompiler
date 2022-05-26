using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xBB2996CF7F42C21D, NameHash = 0x3339FF1DC3ABF146)]
    public class GcExperienceDebugTriggerAction : NMSTemplate
    {
        /* 0x0 */ public GcExperienceDebugTriggerActionTypes Action;
        /* 0x4 */ public int IntParameter;
    }
}
