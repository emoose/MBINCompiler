namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0B311727CC90EC0B2)]
    public class TkControllerButtonLookup : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string ButtonImageLookupFilename;
    }
}
