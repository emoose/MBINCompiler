namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x18, GUID = 0x0FECDFAAE257D62DC)]
    public class GcNPCProbabilityAnimationData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public float Probability;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
