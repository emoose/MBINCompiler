using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x1CCB7BDC1ECBB02A, NameHash = 0x0C64AF7F76101CD0)]
    public class GcMessageCrime : NMSTemplate
    {
        // 0xD entries
        public enum CrimeEnum { AttackCreature, AttackSentinel, AttackSentinelLaser, KillCreature, KillSentinel, MineResources,
            HitResources, AttackSpaceStation, AttackShip, AttackPolice, KillShip, KillPolice, TimedShootable
        }
		/* 0x00 */ public CrimeEnum Crime;
        /* 0x10 */ public Vector3f Position;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x20 */ public byte[] Padding20;
        /* 0x28 */ public int Value;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] EndPadding;
    }
}
