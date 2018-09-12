using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x450BDF51593CA8C9)]
    public class GcMissionBoardOptions : NMSTemplate
    {
        /* 0x00 */ public GcMissionType Type;
        /* 0x04 */ public GcMissionDifficulty Difficulty;
        /* 0x08 */ public int MinRank;
        /* 0x0C */ public bool CloseMissionGiver;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0D */ public byte[] PaddingD;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string RewardPenaltyOnAbandon;
        /* 0x20 */ public List<GcMissionFaction> Faction;
    }
}
