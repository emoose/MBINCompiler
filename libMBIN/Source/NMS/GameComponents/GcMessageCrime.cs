namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1CCB7BDC1ECBB02A, NameHash = 0xC64AF7F76101CD0)]
    public class GcMessageCrime : NMSTemplate
    {
        // size: 0xD
        public enum CrimeEnum {
            AttackCreature,
            AttackSentinel,
            AttackSentinelLaser,
            KillCreature,
            KillSentinel,
            MineResources,
            HitResources,
            AttackSpaceStation,
            AttackShip,
            AttackPolice,
            KillShip,
            KillPolice,
            TimedShootable
        }
        /* 0x00 */ public CrimeEnum Crime;
        /* 0x10 */ public Vector3f Position;
        /* 0x20 */ public GcNodeID Criminal;
        /* 0x24 */ public GcNodeID Victim;
        /* 0x28 */ public int Value;
    }
}
