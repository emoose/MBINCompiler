namespace libMBIN.Models.Structs
{
    public class GcParticleAction : NMSTemplate // size: 0x38
    {
        [NMS(Size = 0x10)]
        public string Effect;
        [NMS(Size = 0x20)]
        public string Joint;
        public bool Exact;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding31;
    }
}
