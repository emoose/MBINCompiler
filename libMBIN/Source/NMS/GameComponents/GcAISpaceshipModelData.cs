namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x68081EC8A0CFF6B9)]
    public class GcAISpaceshipModelData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string File;
        public GcSpaceshipClasses Class;
        public GcAISpaceshipRoles AIRole;
        public GcFrigateClass FrigateClass;
    }
}
