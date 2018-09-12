namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8DFD6BA61E73EA24)]
    public class GcStatsEnum : NMSTemplate     // size: 0x4
    {
		public enum StatEnum { None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND, QUADS_KILLED, WALKERS_KILLED }
		public StatEnum Stat;
    }
}
