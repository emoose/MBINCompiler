using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0BD8A1BAD12326FE2)]
    public class GcAISpaceshipInstanceData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
    }
}
