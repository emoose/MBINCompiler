namespace libMBIN.Models.Structs
{
    public class GcJourneyMedalType : NMSTemplate
    {
        public int MedalType;
        public string[] MedalTypeValues()
        {
            return new[] { "Standings", "Missions", "Words", "Systems", "Sentinels", "Pirates", "Plants", "Units", "RaceCreatures", "DistanceWarped" };
        }
    }
}
