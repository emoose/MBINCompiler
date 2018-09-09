namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9F99427CD6CB8D5C)]
	public class GcFontData : NMSTemplate
	{
		[NMS(Size = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
