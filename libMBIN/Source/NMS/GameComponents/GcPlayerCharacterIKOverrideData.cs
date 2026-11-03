namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7450C98826FE09C, NameHash = 0x7B4305C5)]
    public class GcPlayerCharacterIKOverrideData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f RotStrengths;
        [NMS(Index = 1)]
        /* 0x10 */ public float Strength;
        [NMS(Index = 0)]
        /* 0x14 */ public bool Enabled;
    }
}
