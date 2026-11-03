namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADFD57D546D429C4, NameHash = 0x8011D801)]
    public class GcAtlasSendSubmitContribution : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public int Contribution;
        [NMS(Index = 0)]
        /* 0x4 */ public int MissionIndex;
        [NMS(Index = 2)]
        /* 0x8 */ public NMSString0x80 MissionTarget;
    }
}
