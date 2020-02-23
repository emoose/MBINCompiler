using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C, GUID = 0x16A3216F6E8803A4, NameHash = 0xA1AD260BA61A04EE)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
        public GcFrigateClass FrigateClass;
    }
}
