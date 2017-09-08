namespace libMBIN.Models.Structs
{
    public class GcTextStyleShadow : NMSTemplate
    {
        public Colour ShadowColour;
        public Vector2f ShadowOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
