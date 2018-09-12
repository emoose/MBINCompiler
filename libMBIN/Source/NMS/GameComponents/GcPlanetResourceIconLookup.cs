namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x118, GUID = 0x0CE724D5DF7B4C68E)]
    public class GcPlanetResourceIconLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string ID;
        public TkTextureResource Icon;
        public TkTextureResource IconBinocs;
    }
}
