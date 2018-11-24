using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5A10, GUID = 0xA445AFD8463EAB2)]
    public class GcProceduralProductTable : NMSTemplate
    {
        [NMS(Size = 0xB, EnumValue = new[] { "Loot", "Document", "BioSample", "Fossil", "Plant", "Tool", "Farm", "SeaLoot", "SeaHorror", "Salvage", "Bones" })]
        public GcProceduralProductData[] Table;
    }
}
