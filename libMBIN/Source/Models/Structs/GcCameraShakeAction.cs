namespace libMBIN.Models.Structs
{
    public class GcCameraShakeAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Shake;
        public float FalloffMin;
        public float FalloffMax;
    }
}
