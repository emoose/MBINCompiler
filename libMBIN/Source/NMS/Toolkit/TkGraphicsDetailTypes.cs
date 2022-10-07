namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xEC040260D3EBB1E1, NameHash = 0xAACA1A6A0194D948)]
    public class TkGraphicsDetailTypes : NMSTemplate
    {
        // size: 0x4
        public enum GraphicDetailEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        /* 0x0 */ public GraphicDetailEnum GraphicDetail;
    }
}
