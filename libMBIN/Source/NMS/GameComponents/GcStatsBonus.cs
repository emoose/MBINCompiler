using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0xEE5DBAAC1719BE35, NameHash = 0xBAC710ADD80D9C59)]
    public class GcStatsBonus : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes StatsTypes;
        /* 0x04 */ public float Bonus;
        /* 0x08 */ public int Level;
    }
}
