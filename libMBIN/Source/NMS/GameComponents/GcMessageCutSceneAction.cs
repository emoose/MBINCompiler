namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0AF664E457B8C8B, NameHash = 0xD8E1988A)]
    public class GcMessageCutSceneAction : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f Facing;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector3f Local;
        [NMS(Index = 1)]
        /* 0x20 */ public Vector3f Offset;
        [NMS(Index = 4)]
        /* 0x30 */ public Vector3f Up;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Action;
    }
}
