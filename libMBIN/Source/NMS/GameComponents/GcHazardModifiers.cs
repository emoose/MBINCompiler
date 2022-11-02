namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39C52F7E5E314CD4, NameHash = 0x8D86E8499B88B845)]
    public class GcHazardModifiers : NMSTemplate
    {
        // size: 0x5
        public enum HazardModifierEnum {
            Temperature,
            Toxicity,
            Radiation,
            LifeSupportDrain,
            Gravity
        }
        /* 0x0 */ public HazardModifierEnum HazardModifier;
    }
}
