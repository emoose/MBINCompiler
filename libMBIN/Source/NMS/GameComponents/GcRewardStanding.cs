using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDFD67C5C01B2BBA, NameHash = 0x3E2901921A11B02D)]
    public class GcRewardStanding : NMSTemplate
    {
        /* 0x0 */ public GcAlienRace Race;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public int AmountMax;
    }
}
