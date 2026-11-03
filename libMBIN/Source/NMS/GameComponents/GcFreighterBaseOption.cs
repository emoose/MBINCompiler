namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD8451B20EFF56C9, NameHash = 0xC11BA0C4)]
    public class GcFreighterBaseOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcFilename BaseDataFile;
        [NMS(Index = 1)]
        /* 0x10 */ public float ProbabilityWeighting;
    }
}
