using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionDifficulty : NMSTemplate
    {
        public int MissionDifficulty;
        public string[] MissionDifficultyValues()
        {
            return new[] { "Easy", "Normal", "Hard"};
        }
    }
}
