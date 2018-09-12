namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x125AC72B0D023EDF)]
    public class GcMissionConditionHasSubstance : NMSTemplate
    {
        public GcDefaultMissionSubstanceEnum Default;
        public GcSubstanceTableEnum Substance;
        public int Amount;

    }
}
