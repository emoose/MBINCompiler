namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC063AE08E9D2C997, NameHash = 0x9A610511)]
    public class GcMessageUpdateFrigateSpeed : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float StartSpeed;
        [NMS(Index = 1)]
        /* 0x4 */ public float TargetSpeed;
    }
}
