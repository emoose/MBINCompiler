namespace MBINCompiler.Models.Structs
{
    public class GcWordKnowledge : NMSTemplate // 0x18
    {
        [NMS(Size = 0x10)]
        public string Word;

        [NMS(Size = 6)]
        public bool[] Races;

        [NMS(Size = 2, Ignore = true)]
        public byte[] Padding16;
    }
}
