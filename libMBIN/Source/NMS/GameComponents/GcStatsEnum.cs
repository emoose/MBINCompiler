using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xF28A9BF702A385FF, NameHash = 0xACDE6E8DA19EC2E2)]
    public class GcStatsEnum : NMSTemplate
    {
        // 0xC entries
		public enum StatEnum {
            None, DEPOTS_BROKEN, FPODS_BROKEN, PLANTS_PLANTED, SALVAGE_LOOTED, TREASURE_FOUND, QUADS_KILLED, WALKERS_KILLED, FLORA_KILLED, PLANTS_GATHERED,
            BONES_FOUND, C_SENT_KILLS
        }
		public StatEnum Stat;
    }
}