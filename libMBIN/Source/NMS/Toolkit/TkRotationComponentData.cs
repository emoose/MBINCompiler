namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x920ABB044A799B85, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        /* 0x00 */ public float Speed;
        /* 0x10 */ public Vector3f Axis;
        /* 0x20 */ public bool AlwaysUpdate;
        /* 0x24 */ public int SyncGroup;
    }
}
