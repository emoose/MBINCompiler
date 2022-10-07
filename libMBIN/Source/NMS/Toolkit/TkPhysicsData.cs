namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE144A5F6E94E6409, NameHash = 0x7446EB814E05B679)]
    public class TkPhysicsData : NMSTemplate
    {
        /* 0x00 */ public float Mass;
        /* 0x04 */ public float Friction;
        /* 0x08 */ public float RollingFriction;
        /* 0x0C */ public float AngularDamping;
        /* 0x10 */ public float LinearDamping;
        /* 0x14 */ public float Gravity;
    }
}
