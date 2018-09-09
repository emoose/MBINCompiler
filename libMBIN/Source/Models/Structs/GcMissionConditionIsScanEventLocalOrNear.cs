namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x28)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        public GcMissionConditionIsScanEventLocal Local;
        public float MaxDistance;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Endpadding;
    }
}
