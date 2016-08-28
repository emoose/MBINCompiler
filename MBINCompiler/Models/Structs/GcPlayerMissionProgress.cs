namespace MBINCompiler.Models.Structs
{
    public class GcPlayerMissionProgress : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 0x10)]
        public string Mission;
        public int Progress;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
