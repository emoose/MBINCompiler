namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CE9B6A7654ABB1A, NameHash = 0x15FCC555BAF3FC21)]
    public class GcMissionConditionInSeasonalUA : NMSTemplate
    {
        /* 0x0 */ public int SpecificRendevousPlanetIndex;
        /* 0x4 */ public bool SpecificIndexOnlyNeedsToMatchSystem;
        /* 0x5 */ public bool TakeIndexFromSeasonData;
        /* 0x6 */ public bool CompleteIfRendezvousDone;
    }
}
