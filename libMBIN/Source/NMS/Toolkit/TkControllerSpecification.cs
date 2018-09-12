namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x25CCF6A206E9514F)]
    public class TkControllerSpecification : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public TkButtonImageLookup ImageLookup;
    }
}
