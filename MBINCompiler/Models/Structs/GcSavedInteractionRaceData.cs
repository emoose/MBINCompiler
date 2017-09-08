namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x1C)]
    public class GcSavedInteractionRaceData : NMSTemplate
    {
        [NMS(Size = 7, EnumValue = new[] { "Traders", "Warriors", "Explorers", "Robots", "Atlas", "Diplomats", "None" })]
        public int[] SavedRaceIndicies;
    }
}
