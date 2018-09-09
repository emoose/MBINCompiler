namespace libMBIN.Models.Structs
{
	[NMS(Size = 0xC, GUID = 0x68601FD70868482F)]
    public class GcStatsBonus : NMSTemplate
    {
        public GcStatsTypes StatsTypes;
        public float Bonus;
        public int Level;
    }
}
