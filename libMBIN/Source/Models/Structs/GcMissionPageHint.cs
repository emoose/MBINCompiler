using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcMissionPageHint : NMSTemplate
    {
        public int MissionPageHint;
        public string[] MissionPageHintValues()
        {
            return new[] { "None", "Suit", "Ship", "Vehicle", "Freighter", "Wiki", "MissionLog", "Discovery", "Journey" };
        }
    }
}
