using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF5047CB5E8BC121, NameHash = 0x26962D5)]
    public class GcGameTableGameConfig : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x20A DefaultPuzzle;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A Id;
        [NMS(Index = 2)]
        /* 0x40 */ public List<NMSString0x20A> PresetAIPlayers;
        [NMS(Index = 7)]
        /* 0x50 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        [NMS(Index = 4)]
        /* 0x60 */ public NMSString0x10 RewardIdLoss;
        [NMS(Index = 3)]
        /* 0x70 */ public NMSString0x10 RewardIdWin;
        [NMS(Index = 5)]
        /* 0x80 */ public float ExperienceRewardMultiplier;
        [NMS(Index = 1)]
        /* 0x84 */ public GcGameTableMode ForcedGameMode;
    }
}
