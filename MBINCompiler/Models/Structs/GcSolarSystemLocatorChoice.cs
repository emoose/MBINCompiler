namespace MBINCompiler.Models.Structs
{
    public class GcSolarSystemLocatorChoice : NMSTemplate
    {
        public int Choice;
        public string[] ChoiceValues()
        {
            return new[] { "LookupName", "AnyOfType", "SpecificIndex", "InFrontOfPlayer" };
        }

        [NMS(Size = 0x20)]
        public string Name; // 0x20
        public GcSolarSystemLocatorTypes LocatorType;
        public int Index;
    }
}
