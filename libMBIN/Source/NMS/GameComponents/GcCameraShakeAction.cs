namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A5442BD7F600755C)]
    public class GcCameraShakeAction : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Shake;
        public float FalloffMin;
        public float FalloffMax;
    }
}
