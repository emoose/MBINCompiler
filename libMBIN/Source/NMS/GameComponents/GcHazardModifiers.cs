namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x960462B9ECDD61FB, NameHash = 0x7B36FAC2)]
    public class GcHazardModifiers : NMSTemplate
    {
        // size: 0x6
        public enum HazardModifierEnum : uint {
            Temperature,
            Toxicity,
            Radiation,
            LifeSupportDrain,
            Gravity,
            SpookLevel,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HazardModifierEnum HazardModifier;
    }
}
