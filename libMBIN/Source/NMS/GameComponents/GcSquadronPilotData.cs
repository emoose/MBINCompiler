using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x558, GUID = 0x68E27A3C3EF27F5F, NameHash = 0x1B17AE774F200920)]
    public class GcSquadronPilotData : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement NPCResource;
        /* 0x2A8 */ public GcResourceElement ShipResource;
        /* 0x550 */ public ushort PilotRank;
    }
}
