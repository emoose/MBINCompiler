using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x88, GUID = 0x70B2586324A969F1, NameHash = 0xA1666CAA6E88F270)]
    public class GcBiomeFileListOption : NMSTemplate
    {
        public GcBiomeSubType SubType;
        [NMS(Size = 0x80)]
        public string FileName;
        public float Weight;
    }
}
