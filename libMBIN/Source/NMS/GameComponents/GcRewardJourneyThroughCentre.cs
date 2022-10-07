namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0196F209D21EB12, NameHash = 0x1D30BD6C3E0FC228)]
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
        // size: 0x5
        public enum CentreJourneyDestinationEnum {
            Next,
            Abandoned,
            Vicious,
            Lush,
            Balanced
        }
        /* 0x0 */ public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}
