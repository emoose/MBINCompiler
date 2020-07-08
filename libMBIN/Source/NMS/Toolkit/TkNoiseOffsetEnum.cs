using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, GUID = 0x63660285B883E92D, NameHash = 0xFCAC758E3056BFEF)]
    public class TkNoiseOffsetEnum : NMSTemplate
    {
		public enum OffsetTypeEnum { Zero, Base, All, SeaLevel }
		public OffsetTypeEnum OffsetType;
    }
}