namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x17C1F3DED0C039C3)]
    public class GcAlienRace : NMSTemplate
    {
        public enum AlienRaceEnum { Traders, Warriors, Explorers, Robots, Atlas, Diplomats, None }
        public AlienRaceEnum AlienRace;
    }
}
