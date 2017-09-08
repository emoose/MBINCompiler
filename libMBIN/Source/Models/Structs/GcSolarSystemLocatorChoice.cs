namespace libMBIN.Models.Structs
{
    public class GcSolarSystemLocatorChoice : NMSTemplate       // size: 0x2C
    {
        /* 0x00 */ public int Choice;
        public string[] ChoiceValues()
        {
            return new[] { "LookupName", "AnyOfType", "SpecificIndex", "InFrontOfPlayer" };
        }

        [NMS(Size = 0x20)]
        /* 0x04 */ public string Name;
        /* 0x24 */ public GcSolarSystemLocatorTypes LocatorType;
        /* 0x28 */ public int Index;
    }
}
