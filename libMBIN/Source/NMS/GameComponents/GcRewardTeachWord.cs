using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xCE34A571B19B7E94)]
    public class GcRewardTeachWord : NMSTemplate
    {
        public GcAlienRace Race;
        public int AmountMin;
        public int AmountMax;
    }
}
