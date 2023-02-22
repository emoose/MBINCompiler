namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC4EE7225251C4FE1, NameHash = 0x71B8CFD20DB7A5E5)]
    public class GcInventoryTechProbability : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Tech;
        // size: 0x4
        public enum DesiredTechProbabilityEnum {
            Never,
            Rare,
            Common,
            Always,
        }
        /* 0x10 */ public DesiredTechProbabilityEnum DesiredTechProbability;
    }
}
