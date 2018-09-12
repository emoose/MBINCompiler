namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FE856038031F8FF0)]
    public class GcProductCategory : NMSTemplate
    {

		public enum ProductCategoryEnum { Component, Consumable, Tradeable, Curiousity, BuildingPart, Procedural, Emote, CustomisationPart }
		public ProductCategoryEnum ProductCategory;
    }
}
