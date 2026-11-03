namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEFCF96E46F5420D5, NameHash = 0x40464A60)]
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
        // size: 0x5
        public enum CentreJourneyDestinationEnum : uint {
            Next,
            Abandoned,
            Vicious,
            Lush,
            Balanced,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}
