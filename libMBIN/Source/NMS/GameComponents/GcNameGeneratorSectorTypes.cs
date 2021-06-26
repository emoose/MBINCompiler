using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x3B01C230DC8E0D75, NameHash = 0x2FBB792E633BA89B)]
    public class GcNameGeneratorSectorTypes : NMSTemplate
    {
		public enum SectorNameEnum { Generic, Elevanted, Low, Trees, LushTrees, Lush, Wet, Cave, Dead, Buildings, Water, Ice }
		public SectorNameEnum SectorName;
    }
}