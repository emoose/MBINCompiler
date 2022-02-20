using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x844B5F07E24CC3FA, NameHash = 0x80ED6EE04AC8D620)]
    public class GcProceduralTechnologyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcProceduralTechnologyData> Table;
    }
}
