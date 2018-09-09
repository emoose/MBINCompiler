namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7C37DF476B1CF236)]
    public class GcExactResource : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        public GcSeed GenerationSeed;
    }
}
