using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCB161CEA03C1B30F, NameHash = 0x5ED90B1D007B2123)]
    public class GcRewardDestructTable : NMSTemplate
    {
        // size: 0x9
        public enum CategoriesEnum {
            Fuel,
            Metal,
            Catalyst,
            Stellar,
            Flora,
            Earth,
            Exotic,
            Special,
            BuildingPart
        }
        [NMS(Size = 0x9, EnumType = typeof(CategoriesEnum))]
        /* 0x0 */ public GcRewardDestructRarities[] Categories;
    }
}
