using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFD9990071C5EADD2, NameHash = 0xE70B813560D9BFCE)]
    public class GcProceduralProductCategory : NMSTemplate
    {
        // size: 0xD
		public enum ProceduralProductCategoryEnum { Loot, Document, BioSample, Fossil, Plant, Tool, Farm, SeaLoot, SeaHorror, Salvage, Bones, SpaceHorror, SpaceBones }
		public ProceduralProductCategoryEnum ProceduralProductCategory;
    }
}
