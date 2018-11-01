using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xD9271B3AD338246A)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0x9
		public enum ProceduralProductCategoryEnum { Loot, Document, BioSample, Fossil, Plant, Tool, Farm, SeaLoot, SeaHorror }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
