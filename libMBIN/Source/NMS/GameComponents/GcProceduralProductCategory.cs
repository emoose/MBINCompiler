namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x874D8622B2487057)]
    public class GcProceduralProductCategory : NMSTemplate
    {

		public enum ProceduralProductCategoryEnum { Loot, Document, BioSample, Fossil, Plant, Tool, Farm }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
