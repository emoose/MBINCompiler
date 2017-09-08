namespace MBINCompiler.Models.Structs
{
    public class TkAnimPoseExampleElement : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Anim;
        public float Value;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
