using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x892A87B15555ABAB, NameHash = 0xBAC710ADD80D9C59)]
    public class GcStatsBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes Stat;
        /* 0x4 */ public float Bonus;
        /* 0x8 */ public int Level;
    }
}
