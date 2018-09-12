using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E257E78487E5727A)]
    public class GcGenericIconTypes : NMSTemplate
    {
		public enum GenericIconTypeEnum { None, Interaction, SpaceStation, SpaceAnomaly, SpaceAtlas }
		public GenericIconTypeEnum GenericIconType;
    }
}
