namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        public GcAISpaceshipTypes Type;
        public GcSpaceshipClasses Class;
        public GcPrimaryAxis Axis;
        [NMS(Size = 0x10)]
        public string Weapon;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding1C;
    }
}
