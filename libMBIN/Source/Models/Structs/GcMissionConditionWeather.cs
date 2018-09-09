namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x3, GUID = 0x7E964EBCC31CF4FD)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        public bool IsExtreme;
        public bool StormActive;
        public bool IgnoreStormIfInShip;
    }
}
