namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyRenderAnostreakData : NMSTemplate      // size: 0x30, Used in GalaxyGlobals
    {
        /* 0x00 */ public Colour OuterColour;
        /* 0x10 */ public Colour InnerColour;
        /* 0x20 */ public float VerticalCompression;        // 3E99999Ah
        /* 0x24 */ public float HorizontalScale;            // 3DCCCCCDh
        /* 0x28 */ public float Contrast;                   // 3F000000h
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
