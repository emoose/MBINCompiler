namespace libMBIN.Models.Structs
{
    public class GcShipHUDTargetIconData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Corner;
        [NMS(Size = 0x80)]
        public string LineHorizontal;
        [NMS(Size = 0x80)]
        public string LineVertical;

        [NMS(Size = 0x80)]
        public string GlowCorner;
        [NMS(Size = 0x80)]
        public string GlowLineHorizontal;
        [NMS(Size = 0x80)]
        public string GlowLineVertical;
    }
}
