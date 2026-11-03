namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5C03AC3DE11422, NameHash = 0xE95619A4)]
    public class GcMissionSequenceShowSeasonTimeWarning : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public float TimeToShow;
    }
}
