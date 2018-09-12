namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x6DC0671B6D868B21)]
    public class TkButtonPathMapping : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        [NMS(Size = 0x80)]
        public string Path;
    }
}
