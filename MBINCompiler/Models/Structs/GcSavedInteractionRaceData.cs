namespace MBINCompiler.Models.Structs
{
    public class GcSavedInteractionRaceData : NMSTemplate // 0x18 bytes
    {
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        public int[] SavedRaceIndicies;
    }
}
