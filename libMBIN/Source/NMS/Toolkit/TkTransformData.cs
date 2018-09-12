using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x183EF44FE92F3F19)]
    public class TkTransformData : NMSTemplate      // size: 0x24
    {
        public float TransX;
        public float TransY;
        public float TransZ;
        public float RotX;
        public float RotY;
        public float RotZ;
        public float ScaleX;
        public float ScaleY;
        public float ScaleZ;
    }
}
