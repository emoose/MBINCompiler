using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x35CB9401CD0A85CA, NameHash = 0x864FCB26DF972FCF)]
    public class GcPlayerTitle : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A Title;
        /* 0x30 */ public NMSString0x20A UnlockDescription;
        /* 0x50 */ public NMSString0x20A AlreadyUnlockedDescription;
        /* 0x70 */ public NMSString0x10 RevealedBy;
        /* 0x80 */ public NMSString0x10 UnlockedByProductRecipe;
        /* 0x90 */ public NMSString0x10 UnlockedByMission;
        /* 0xA0 */ public NMSString0x10 UnlockedByTrophy;
        /* 0xB0 */ public NMSString0x10 UnlockedByStat;
        /* 0xC0 */ public float UnlockedByStatValue;
        /* 0xC4 */ public int UnlockedByLeveledStatRank;
        /* 0xC8 */ public GcInteractionType UnlockedByInteraction;
        /* 0xCC */ public int UnlockedByInteractionIndex;
        /* 0xD0 */ public GcAlienRace UnlockedByInteractionRace;
        /* 0xD4 */ public bool UnlockedByInteractionOnlyTestMainRaces;
    }
}
