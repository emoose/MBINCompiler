namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7390A977466FA75C, NameHash = 0x71B9EA7C3B789C6B)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public NMSString0x10 MissionNoGroundCombat;
        /* 0x20 */ public NMSString0x10 MissionNoSpaceCombat;
        /* 0x30 */ public bool InheritActiveMultiplayerMissionSeed;
    }
}
