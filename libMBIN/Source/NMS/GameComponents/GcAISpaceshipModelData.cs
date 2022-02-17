using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0x65908D4885FB7A4B, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        public NMSString0x80 Filename;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
        public GcFrigateClass FrigateClass;
    }
}
