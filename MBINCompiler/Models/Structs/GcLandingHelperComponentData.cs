namespace MBINCompiler.Models.Structs
{
    public class GcLandingHelperComponentData : NMSTemplate
    {
        public float ActiveDistanceMin;
        public float ActiveDistanceMax;
        public bool LandPoint;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding9;
    }
}
