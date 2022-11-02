namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x8953A47FC49A5AC, NameHash = 0xA03B6D2AF8A02EAB)]
    public class TkPhysRelVectorData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Local;
        /* 0x10 */ public Vector3f Offset;
    }
}
