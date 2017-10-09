namespace libMBIN.Models.Structs
{
    public class GcAISpaceshipManagerData : NMSTemplate     // size: 0x50
    {
        [NMS(Size = 5, EnumValue = new string[5] { "Player", "Civilian", "Pirate", "Police", "Creature" })]
        public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
