namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0F219BEB67110DE, NameHash = 0xF2F929BD28DDCD6B)]
    public class GcMissionSequenceKill : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        // size: 0xE
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
            Mechs,
        }
        /* 0x80 */ public KillTargetEnum KillTarget;
        /* 0x84 */ public int AmountMin;
        /* 0x88 */ public int AmountMax;
        /* 0x8C */ public bool UseDefaultAmount;
        /* 0x8D */ public bool AddToMissionBoardObjective;
        /* 0x8E */ public NMSString0x80 DebugText;
    }
}
