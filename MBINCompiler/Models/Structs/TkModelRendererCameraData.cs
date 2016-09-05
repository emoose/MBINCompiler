namespace MBINCompiler.Models.Structs
{
    public class TkModelRendererCameraData : NMSTemplate // 0x40 bytes
    {
        public float Distance;
        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding4;

        public Vector4f Offset;
        public float Pitch;
        public float Rotate;
        public float LightPitch;
        public float LightRotate;
        public TkCameraWanderData Wander;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding3C;
    }
}
