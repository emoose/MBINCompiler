namespace MBINCompiler.Models.Structs
{
    public class GcStatsEntry : NMSTemplate
    {
        public GcStatsTypes Type;
        public Colour Colour;
        public float RangeMin;
        public float RangeMax;
        public bool LessIsBetter;

        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
