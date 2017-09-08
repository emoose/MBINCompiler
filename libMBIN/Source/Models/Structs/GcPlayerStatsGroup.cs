using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcPlayerStatsGroup : NMSTemplate // 0x28 bytes
    {
        [NMS(Size = 0x10)]
        public string GroupId;

        public ulong Address;

        public List<GcPlayerStat> Stats;
    }
}
