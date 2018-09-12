using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7A4D434E17BA457F)]
    public class GcCreatureMoveAnimData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Anim;
        [NMS(Size = 0x10)]
        public string AnimLeft;
        [NMS(Size = 0x10)]
        public string AnimRight;

        public float AnimSpeed;
        public float MinSpeedScale;
        public float MaxSpeedScale;
        public float MaxPredatorSpeedScale;
    }
}
