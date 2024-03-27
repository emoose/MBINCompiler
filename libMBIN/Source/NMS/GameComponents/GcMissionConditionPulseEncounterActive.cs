namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB5AE414E5866353, NameHash = 0x56207A2C2009340)]
    public class GcMissionConditionPulseEncounterActive : NMSTemplate
    {
        // size: 0x6
        public enum TestEncounterTypeEnum : uint {
            AnyEncounter,
            AnyObject,
            SpecificObject,
            Trader,
            AbandonedFreighter,
            AnyEncounterOtherThanTheNamedOne,
        }
        /* 0x00 */ public TestEncounterTypeEnum TestEncounterType;
        /* 0x08 */ public NMSString0x10 SpecificObjectID;
        /* 0x18 */ public bool RequireFullySpawned;
    }
}
