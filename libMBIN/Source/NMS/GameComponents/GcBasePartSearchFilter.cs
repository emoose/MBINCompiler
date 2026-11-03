using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD8CA711DD3B7AE1, NameHash = 0x80F31719)]
    public class GcBasePartSearchFilter : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public Vector3f ReferenceWorldPosition;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 IsSpecificID;
        [NMS(Index = 6)]
        /* 0x20 */ public GcBaseGridSearchFilter BaseGridFilter;
        [NMS(Index = 7)]
        /* 0x4C */ public float MaxDistance;
        [NMS(Index = 5)]
        /* 0x50 */ public bool ApplyGridFilter;
        [NMS(Index = 2)]
        /* 0x51 */ public bool PartIsNotOnline;
        [NMS(Index = 4)]
        /* 0x52 */ public bool PartIsNotVision;
        [NMS(Index = 1)]
        /* 0x53 */ public bool PartIsOnline;
        [NMS(Index = 3)]
        /* 0x54 */ public bool PartIsVision;
    }
}
