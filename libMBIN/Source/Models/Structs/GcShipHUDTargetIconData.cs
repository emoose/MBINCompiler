namespace MBINCompiler.Models.Structs
{
    public class GcShipHUDTargetIconData : NMSTemplate      // starts at 0x6F0 in the GcGameplayGlobals
    {
        [NMS(Size = 0x80)]
        public string Corner;
        [NMS(Size = 0x80)]
        public string LineHorizontal;
        [NMS(Size = 0x80)]
        public string LineVertical;

        [NMS(Size = 0x80)]
        public string GlowCorner;
        [NMS(Size = 0x80)]
        public string GlowLineHorizontal;
        [NMS(Size = 0x80)]
        public string GlowLineVertical;
    }
}
