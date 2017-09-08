namespace MBINCompiler.Models.Structs
{
    public class GcBuildingFilename : NMSTemplate // 0x200 bytes
    {
        [NMS(Size = 0x80)]
        public string LSystem;
        [NMS(Size = 0x80)]
        public string Scene;
        [NMS(Size = 0x80)]
        public string UnderwaterLSystem;
        [NMS(Size = 0x80)]
        public string UnderwaterScene;
    }
}
