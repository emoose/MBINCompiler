using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x7108DBB887084D1D, NameHash = 0x8CBF91F9F8428E08)]
    public class GcAISpaceshipTypes : NMSTemplate
    {
        // size: 0x6
        public enum ShipTypeEnum { None, Pirate, Police, Trader, Freighter, PlayerSquadron }
        /* 0x0 */ public ShipTypeEnum ShipType;
    }
}
