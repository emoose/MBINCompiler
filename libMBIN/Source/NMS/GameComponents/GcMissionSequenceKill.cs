namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24BF6D662F244AB, NameHash = 0xF2F929BD28DDCD6B)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        // size: 0xD
        public enum KillTargetEnum : uint {
            Robots,
            Drones,
            Quads,
            Walkers,
            Predators,
            Creatures,
            Pirates,
            Traders,
            Fiends,
            HazardousFlora,
            Worms,
            CorruptSentinels,
            CorruptPillars,
        }
        /* 0x80 */ public KillTargetEnum KillTarget;
        /* 0x84 */ public int AmountMin;
        /* 0x88 */ public int AmountMax;
        /* 0x8C */ public NMSString0x80 DebugText;
    }
}
