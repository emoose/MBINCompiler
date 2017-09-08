namespace libMBIN.Models.Structs
{
    public class GcCreatureComponentData : NMSTemplate      // size: 0x18
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcPrimaryAxis Axis;
        public float Scaler;
    }
}
