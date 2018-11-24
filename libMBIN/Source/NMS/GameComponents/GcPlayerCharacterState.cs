using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0xFAC1A85D2BC41DE)]
    public class GcPlayerCharacterState : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Locomotion0H;
        [NMS(Size = 0x10)]
        public string Locomotion1H;
        [NMS(Size = 0x10)]
        public string Locomotion2H;
        [NMS(Size = 0x10)]
        public string AimTree1HPitch;
        [NMS(Size = 0x10)]
        public string AimTree1HYaw;
        [NMS(Size = 0x10)]
        public string AimTree2HPitch;
        [NMS(Size = 0x10)]
        public string AimTree2HYaw;
        [NMS(Size = 0x10)]
        public string HitReact0H;
        [NMS(Size = 0x10)]
        public string HitReac1H;
        [NMS(Size = 0x10)]
        public string HitReac2H;
        public bool KeepHeadForward;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
