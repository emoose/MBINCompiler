namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x820765B29553ADDD)]
    public class GcHUDImageData : NMSTemplate
    {
        public GcHUDComponent Data;

        [NMS(Size = 0x80)]
        public string Image;

        public Colour Colour;
    }
}
