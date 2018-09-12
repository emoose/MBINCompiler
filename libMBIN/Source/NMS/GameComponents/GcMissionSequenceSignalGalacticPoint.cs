namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0D77B64DA9352885D)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate     // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcMissionGalacticPoint Target;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
