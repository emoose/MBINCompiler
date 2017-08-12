using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionBoardOptions : NMSTemplate        // size: 0x20
    {
        public GcMissionType Type;
        public GcMissionDifficulty Difficulty;
        public int MinRank;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] PaddingC;
        public GcMissionFaction Faction;                    // maybe?
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] EndPadding;                           // I think something is a bit wrong... will need to compare with hex
    }
}
