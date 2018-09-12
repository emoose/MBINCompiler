namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7D59746106C3F196)]
    public class GcTextStyleShadow : NMSTemplate
    {
        public Colour ShadowColour;
        public Vector2f ShadowOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
