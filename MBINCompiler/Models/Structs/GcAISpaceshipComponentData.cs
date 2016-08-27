namespace MBINCompiler.Models.Structs
{
    public class GcAISpaceshipComponentData : NMSTemplate
    {
        public GcAISpaceshipTypes ShipType;
        public GcSpaceshipClasses ShipClass;
        public GcPrimaryAxis PrimaryAxis;
        [NMS(Size = 0x10)]
        public string Weapon;
    }
}
