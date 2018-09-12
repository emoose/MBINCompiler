using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x45F4D7DA51BD1510)]
    public class GcHazardModifiers : NMSTemplate
    {
		public enum HazardModifierEnum { Temperature, Toxicity, Radiation, LifeSupportDrain }
		public HazardModifierEnum HazardModifier;
    }
}
