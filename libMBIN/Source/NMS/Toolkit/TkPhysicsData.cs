namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E144A5F6E94E6409)]
    public class TkPhysicsData : NMSTemplate        // possibly used in a global? cf. sub_1405EAAD0 (in 1.2 exe)
    {
        public float Mass;
        public float Friction;
        public float RollingFriction;
        public float AngularDamping;
        public float LinearDamping;
        public float Gravity;
    }
}
