namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x1C0, GUID = 0x754C3A88EF346A75)]
    public class GcNPCAnimationsData : NMSTemplate
    {
        public GcNPCAnimationSetData StandingAnimatons;
        public GcNPCAnimationSetData StandingIPadAnimatons;
        public GcNPCAnimationSetData SittingAnimatons;
        public GcNPCAnimationSetData SittingIPadAnimatons;
    }
}
