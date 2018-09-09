namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0FDC76CC341CDC6F9)]
    public class GcAtlasMessage : NMSTemplate
    {
        public GcUniverseAddressData UniverseAddress;
        [NMS(Size = 0x80)]
        public string CustomName;
        public Vector4f Positon;
        public int ColourIndex;
    }
}
