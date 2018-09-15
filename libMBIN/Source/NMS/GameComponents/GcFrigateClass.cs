using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAB2EFFD5A99D806E)]
    public class GcFrigateClass : NMSTemplate
    {
		public enum FrigateClassEnum { Combat, Exploration, Mining, Diplomacy, Support }
		public FrigateClassEnum FrigateClass;
    }
}
