using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0A4AD9DD295880EED)]
    public class GcPlanetLife : NMSTemplate
    {
		public enum LifeSettingEnum { Dead, Low, Mid, Full }
		public LifeSettingEnum LifeSetting;
    }
}
