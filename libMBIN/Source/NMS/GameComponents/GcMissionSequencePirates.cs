using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x81, GUID = 0x49DC5CF05FC78D13, SubGUID = 0x9166CF1D0ED63522)]
    public class GcMissionSequencePirates : NMSTemplate
    {
        public bool ScanCargo;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
