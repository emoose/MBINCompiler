namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE4820AF33895CBB5, NameHash = 0xB808E542DB69E5FE)]
    public class TkRotationComponentData : NMSTemplate
    {
        /* 0x00 */ public float Speed;
        /* 0x10 */ public Vector3f Axis;
        /* 0x20 */ public int SyncGroup;
    }
}
