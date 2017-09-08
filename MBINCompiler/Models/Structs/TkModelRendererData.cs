namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x70)]
    public class TkModelRendererData : NMSTemplate
    {
        public TkModelRendererCameraData Camera;
        public float Fov;
        public float AspectRatio;
        public int ThumbnailMode;
        public string[] ThumbnailModeValues()
        {
            return new[] { "None", "HUD", "GUI" };
        }
        public int FocusType;
        public string[] FocusTypeValues()
        {
            return new[] { "ResourceBounds", "ResourceBoundingHeight", "NodeBoundingBox" };
        }

        [NMS(Size = 0x10)]
        public string Anim;

        public float HeightOffset;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding64;
    }
}
