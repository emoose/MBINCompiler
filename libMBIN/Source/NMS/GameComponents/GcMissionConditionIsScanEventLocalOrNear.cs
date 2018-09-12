namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x28, GUID = 0x3D20567D24DE0F28)]
    public class GcMissionConditionIsScanEventLocalOrNear : NMSTemplate
    {
        public GcMissionConditionIsScanEventLocal Local;
        public float MaxDistance;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Endpadding;
    }
}
