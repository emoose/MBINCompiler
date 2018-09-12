namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4D166CB02862AD83)]
    public class GcMissionSequenceGoToGalacticPoint : NMSTemplate      // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public GcMissionGalacticPoint Target;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
