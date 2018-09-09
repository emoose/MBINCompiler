namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x68F78A981C698B29)]
    public class GcTextStyleOutline : NMSTemplate
    {
        public Colour OutlineColour;
        public Vector2f OutlineOffset;

        [NMS(Size = 8, Ignore = true)]
        public byte[] Padding18;
    }
}
