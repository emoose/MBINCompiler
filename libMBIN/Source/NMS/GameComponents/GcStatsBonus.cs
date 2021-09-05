using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x766777B9B15B180C, NameHash = 0xBAC710ADD80D9C59)]
    public class GcStatsBonus : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes StatsTypes;
        /* 0x04 */ public float Bonus;
        /* 0x08 */ public int Level;
    }
}
