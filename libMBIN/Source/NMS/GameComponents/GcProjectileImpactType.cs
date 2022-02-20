using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x50CA7C2BFEAF3E62, NameHash = 0xC652A220FFABA4FE)]
    public class GcProjectileImpactType : NMSTemplate
    {
        // size: 0x10
        public enum ImpactEnum { Default, Terrain, Substance, Rock, Asteroid, Shield, Creature, Robot, Freighter,
            Cargo, Ship, Plant, NeedsTech, Player, OtherPlayer, SentinelShield
        }
        /* 0x0 */ public ImpactEnum Impact;
    }
}
