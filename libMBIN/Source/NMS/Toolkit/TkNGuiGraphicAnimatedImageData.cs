namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9AD0065D93A5CF9C, NameHash = 0x3198A29C)]
    public class TkNGuiGraphicAnimatedImageData : NMSTemplate
    {
        [NMS(Index = 4, MxmlName = "Frames Horizontal")]
        /* 0x00 */ public int FramesHorizontal;
        [NMS(Index = 2, MxmlName = "Frames Per Second")]
        /* 0x04 */ public float FramesPerSecond;
        [NMS(Index = 5, MxmlName = "Frames Vertical")]
        /* 0x08 */ public int FramesVertical;
        // size: 0x3
        public enum NGuiImageAnimTypeEnum : uint {
            None,
            Animated,
            Scrolling,
        }
        [NMS(Index = 0)]
        /* 0x0C */ public NGuiImageAnimTypeEnum NGuiImageAnimType;
        [NMS(Index = 6, MxmlName = "Scroll Angle")]
        /* 0x10 */ public float ScrollAngle;
        [NMS(Index = 7, MxmlName = "Scroll Speed")]
        /* 0x14 */ public float ScrollSpeed;
        [NMS(Index = 3, MxmlName = "Total Frames")]
        /* 0x18 */ public int TotalFrames;
        [NMS(Index = 1, MxmlName = "Blend Frames")]
        /* 0x1C */ public bool BlendFrames;
    }
}
