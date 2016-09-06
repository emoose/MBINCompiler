namespace MBINCompiler.Models.Structs
{
    public class GcGalaxyMarkerSettings : NMSTemplate
    {
        [NMS(Size = 3)]
        public Colour[] Colours;

        public Colour OutlineColour;
        public float OutlineWidth;

        public float EdgeCount; // template does some weird stuff with this, might be positive values only?

        public float RotationBase;

        public float LineWidth;
        public float LineWidthFade;

        public float SizeScale;

        public float RadiusMinimum;
        public float RadiusBaseOffset;
        public float RadiusEdge;

        public Vector2f TimeScaleRange;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding6C;
    }
}
