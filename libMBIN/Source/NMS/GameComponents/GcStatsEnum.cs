using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x931F765655CEDC8F, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // size: 0x10
        public enum GcStatEnumEnum { None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND,
            QUADS_KILLED, WALKERS_KILLED, FLORA_KILLED, PLANTS_GATHERED,
            BONES_FOUND, C_SENT_KILLS, STORM_CRYSTALS, BURIED_PROPS, MINIWORM_KILL,
            POOP_COLLECTED
        }
        /* 0x0 */ public GcStatEnumEnum GcStatEnum;
    }
}
