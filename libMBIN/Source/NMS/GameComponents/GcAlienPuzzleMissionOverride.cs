namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D2E6ACCD0E0D8B3, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Mission;
        /* 0x10 */ public NMSString0x20A Puzzle;
        /* 0x30 */ public bool ForceMissionSeed;
        /* 0x38 */ public NMSString0x10 AltPriorityMissionForSelection;
    }
}
