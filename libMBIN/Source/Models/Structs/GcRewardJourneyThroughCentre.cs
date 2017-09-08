namespace libMBIN.Models.Structs
{
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
        public int CentreJourneyDestination;
        public string[] CentreJourneyDestinationValues()
        {
            return new[] { "Next", "Abandoned", "Vicious", "Lush", "Balanced"};
        }
    }
}
