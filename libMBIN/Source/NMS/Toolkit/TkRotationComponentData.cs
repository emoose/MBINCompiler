namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7D64F7ED014BF7F8, NameHash = 0x8EB35CA7)]
    public class TkRotationComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f Axis;
        [NMS(Index = 0)]
        /* 0x10 */ public float Speed;
        [NMS(Index = 4)]
        /* 0x14 */ public int SyncGroup;
        [NMS(Index = 2)]
        /* 0x18 */ public bool AlwaysUpdate;
        [NMS(Index = 3)]
        /* 0x19 */ public bool UseModelNode;
    }
}
