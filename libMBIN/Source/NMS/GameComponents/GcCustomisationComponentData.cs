using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xC6B511D5C5B06A8E, Broken = true)]
    public class GcCustomisationComponentData : NMSTemplate
    {
		public enum CustomisationDataTypeEnum { Player, Vehicle, Weapon, Ship_01, Ship_02, Ship_03, Ship_04, Ship_05, Ship_06 }
		public CustomisationDataTypeEnum CustomisationDataType;
    }
}
