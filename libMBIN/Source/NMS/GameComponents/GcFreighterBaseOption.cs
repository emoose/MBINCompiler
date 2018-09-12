using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x84, GUID = 0x0EFADC778D8A5950B)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string BaseDataFile;
        public float ProbabilityWeighting;
    }
}
