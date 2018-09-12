namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7621C399D9CFCEE)]
    public class TkNGuiLayoutListData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 0x80)]
        public string Default;
    }
}
