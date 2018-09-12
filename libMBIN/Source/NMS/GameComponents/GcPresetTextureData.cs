namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7DFFC6F281EA6394)]
    public class GcPresetTextureData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Name;
        [NMS(Size = 0x100)]
        public string Filename;
    }
}
