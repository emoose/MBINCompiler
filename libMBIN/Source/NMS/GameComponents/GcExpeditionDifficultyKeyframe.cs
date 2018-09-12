using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x10B8D55460ACA45A)]
    public class GcExpeditionDifficultyKeyframe : NMSTemplate
    {
        public int EventNumber;
        public float Difficulty;
    }
}
