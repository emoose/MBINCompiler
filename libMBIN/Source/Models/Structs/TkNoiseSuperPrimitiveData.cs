namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A5204789BF9D0341)]
    public class TkNoiseSuperPrimitiveData : NMSTemplate        // size: 0x1C       // also maybe part of a global?
    {
        public float Width;
        public float Height;
        public float Depth;
        public float Thickness;
        public float CornerRadiusXY;
        public float CornerRadiusZ;
        public float BottomRadiusOffset;
    }
}
