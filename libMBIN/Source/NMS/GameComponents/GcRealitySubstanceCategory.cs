namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6B88061EEAA9975A, NameHash = 0x13D76408C6BF207D)]
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        // size: 0x9
        public enum SubstanceCategoryEnum {
            Fuel,
            Metal,
            Catalyst,
            Stellar,
            Flora,
            Earth,
            Exotic,
            Special,
            BuildingPart,
        }
        /* 0x0 */ public SubstanceCategoryEnum SubstanceCategory;
    }
}
