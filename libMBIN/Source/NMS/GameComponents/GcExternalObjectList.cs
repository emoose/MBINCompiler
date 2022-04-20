using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0xD7BB21DE4CA178FF, NameHash = 0xF94F95509B2D4135)]
    public class GcExternalObjectList : NMSTemplate
    {
        /* 0x0 */ public GcEnvironmentSpawnData Objects;
    }
}
