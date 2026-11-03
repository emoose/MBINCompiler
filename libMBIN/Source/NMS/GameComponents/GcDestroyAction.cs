namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89AAA2BD506F682B, NameHash = 0x122AE269)]
    public class GcDestroyAction : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 PlayEffect;
        [NMS(Index = 0)]
        /* 0x10 */ public bool DestroyAll;
        [NMS(Index = 1)]
        /* 0x11 */ public bool UseDestructables;
    }
}
