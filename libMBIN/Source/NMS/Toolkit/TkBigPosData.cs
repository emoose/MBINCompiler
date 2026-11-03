namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6C64498EA2C21FB4, NameHash = 0x687D5492)]
    public class TkBigPosData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public Vector3f Local;
        [NMS(Index = 1)]
        /* 0x10 */ public Vector3f Offset;
    }
}
