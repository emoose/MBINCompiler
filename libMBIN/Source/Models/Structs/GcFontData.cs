namespace libMBIN.Models.Structs
{
	public class GcFontData : NMSTemplate
	{
		[NMS(Size = 0x80)]
		public string File;
		public int MinCharWidth;
	}
}
