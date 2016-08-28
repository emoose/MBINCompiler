using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcPlayerStatsGroup : NMSTemplate
    {
        public string GroupId;

        public string Address;

        public List<GcPlayerStat> Stats;
    }
}
