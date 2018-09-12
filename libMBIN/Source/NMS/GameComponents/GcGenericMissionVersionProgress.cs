using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, Alignment = 0x4, GUID = 0x622F8F6552A40D7E)]
    public class GcGenericMissionVersionProgress : NMSTemplate
    {
        public int Version;
        public int Progress;
    }
}
