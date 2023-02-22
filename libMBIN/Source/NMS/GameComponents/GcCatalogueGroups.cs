namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x261CB4A6885077DC, NameHash = 0x9A93F045019746C1)]
    public class GcCatalogueGroups : NMSTemplate
    {
        // size: 0x5
        public enum CatalogueGroupEnum {
            MaterialsAndItems,
            CraftingAndTechnology,
            Buildables,
            Recipes,
            Wonders,
        }
        /* 0x0 */ public CatalogueGroupEnum CatalogueGroup;
    }
}
