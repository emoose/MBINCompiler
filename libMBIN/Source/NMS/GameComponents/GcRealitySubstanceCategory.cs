namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB8AEC505B7A3D24, NameHash = 0x5031CC7B)]
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        // size: 0x9
        public enum SubstanceCategoryEnum : uint {
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
        [NMS(Index = 0)]
        /* 0x0 */ public SubstanceCategoryEnum SubstanceCategory;
    }
}
