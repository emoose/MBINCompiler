namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x10B96B017A55BF39)]
    public class TkNGuiAlignment : NMSTemplate
    {

		public enum VerticalEnum { Top, Middle, Bottom }
		public VerticalEnum Vertical;


		public enum HorizontalEnum { Left, Center, Right }
		public HorizontalEnum Horizontal;
    }
}
