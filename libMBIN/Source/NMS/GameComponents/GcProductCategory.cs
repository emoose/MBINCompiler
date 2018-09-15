using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFE856038031F8FF0)]
    public class GcProductCategory : NMSTemplate
    {

		public enum ProductCategoryEnum { Component, Consumable, Tradeable, Curiousity, BuildingPart, Procedural, Emote, CustomisationPart }
		public ProductCategoryEnum ProductCategory;
    }
}
