using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionBoardOptions : NMSTemplate        // size: 0x20
    {
        /* 0x00 */ public GcMissionType Type;
        /* 0x04 */ public GcMissionDifficulty Difficulty;
        /* 0x08 */ public int MinRank;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0C */ public byte[] PaddingC;
        /* 0x10 */ public List<GcMissionFaction> Faction;
    }
}
