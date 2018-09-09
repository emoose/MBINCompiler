namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F7836692C9FF6FC1)]
    public class GcTextPreset : NMSTemplate
    {
        public GcFontTypesEnum FontType;
        public NMSTemplate TextStyle;

        public float Height;
        public Colour Colour;
    }
}
